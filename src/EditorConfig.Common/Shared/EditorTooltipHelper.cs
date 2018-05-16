using Microsoft.VisualStudio.Language.StandardClassification;
using Microsoft.VisualStudio.Text.Adornments;

namespace EditorConfig
{
    class EditorTooltipHelper
    {
        private static string PrettifyName(ITooltip item)
        {
            string text = item.Name
                           .Replace("_", " ")
                           .Replace("dotnet", ".NET")
                           .Replace("csharp", "C#");

            if (text.Length > 0)
                text = text[0].ToString().ToUpperInvariant() + text.Substring(1);

            return text;
        }

        public static ContainerElement CreateContent (ITooltip item)
        {
            string name = PrettifyName(item);

            string description = item.Description;

            if (!item.IsSupported)
                description += $"\n\n{Resources.Text.NotSupportedByVS}";

            return new ContainerElement(
                ContainerElementStyle.Wrapped,
                new ImageElement(item.Image),
                new ClassifiedTextElement (new ClassifiedTextRun (PredefinedClassificationTypeNames.Keyword, name)),
                new ClassifiedTextElement (new ClassifiedTextRun (PredefinedClassificationTypeNames.Identifier, "\n" + description))
                );
        }
    }
}
