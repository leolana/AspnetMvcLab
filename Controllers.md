# Controller

Controllers dentro do padrão MVC são responsáveis por responder a entrada do usuário, muitas vezes, fazer alterações no modelo, em resposta à entrada do usuário. Desta forma, as Controllers do padrão MVC
estão preocupados com o fluxo da aplicação, trabalhando com dados que são fornecidos, e fornecendo-o de volta para a View relevante.
Voltando no passado, servidores web exibiam o seu conteúdo através de arquivos HTML estáticos armazenados em disco. 
Como páginas web geradas dinamicamente ganhou-se destaque, servidores web começaram a gerar os arquivos HTML em tempo real a partir de scripts dinâmicos que também estão localizados em disco.
Só que dessa forma a sua URL ficava contendo o nome e extensão da página que você estava exibindo, como: www.compreaqui.com.br/Cadastros/Usuario.aspx entre outras extensões (html, htm, jsp e etc) 
Com MVC, é um pouco diferente. A URL chama o mecanismo de rota, e está por sua vez diz qual Controller irá instanciar e qual Action Method irá chamar, e fornece os argumentos necessários
para esse método. O método da Controller decide, então, qual View irá usar e então a View renderizá-ra o HTML.
Ao invés de ter uma relação direta entre a URL e um arquivo físico no disco do servidor, existe uma relação entre o URL e um método Action em uma classe da Controller. 
ASP.NET MVC implementa na Controller o padrão Front-Controller que é uma variação do MVC, onde a Controller fica na frente de tudo, exceto o subsistema de roteamento.

Em ASP.NET MVC, essa classe é convencionalmente indicado pelo sufixo Controller.

### Actions Methods

### Session e TempData


### Using Asynchronous Controller Actions
pag 515