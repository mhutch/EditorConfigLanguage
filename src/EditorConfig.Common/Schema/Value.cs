using Microsoft.VisualStudio.Core.Imaging;
using System;

namespace EditorConfig
{
    /// <summary>The value of a property.</summary>
    public class Value : ITooltip
    {
        private bool _isUnset;

        public Value(string name)
        {
            _isUnset = name.Is("unset");

            Name = name;
            Description = GetDescription();
            IsSupported = !_isUnset;
            Image = KnownImageIds.EnumerationItemPublic;
        }

        /// <summary>The value text.</summary>
        public string Name { get; }

        /// <summary>The value description.</summary>
        public string Description { get; }

        /// <summary>The image moniker shown in Intellisense and QuickInfo.</summary>
        public ImageId Image { get; }

        /// <summary>True if the value is supported by Visual Studio.</summary>
        public bool IsSupported { get; }

        private string GetDescription()
        {
            if (_isUnset)
                return Resources.Text.ValueUnset;

            return null;
        }
    }
}
