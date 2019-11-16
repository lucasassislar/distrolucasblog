using Nucleus.Gaming;
using Nucleus.Gaming.Web;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public HttpResponse GetPostsByPage(HttpRequest request) {
            DirectoryInfo postsDir = new DirectoryInfo(Path.Combine(AssemblyUtil.GetStartFolder(), "Resources"));
            List<FileInfo> files = postsDir.GetFiles().ToList();
            files.Sort(CompareFile);

            string content = "";
            for (int i = 0; i < files.Count; i++) { 
                FileInfo file = files[i];
                if (i > 0) {
                    content += "<next>";
                }
                string text = File.ReadAllText(file.FullName);
                content += text;
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
