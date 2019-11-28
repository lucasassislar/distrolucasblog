# DistroLucas.com
PERSONAL RULES:
- Nothing on the site should use non-personal source code
- Optimization is the highest priority
- Maybe? Make this be backwards-compatible (IE6)

This is my personal safe haven for re-inventing the wheel.

TO-DO:
- GZip support
- Minify CSS and JS support
- Paging system (index page should have everything needed to render the entire website, then later use small requests to get content)
- Dynamic CSS (should I just use SASS for this?)

LEARNED SO FAR:
- JSON takes more space than just lines of text
- PNGs with compression can actually be lighter than JPEGs on low color count images

EXTERNAL TOOLS ALLOWED:
- Anything I can't possibly develop in a timely manner, so:
    - Visual Studio Code
    - NGinx for HTTPS (one day might rewrite my server to support HTTPS, but NGINX would just plainly be more secure)

TOOLS USED:
- Visual Studio Code
- HTTPS by Certbot
- Reverse Proxy/HTTPS handling by NGinx
- Dynamic JS by NucleusJS: https://github.com/lucasassislar/nucleusjs
- Server by Nucleus.Gaming: https://github.com/lucasassislar/nucleusgaming
    - Initial HTTP server code by David Jeske
    - Additional attributes for Route Management and listing more akin to ASP.NET/Express
    - No caching for pages currently
	- .NET Core 3 on Ubuntu 18
