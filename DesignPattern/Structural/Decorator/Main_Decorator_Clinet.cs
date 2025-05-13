namespace DesignPattern.Structural.Decorator;

// Component interface
public interface INotifier
{
    void Send(string message);
}

// Concrete Component
public class Notifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending message: {message}");
    }
}

// Base Decorator
public abstract class NotifierDecorator : INotifier
{
    protected INotifier _notifier;

    protected NotifierDecorator(INotifier notifier)
    {
        _notifier = notifier;
    }

    public virtual void Send(string message)
    {
        _notifier.Send(message);
    }
}

// Concrete Decorators
public class FacebookNotifier : NotifierDecorator
{
    public FacebookNotifier(INotifier notifier) : base(notifier) { }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Sending Facebook notification: {message}");
    }
}

public class SlackNotifier : NotifierDecorator
{
    public SlackNotifier(INotifier notifier) : base(notifier) { }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Sending Slack notification: {message}");
    }
}

// Client code1
public class Main_Decorator_Clinet
{
    public void Main()
    {
        INotifier notifier = new Notifier();
        INotifier facebookNotifier = new FacebookNotifier(notifier);
        INotifier slackNotifier = new SlackNotifier(facebookNotifier);

        slackNotifier.Send("Hello, Decorator Pattern!");
    }
}
