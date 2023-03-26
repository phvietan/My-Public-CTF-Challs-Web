static class Helper
{
    public static string ReadFileContent(string p)
    {
        string result = "";
        using (var sr = new StreamReader(p))
        {
            result = sr.ReadToEnd();
        }
        return result;
    }
}
