using Nucleus.Gaming.Web;
using SimpleHttpServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistroLucasServer {
    [RouteManager("^/blog")]
    public class BlogRoutes {
        [Route("GET", "bypage")]
        public HttpResponse GetPostsByPage(HttpRequest request) {
            return new HttpResponse() {
                ReasonPhrase = "",
                StatusCode = "200",
                ContentAsUTF8 = "Hello World Title\nHello World Paragraph 1.\nHello World Paragraph 2"
            };
        }

        [Route("GET", "status")]
        public HttpResponse Status(HttpRequest request) {
            return new HttpResponse() {
                ReasonPhrase = "",
                StatusCode = "200",
                ContentAsUTF8 = "Server Running"
            };
        }
    }
}
