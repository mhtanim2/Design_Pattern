namespace DesignPattern.Strategy;

public class Computer : MacBook
{
    public Computer(IKeyboard keyboard) : base(keyboard)
    {
    }
}

