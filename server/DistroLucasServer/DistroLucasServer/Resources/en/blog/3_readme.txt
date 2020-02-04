DistroLucas.com
My personal website (yay)
December 15, 2019
<b>PERSONAL RULES:</b>

<ul>
    <li>Nothing on the site should use non-personal source code</li>
    <li>Optimization is the highest priority</li>
    <li>Maybe? Make this be backwards-compatible (IE6)</li>
</ul>
<br>
This is my personal safe haven for re-inventing the wheel.

<br>
<b>BUILDING THE PROJECT</b>

<ul>
    <li>Building the server for Ubuntu </li>
    <li>dotnet build "DistroLucasServer.NETCore.csproj" --configuration Release --runtime ubuntu.18.04-x64</li>
</ul>

<br>
<b>TO-DO:</b>
    <li>GZip support</li>
    <li>Minify CSS and JS support</li>
    <li>Dynamic CSS (should I just use SASS for this?)</li>
    <li>Dynamic points to what I''ll be doing - future streams/whatever</li>
    <li>Template system (HTML being re-used already)</li>
</ul>

<br>
<b>DONE:</b>
<ul>
    <li>Paging system (index page should have everything needed to render the entire website, then later use small requests to get content)</li>
    <ul>
        <li class="sub">The URL is changed everytime you click a page, so your history is correctly built</li>
        <li class="sub">Actually using the history is not 100% (for some reason the quotes page deletes all history before it always)</li>
    </ul>
    <li>Multi-language support through cookies</li>
    <li>Paging system on the server (currently I have to create a Route for each page, even though they're all the same)</li>
    <li>Routing system automatically passes parameters to the Routes functions.</li>
</ul>

<br>
<b>LEARNED SO FAR:</b>
<ul>
    <li>JSON takes more space than just lines of text</li>
    <li>PNGs with compression can actually be lighter than JPEGs on low color count images</li>
    <li>Having all the content on the index page makes the loading of sub-pages insanely fast</li>
</ul>

<br>
<b>EXTERNAL TOOLS ALLOWED:</b>
<ul>
    <li>Anything I can't possibly develop in a timely manner, so:
    <ul>
        <li class="sub">Visual Studio Code</li>
        <li class="sub">NGinx for HTTPS (one day might rewrite my server to support HTTPS, but NGINX would just plainly be more secure)</li>
        <li class="sub">Bit.ly (no money to buy 3-letter domain name + free data without selling my soul to Google)</li>
    </ul>
</ul>

<br>
<b>TOOLS USED:</b>
<ul>
    <li>Visual Studio Code</li>
    <li>HTTPS by Certbot</li>
    <li>Reverse Proxy/HTTPS handling by NGinx</li>
    <li>Dynamic JS by NucleusJS: https://github.com/lucasassislar/nucleusjs</li>
    <li>Server by NucleusDotNet: https://github.com/lucasassislar/nucleusdotnet</li>
    <ul>
        <li class="sub">Initial HTTP server code by David Jeske</li>
        <li class="sub">Additional attributes for Route Management and listing more akin to ASP.NET/Express</li>
        <li class="sub">No caching for pages currently</li>
        <li class="sub">.NET Core 3 on Ubuntu 18</li>
    </ul>
</ul>
