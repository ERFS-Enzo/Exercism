static class LogLine
{
    public static string Message(string logLine)
    {
        int index = logLine.IndexOf(":");
        string message = logLine.Substring(index+1);
        return message.Trim();
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        int index = logLine.IndexOf("]");
        string level = logLine.Substring(1, index - 1);
        return level.ToLower();
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string level = LogLevel(logLine);
        return $"{message} ({level})";
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
