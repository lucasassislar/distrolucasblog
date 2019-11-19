nukeGet("/blog/bypage", (result) => {
    var posts = result.split('<next>');
    var originalNode = document.getElementById("innerBlog");
    var parent = document.getElementById("blog");
    var github = document.getElementById("github");
    for (var i = 0; i < posts.length; i++) {
        var lines = posts[i].split('\n');

        var newInner = originalNode.cloneNode(true);
        newInner.id = "Post" + i;
        newInner.classList.add("innerBlog");
        var c = newInner.children[0];
        c.children[1].innerHTML = lines[0];
        c.children[2].innerHTML = lines[1];
        c.children[4].innerHTML = lines[2];

        var remaining = lines.length - 2;
        var finalLine = lines[3];
        for (var j = 4; j < remaining; j++) {
            finalLine = finalLine + '<br>' + lines[2 + j];
        }
        c.children[3].innerHTML = finalLine + '<br><br>';
        //parent.appendChild(newInner);
        parent.insertBefore(newInner, github);
    }
    originalNode.hidden = true;
}, null);