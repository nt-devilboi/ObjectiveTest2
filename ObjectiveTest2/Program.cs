// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//lock даёт одновренно пользоваться данными
static class Server
{
    private static int _count = 0;
    private static readonly object _lock = new();


    public static int GetCount()
    {
        lock (_lock)
        {
            return _count;
        }
    }

    public static void AddToCount(int count)
    {
        lock (_lock) // пока count меняется, GetCount будет ждать.
        {
            _count += count;
        }
    }
}