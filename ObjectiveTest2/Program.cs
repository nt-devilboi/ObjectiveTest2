
Console.WriteLine("Hello, World!");

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