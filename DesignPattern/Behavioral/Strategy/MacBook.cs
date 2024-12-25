namespace DesignPattern.Behavioral.Strategy;

public class MacBook
{
    private readonly IKeyboard _keyboard;


    public MacBook(IKeyboard keyboard)
    {
        _keyboard = keyboard;
    }
    public void showDetail()
    {
        Console.WriteLine(_keyboard.Writeablilty());
    }

}
