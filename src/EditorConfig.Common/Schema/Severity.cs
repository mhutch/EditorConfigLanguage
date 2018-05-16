using Microsoft.VisualStudio.Core.Imaging;

namespace EditorConfig
{
    /// <summary>The severity determines how the property is enforced by Visual Studio.</summary>
    public class Severity : ITooltip
    {
        public Severity(string name, string description)
        {
            Name = name;
            Description = description;
        }

        /// <summary>The severity name.</summary>
        public string Name { get; }

        /// <summary>The severity description.</summary>
        public string Description { get; }

        /// <summary>True if Visual Studio supports the severity.</summary>
        public bool IsSupported => true;

        /// <summary>The image moniker shown by Intellisense and the adornment next to the severity.</summary>
        public ImageId Image
        {
            get
            {
                switch (Name)
                {
                    case "none":
                        return KnownImageIds.None;
                    case "suggestion":
                        return KnownImageIds.StatusInformation;
                    case "warning":
                        return KnownImageIds.StatusWarning;
                    case "error":
                        return KnownImageIds.StatusError;
                }

                return KnownImageIds.UnknownMember;
            }
        }
    }
}
