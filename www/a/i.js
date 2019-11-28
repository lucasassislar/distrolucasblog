function paging() {

}

// bibliography/links parsing
var bibRegex = new RegExp("%B\\[(.*?)\\]");
var bibCounter = 0;
function parseLine(line) {
    while (line.match(bibRegex)) {
        bibCounter++;
        line = line.replace(bibRegex, `<a href='$1' class='bib'>${bibCounter}</a>`);
    }
    return line;
}

nukeGet("/blog/bypage", (result) => {
    var posts = result.split('<next>');
    var originalNode = document.getElementById("innerBlog");
    var parent = document.getElementById("blog");
    for (var i = 0; i < posts.length; i++) {
        bibCounter = 0;

        var lines = posts[i].split('\n');

        var newInner = originalNode.cloneNode(true);
        newInner.id = "Post" + i;
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
    originalNode.hidden = true;
}, null);