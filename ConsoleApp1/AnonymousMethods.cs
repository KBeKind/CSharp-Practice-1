public delegate void PrintMessage(string message);

internal class AnonymousMethod
{
    public static void InvokeMethod()
    {
        PrintMessage printMessage = delegate (string message)
        {
            Console.WriteLine("Message: " + message);
        };
      printMessage("Hello World");
    }
}
