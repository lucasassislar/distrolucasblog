using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
