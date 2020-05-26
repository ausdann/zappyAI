using System;
using zappy_test.include;

namespace zappy_test
{
    class Program
    {
        static int Main(string[] args)
        {
            Connection connection;

            try { connection = new Connection(args); }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                return 84;
            }
            return 0;
        }
    }
}
