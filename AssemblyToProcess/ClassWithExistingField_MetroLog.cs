using Anotar;
using MetroLog;

public class ClassWithExistingField
{
    static ILogger existingLogger;

    static ClassWithExistingField()
    {
        existingLogger = LogManagerFactory.DefaultLogManager.GetLogger("OnException");
    }

    public void Debug()
    {
        Log.Debug();
    }
}