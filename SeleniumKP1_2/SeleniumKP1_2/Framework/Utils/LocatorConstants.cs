namespace SeleniumKP1_2.Framework.Utils
{
    internal class LocatorConstants
    {
        public static readonly string PreciseTextXpath = "//*[text()='{0}']";
        public static readonly string PartialTextXpath = "//*[contains(text(),'{0}')]";
        public static readonly string RelativePathFolder = @"..Resources\";
    }
}
