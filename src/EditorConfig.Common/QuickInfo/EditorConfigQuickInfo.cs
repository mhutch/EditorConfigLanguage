using Microsoft.VisualStudio.Language.Intellisense;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Adornments;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EditorConfig
{
    internal class EditorConfigQuickInfo : IAsyncQuickInfoSource
    {
        private ITextBuffer _buffer;
        private EditorConfigDocument _document;

        public EditorConfigQuickInfo(ITextBuffer buffer)
        {
            _buffer = buffer;
            _document = EditorConfigDocument.FromTextBuffer(buffer);
        }

        public Task<QuickInfoItem> GetQuickInfoItemAsync(IAsyncQuickInfoSession session, CancellationToken cancellationToken)
        {
            SnapshotPoint? point = session.GetTriggerPoint(_buffer.CurrentSnapshot);

            if (session == null || !point.HasValue || point.Value.Position >= point.Value.Snapshot.Length)
                return Task.FromResult<QuickInfoItem>(null);

            ParseItem item = _document.ItemAtPosition(point.Value);

            if (item == null)
                return Task.FromResult<QuickInfoItem>(null);

            ITrackingSpan lineSpan = point.Value.Snapshot.CreateTrackingSpan(item.Span, SpanTrackingMode.EdgeNegative);

            if (item.Errors.Any())
            {
                return Task.FromResult(
                    new QuickInfoItem(
                        lineSpan,
                        new ContainerElement(ContainerElementStyle.Stacked, item.Errors.Select (EditorTooltipHelper.CreateContent))));
            }

            Property property = _document.PropertyAtPosition(point.Value);

            SchemaCatalog.TryGetKeyword(property?.Keyword?.Text, out Keyword keyword);

            ITooltip tooltip = null;

            // Keyword
            if (keyword != null && item.ItemType == ItemType.Keyword)
            {
                tooltip = keyword;
            }

            // Value
            else if (keyword != null && item.ItemType == ItemType.Value)
            {
                Value value = keyword.Values.FirstOrDefault(v => v.Name.Is(item.Text));

                if (value != null && !string.IsNullOrEmpty(value.Description))
                    tooltip = value;
            }

            // Severity
            else if (item.ItemType == ItemType.Severity && SchemaCatalog.TryGetSeverity(item.Text, out Severity severity))
            {
                tooltip = severity;
            }

            // Suppression
            else if (item.ItemType == ItemType.Suppression && ErrorCatalog.TryGetErrorCode(item.Text, out var code))
            {
                tooltip = code;
            }

            if (tooltip != null)
            {
                return Task.FromResult(new QuickInfoItem(lineSpan, tooltip));
            }

            return Task.FromResult<QuickInfoItem>(null);
        }

        public void Dispose()
        {
        }
    }
}
