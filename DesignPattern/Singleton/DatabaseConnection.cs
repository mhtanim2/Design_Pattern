namespace DesignPattern.Singleton;

public class DatabaseConnection
{
    private static volatile DatabaseConnection connObj;
    private static readonly object lockObj = new object();

    private DatabaseConnection()
    {
    }

    public static DatabaseConnection getInstance()
    {
        if (connObj == null)
        {
            lock (lockObj)
            {
                if (connObj == null)
                {
                    connObj = new DatabaseConnection();
                }
            }
        }
        return connObj;
    }
}
