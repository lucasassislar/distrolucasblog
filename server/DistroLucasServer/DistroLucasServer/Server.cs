using Nucleus.Gaming;
using Nucleus.Gaming.Web;
using SimpleHttpServer;
using SimpleHttpServer.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DistroLucasServer {
    public class Server {
        public int Port {
            get { return httpServer.Port; }
        }

        private HttpServer httpServer;

        public Server(ushort port) {
            RouteBuilder routeBuilder = new RouteBuilder();
            List<Route> routes = routeBuilder.BuildRoute(Assembly.GetExecutingAssembly());

            httpServer = new HttpServer(port, routes);
        }

        public void Run() {
            Console.WriteLine();
            ConsoleU.WriteLine($"Server running in port {Port}", ConsoleColor.Cyan);
            httpServer.Listen();
        }
    }
}
