using WindowsInput;

class Program
{
    static void Main(string[] args)
    {
        InputSimulator simulator = new InputSimulator();
        Random rand = new Random();

        while (true)
        {
            // Move the mouse to a new position
            int newX = rand.Next(0, 1920); // Adjust to your screen resolution
            int newY = rand.Next(0, 1080); // Adjust to your screen resolution
            simulator.Mouse.MoveMouseTo(newX, newY);

            Console.WriteLine($"Mouse moved to: {newX}, {newY}");

            // Wait for 1 minute before moving the mouse again
            Thread.Sleep(60000); // 60,000 milliseconds = 1 minute
        }
    }
}
