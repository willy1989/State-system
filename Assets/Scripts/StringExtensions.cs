public static class StringExtensions
{
    public static string StateStringCleanUp(this string self)
    {
        return self?.ToLower()?.Trim();
    }
}
