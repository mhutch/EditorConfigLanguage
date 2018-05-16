using System;
using Microsoft.VisualStudio.Core.Imaging;

namespace EditorConfig
{
    class KnownImageIds
    {
        private static ImageId CoreID(int index) => new ImageId(new Guid("{ae27a6b0-e345-4288-96df-5eaf394ee369}"), index);

        public static readonly ImageId ValidationRule = CoreID (3329);
        public static readonly ImageId EnumerationItemPublic = CoreID(1125);
        public static readonly ImageId None = CoreID(2089);
        public static readonly ImageId StatusInformation = CoreID(2933);
        public static readonly ImageId StatusWarning = CoreID(2956);
        public static readonly ImageId StatusError = CoreID(2926);
        public static readonly ImageId UnknownMember = CoreID(3276);
        public static readonly ImageId CSFileNode = CoreID(738);
        public static readonly ImageId DotNET = CoreID(1018);
        public static readonly ImageId Property = CoreID(2429);
    }
}
