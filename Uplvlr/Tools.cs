namespace Uplvlr
{
    public static class Tools
    {
        public static string GetFileName(string path)
        {
            string[] pathSplit = path.Split("\\");
            string fileName = pathSplit[pathSplit.Length - 1];
            return fileName;
        }
    }
}