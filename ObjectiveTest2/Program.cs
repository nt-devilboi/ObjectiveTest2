// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//lock даёт одновренно пользоваться данными
class Server
{
    private int _count;
    private readonly object _lock = new();

    public Server()
    {
        _count = 0;
    }

    public int GetCount()
    {
        lock (_lock)
        {
            return _count;
        }
    }

    public void AddToCount(int count)
    {
        lock (_lock) // пока count меняется, GetCount будет ждать.
        {
            _count += count;
        }
    }
}