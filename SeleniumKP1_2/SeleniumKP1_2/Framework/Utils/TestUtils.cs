namespace SeleniumKP1_2.Framework.Utils
{
    internal class TestUtils
    {
        public static void DeleteFileIfExists(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
