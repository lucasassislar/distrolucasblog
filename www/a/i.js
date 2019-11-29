// bibliography/links parsing
var bibRegex = new RegExp("%B\\[(.*?)\\]");//regex for %B[link]
var bibCounter = 0;
var firstLoad = true;
function parseLine(line) {
    while (line.match(bibRegex)) {
        bibCounter++;
        line = line.replace(bibRegex, `<a href='$1' class='bib'>${bibCounter}</a>`);
    }
    return line;
}

function loadPage(requestPage, pageLink) {
    if (firstLoad) {
        firstLoad = false;
    } else {
        window.scrollTo(0, 0);
        if (pageLink.length == 1) {
            window.history.pushState("", "", '?page=blog');
        } else {
            window.history.pushState("", "", `?page=${pageLink}`);
        }
    }

    nukeGet(requestPage, (result) => {
        var originalNode = document.getElementById("innerBlog");
        var parent = document.getElementById("blog");
        for (var i = 0; i < parent.children.length; i++) {
            // delete everything that isn't the originalNode
            var child = parent.children[i];
            if (child == originalNode) {
                continue;
            }
            parent.removeChild(child);
            i--;
        }

        var pageIndex = result.indexOf('distroContent');
        if (pageIndex >= 0 && pageIndex < 128) {
            var pageContent = document.createElement("div");
            pageContent.classList.add("innerBlog");

            var actualContent = document.createElement("div");
            actualContent.classList.add("contentText");
            actualContent.innerHTML = result;
            pageContent.appendChild(actualContent);

            parent.appendChild(pageContent);
        } else {
            var posts = result.split('<next>');
            for (var i = 0; i < posts.length; i++) {
                bibCounter = 0;
                var lines = posts[i].split('\n');

                var newInner = originalNode.cloneNode(true);
                newInner.hidden = false;
                newInner.classList.add("innerBlog");
                var c = newInner.children[0];
                c.children[1].innerHTML = lines[0];
                c.children[2].innerHTML = lines[1];
                c.children[4].innerHTML = lines[2];

                var remaining = lines.length;
                for (var j = 3; j < remaining; j++) {
                    var line = parseLine(lines[j]);
                    var span = document.createElement("p");
                    span.innerHTML = line;
                    span.className = "blogText";
                    c.children[3].appendChild(span);
                }
                parent.appendChild(newInner);
            }
        }
        originalNode.hidden = true;
    }, null);
}

function loadPageFromCurrentLocation() {
    // see if we're on the index page/anything else
    var urlParams = new URLSearchParams(window.location.search);
    var page = urlParams.get("page");
    var requestPage;
    if (page == null || page == "blog") {
        requestPage = "/blog/bypage";
    } else {
        requestPage = `/w/${page}`;
    }

    loadPage(requestPage, page);
}

// wait for browser to load
document.addEventListener("DOMContentLoaded", function (event) {
    loadPageFromCurrentLocation();
});

window.onpopstate = function (event) {
    loadPageFromCurrentLocation();
}
