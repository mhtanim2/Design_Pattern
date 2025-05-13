
namespace DesignPattern.Structural.Decorator.Problem;

public interface INotifier
{
    void Send();
}

public class Notifier : INotifier
{
    private readonly string message;

    public Notifier(string message)
    {
        this.message = message;
    }
    public virtual void Send()
    {
        Console.WriteLine($"Sending Message through: {message}");
    }
}

public class FacebookNotifierInheritance : Notifier
{
    public FacebookNotifierInheritance(string message) : base(message)
    {
        
    }
    public override void Send()
    {
        base.Send();
    }
}

// What if we need both Facebook and Slack? We'd need another class!
public class FacebookAndSlackNotifierInheritance : Notifier
{
    public FacebookAndSlackNotifierInheritance(string message) : base(message)
    {
        
    }
    public override void Send()
    {
        base.Send();
    }
}

public class SlackNotifierInheritance : Notifier
{
    public SlackNotifierInheritance(string message) : base(message)
    {
        
    }
    public override void Send()
    {
        base.Send();
    }
}

public static class Main_Decorator_Clinet_Problem
{
    public static void Main()
    {
        INotifier facebookAndSlackNotifier = new FacebookAndSlackNotifierInheritance("Facebook and Slack message via inheritance.");
        facebookAndSlackNotifier.Send();
    }
}


/*
 I have to create multiple class for multiple resposnibility, so I could use a wrapper class over the notification which can deligate the work to the process
 */