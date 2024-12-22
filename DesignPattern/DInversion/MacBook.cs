namespace DesignPattern.DInversion;

public class MacBook
{
    private readonly IKeyboard _keyboard;
    private readonly IMouse _mouse;

    public MacBook(IKeyboard keyboard, IMouse mouse)
    {
        _keyboard = keyboard;
        _mouse = mouse;
    }
    public void showDetail()
    {
        Console.WriteLine(_keyboard.Writeablilty());
        Console.WriteLine(_mouse.Moveablity());
    }

}
