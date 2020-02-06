using Nucleus;
using Nucleus.Web;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DistroLucasServer {
    [RouteManager("^/blog")]
    public class BlogRoutes {
        private int CompareFile(FileInfo fileA, FileInfo fileB) {
            int underlineA = fileA.Name.IndexOf("_");
            int numberA = int.Parse(fileA.Name.Remove(underlineA, fileA.Name.Length - underlineA));

            int underlineB = fileB.Name.IndexOf("_");
            int numberB = int.Parse(fileB.Name.Remove(underlineB, fileB.Name.Length - underlineB));

            return numberB.CompareTo(numberA);
        }

        [Route("GET", "bypage")]
        public HttpResponse GetPostsByPage(HttpRequest request, string language) {
            Console.WriteLine("Get Posts By Page");

            DirectoryInfo postsDir = new DirectoryInfo(Path.Combine(AssemblyUtil.GetApplicationRoot(), "Resources", language, "blog"));
            List<FileInfo> files = postsDir.GetFiles().ToList();
            files.Sort(CompareFile);

            string content = "";
            bool first = true;
            for (int i = 0; i < files.Count; i++) { 
                FileInfo file = files[i];
                string text = File.ReadAllText(file.FullName);
                if (text.Contains("!IGNORE")) {
                    continue;
                }

                if (!first) {
                    content += "<next>";
                }
                content += text;
                first = false;
            }

            return new HttpResponse() {
                ReasonPhrase = "",
                StatusCode = "200",
                ContentAsUTF8 = content
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
