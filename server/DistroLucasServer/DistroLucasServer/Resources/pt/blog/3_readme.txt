DistroLucas.com
Meu site pessoal (yay)
15 de Dezembro, 2019
<b>REGRAS PESSOAIS:</b>

<ul>
    <li>Nada no site pode user código não-essoal</li>
    <li>Otimização é a prioridade mais alta</li>
    <li>Talvez? Fazer o site ser backwards-compatible (IE6)</li>
</ul>
<br>
Esse é meu porto seguro para re-inventar a roda.

<br>
<b>COMPILANDO O PROJETO</b>

<ul>
    <li>Compilando o server em Ubuntu</li>
    <li>dotnet build "DistroLucasServer.NETCore.csproj" --configuration Release --runtime ubuntu.18.04-x64</li>
</ul>

<br>
<b>PRA FAZER:</b>
    <li>Suporte pra GZip</li>
    <li>Minificar CSS e JS</li>
    <li>CSS Dinamico (será que eu uso SASS pra isso?)</li>
    <li>Widgets dinamicos do que estou fazendo/vou fazer</li>
    <li>Sistema de templates</li>
</ul>

<br>
<b>FEITO:</b>
<ul>
    <li>Sistema de paginação (página de index tem que ter tudo pra renderizar o site inteiro, depois só fazer small requests pra carregar o conteúdo)</li>
    <ul>
        <li class="sub">A URL muda toda vez que você clica em uma página, então seu histórico e construído corretamente.</li>
        <li class="sub">Na real usar o histórico não está 100% (por alguma razão a página de Quotes deleta todo o histórico depois que você clica nela).</li>
    </ul>
    <li>Suporte a múltiplas linguagens por cookies</li>
    <li>Sistema de paginação no server</li>
    <li>Sistema de routing passa os parametros automaticamente para as rotas</li>
</ul>

<br>
<b>APRENDIDO ATÉ AGORA:</b>
<ul>
    <li>JSON ocupa mais espaço do que só linhas de texto</li>
    <li>PNGs com compressão podem ser mais leves que JPEG com imagens com poucas cores</li>
    <li>Ter todo o conteúdo na página de index torna o carregamento de sub-páginas insanamente rápido.</li>
</ul>

<br>
<b>FERRAMENTAS EXTERNAS PERMITIDAS:</b>
<ul>
    <li>Qualquer coisa que eu não tenho tempo de desenvolver:
    <ul>
        <li class="sub">Visual Studio Code</li>
        <li class="sub">NGinx pra usar HTTPS (um dia meu servidor pode suportar HTTPS, mas o risco de segurança é altissimo, não vale a pena)</li>
        <li class="sub">Bit.ly (nunca que eu teria dinheiro pra comprar um dominio de letras + o fato que eu consigo ver o tráfico dos links sem vender minha alma pro Google)</li>
    </ul>
</ul>

<br>
<b>FERRAMENTAS USADAS:</b>
<ul>
    <li>Visual Studio Code</li>
    <li>HTTPS pelo Certbot</li>
    <li>Reverse Proxy/HTTPS handling pelo NGinx</li>
    <li>Dynamic JS pelo NucleusJS: https://github.com/lucasassislar/nucleusjs</li>
    <li>Server pelo NucleusDotNet: https://github.com/lucasassislar/nucleusdotnet</li>
    <ul>
        <li class="sub">Código inicial do server HTTP por David Jeske</li>
        <li class="sub">Atributos adicionais para management de rotas e listing mais igual ASP.NET/Express</li>
        <li class="sub">Sem cache para páginas atualmente</li>
        <li class="sub">.NET Core 3 rodando em Ubuntu 18</li>
    </ul>
</ul>
