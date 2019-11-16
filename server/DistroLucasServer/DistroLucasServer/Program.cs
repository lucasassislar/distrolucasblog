using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistroLucasServer {
    class Program {
        static void Main(string[] args) {
            Server server = new Server(9000, args[0]);
            server.Run();
        }
    }
}
