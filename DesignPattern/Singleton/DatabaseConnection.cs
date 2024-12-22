namespace DesignPattern.Singleton;
//Singleton Desing Pattern

// One instace will be created throughout the lifetime
/*

 Steps:
i. Private contractor so that nobody can create object
ii. Class variable
iii. Class Method for inserting the method one time

 */

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
