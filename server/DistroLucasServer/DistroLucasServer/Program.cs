using System;

namespace DistroLucasServer {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("DistroServer starting...");
            Server server = new Server(9557, args[0]);
            Console.WriteLine("DistroServer created");
            server.Run();
        }
    }
}
