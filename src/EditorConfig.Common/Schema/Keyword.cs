﻿using Microsoft.VisualStudio.Core.Imaging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EditorConfig
{
    /// <summary>The keyword is the name-part of a property.</summary>
    public class Keyword : ITooltip
    {
        public Keyword(string name, string description, IEnumerable<string> values, bool unsupported, bool hidden, bool multiple, bool severity)
        {
            Name = name;
            Description = description;
            Values = values.Select(v => new Value(v));
            IsSupported = !unsupported;
            IsVisible = !hidden;
            SupportsMultipleValues = multiple;
            RequiresSeverity = severity;
        }

        /// <summary>The keyword of the property.</summary>
        public string Name { get; }

        /// <summary>The description of the property.</summary>
        public string Description { get; }

        /// <summary>A list of values applicable to the property.</summary>
        public IEnumerable<Value> Values { get; }

        /// <summary>True if the property is supported by Visual Studio.</summary>
        public bool IsSupported { get; }

        /// <summary>True if the property shows up in Intellisense.</summary>
        public bool IsVisible { get; }

        /// <summary>True if the value can be a comman separated list.</summary>
        public bool SupportsMultipleValues { get; }

        public bool RequiresSeverity { get; }

        /// <summary>The category is used in the Intellisense filters.</summary>
        public Category Category
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(Name))
                {
                    if (Name.StartsWith("csharp_", StringComparison.OrdinalIgnoreCase))
                        return Category.CSharp;
                    else if (Name.StartsWith("dotnet_", StringComparison.OrdinalIgnoreCase))
                        return Category.DotNet;
                    else
                        return Category.Standard;
                }

                return Category.None;
            }
        }

        /// <summary>The image moniker that represents the property.</summary>
        public ImageId Image
        {
            get
            {
                switch (Category)
                {
                    case Category.CSharp:
                        return KnownImageIds.CSFileNode;
                    case Category.DotNet:
                        return KnownImageIds.DotNET;
                }

                return KnownImageIds.Property;
            }
        }
    }
}
