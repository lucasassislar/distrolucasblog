using Nucleus;
using Nucleus.Web;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace DistroLucasServer {
    [RouteManager("^/w")]
    public class WebsiteRoutes {
        private HttpResponse CustomPageRedirect(HttpRequest request, string pageName) {
            Console.WriteLine($"{pageName} requested");

            Dictionary<string, string> headers = new Dictionary<string, string>();
            string host = request.Headers["Host"];

            headers.Add("Connection", "keep-alive");
            headers.Add("Date", DateTime.Now.ToString(CultureInfo.InvariantCulture));
            headers.Add("Server", "distrolucas");
            headers.Add("Location", $"http://{host}/?page={pageName}");

            return new HttpResponse() {
                ReasonPhrase = "OK",
                StatusCode = "301",
                ContentAsUTF8 = "",
                Headers = headers
            };
        }

        [Route("GET", "")]
        public HttpResponse CustomPage(HttpRequest request, string pageName, string language) {
            string baseFolder = Path.Combine(AssemblyUtil.GetApplicationRoot(), "Resources", language);
            string filePath = Path.Combine(baseFolder, pageName);
            string txtPath = filePath + ".txt";
            if (File.Exists(txtPath)) {
                filePath = txtPath;
            } else {
                string htmlPath = filePath + ".html";
                if (File.Exists(htmlPath)) {
                    filePath = htmlPath;
                }
            }

            FileInfo file = new FileInfo(filePath);
            return new HttpResponse() {
                ReasonPhrase = "",
                StatusCode = "200",
                ContentAsUTF8 = File.ReadAllText(file.FullName)
            };
        }

    }
}
