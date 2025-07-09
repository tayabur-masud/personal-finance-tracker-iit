namespace PersonalFinanceTrackerIIT.Handlers;

public static class GlobalExceptionHandler
{
    public static void ThreadException(object sender, ThreadExceptionEventArgs e)
    {
        HandleException(e.Exception);
    }

    public static void UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        Exception? ex = e.ExceptionObject as Exception;
        if (ex != null)
        {
            HandleException(ex);
        }
    }

    private static void HandleException(Exception ex)
    {
        LogException(ex);
        MessageBox.Show("An unexpected error occurred:\n" + ex.Message,
            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private static void LogException(Exception ex)
    {
        string logFile = "error_log.txt";
        File.AppendAllText(logFile,
            $"[{DateTime.Now}] {ex.Message}\n{ex.StackTrace}\n\n");
    }
}
