# O Padrão MVC

Model-View-Controller (MVC) tem sido uma arquitetura importante para a ciência da computação por muito anos. Originalmente nomeada como Thing-Mode-View-Editor em 1979, e depois de um tempo simplificado para Model-View-Controller. 
Um dos principais benefícios é a forma em que ela separa os conceitos dentro de uma aplicação.

## Os componentes do padrão MVC

- Model: Conjunto de classes que representam o domínio da sua aplicação. Estes objetos de domínios frequentemente encapsulam os dados armazenados numa base de dados, bem como o código que manipula-os e 
a lógica de negócios específica para cada classe de domínio. 
- View: A representação visual de um modelo.
- Controller: É o coordenador que providencia o link entre a View e a Model. A Controller é responsável por processar a entrada de informações, agindo sobre o modelo, e decidindo qual ação deve ser tomada, como renderizar uma View ou redirecionar para outra página. Continuando com o exemplo do blog, a Controller pode procura o comentário mais recente para um post (Model) e enviar para a ela ser renderizada na View.

[Colocar a imagem do MVC Pattern]
A Controller recebe a entrada do usuário, constrõe uma model apropriada e então envia para a View. Ambos, a Controller e a View tem uma dependência da Model, mas a próprio Model é mantida isolada da Controller e da View.

## Histórico

### Surgimento
O padrão MVC foi originalmente desenvolvido pela comunidade Smalltalk por volta de 1970, décadas antes de esta era de aplicações web modernas. Quando os primeiras aplicações utilizando este padrão foram desenvolvidas utiliza-se interfaces gráficas para o usuário (GUIs) e os padrões de interação ainda estavam evoluindo. Naquela época, quando o usuário pressionava uma tecla ou clicava em algum ícone na tela, um processo ficava "ouvindo", e esse processo era a controller. A controller era responsável por receber a entrada de vinha do usuário, interpretando-a e atualizava qualquer classe de dados que fosse necessária (a Model) e, em seguida, notificava o usuário de mudanças ou atualizações do programa.
No final de 1970 e início de 1980, pesquisadores da Xerox PARC (que, por coincidência, era o lugar onde o padrão MVC foi incubado) começou a trabalhar com a noção da GUI, onde os usuários "trabalhavam" dentro de um ambiente virtual "desktop" em que eles poderiam clicar e arrastar itens ao redor.
Daí veio a idéia de event-drive programming (desenvolvimento orientado-a-eventos) da programação ser baseada em eventos que eram disparados por um usuário, tais como o clique de um mouse ou o acionamento de uma tecla no teclado.
Ao longo do tempo, como GUIs tornou-se a norma, ficou claro que o padrão MVC não foi inteiramente apropriado para estes novos sistemas. Em um tal sistema, os componentes GUI eles próprios manipulavam a entrada do usuário. Se um botão fosse clicado, era o botão que respondia ao clique do mouse, não a Controller. O botão que, por sua vez, notificaria os eventuais "observers" ou "listeners" que tinha sido clicado. Padrões como o Model-View-Presenter (MVP) provou ser mais relevante para estes sistemas modernos do que o padrão MVC.

### Surgimento do padrão MVC na Web
Inicialmente popularizado pela comunidade de desenvolvimento do Ruby por volta de 2003 qaundo foi lançado a framework Ruby on Rails.

### Surgimento do padrão MVC na plataforma .NET
Como o ASP.NET Web Forms é um sistema baseado a eventos, que é único em relação a plataforma web. Ele tem um rico controle baseado no desenvolvimento orientado a eventos baseados (modelo que desenvolvedores são contra na plataforma web), fornecendo uma interface gráfica componentizada e "agradável" para a Web. Quando um botão é clicado, o controle botão responde e gera um evento para o servidor indicando que foi clicado. A beleza desta abordagem é que ela permite ao desenvolvedor trabalhar em um nível mais alto de abstração ao programar.
Indo um pouco mais a fundo, no entanto, revela-se que um monte de coisa está acontecendo para simular essa experiência orientada a eventos pelos componentes. Na sua essência, quando um botão
é clicado, o navegador envia um pedido para o servidor contendo o estado do controle na página encapsulado em um elemento HTML escondido na página. No lado do servidor, em resposta a este pedido, ASP.NET tem de reconstruir a hierarquia de controle inteira e então interpretar esse pedido, usando o conteúdo desse pedido para restaurar o estado atual do aplicativo para o usuário da atual da aplicação. Tudo isso acontece porque o conceito Web por sua natureza, é stateless. 
No desenvolvimento Windows Forms, não existe necessidade de reconstruir toda a tela e controlar hierarquia cada vez que o usuário clica em um widget na interface gráfica do usuário (GUI), porque o estado do aplicativo permanece em memória.

Com a Web, o estado da aplicação para o usuário essencialmente desaparece e, em seguida, é restaurada com cada clique. Bem, isso é uma simplificação exagerada, mas a interface do usuário sob a forma de HTML é enviado para o navegador através do servidor. Isto levanta a pergunta: "Onde está a aplicação?" Para a maioria das páginas da web, a aplicação é uma conversa entre cliente e servidor, cada um mantendo um pouquinho do estado, talvez um cookie no cliente ou o pedaço de memória no servidor, todos cuidadosamente orquestrada para cobrir a pequena mentira. A mentira é que a Internet e o protocolo HTTP pode ser programado novamente de forma stateful.
A base da programação orientada a eventos (o conceito de estado) é perdido quando programação é para a Web, e muitos não estão dispostos a abraçar a mentira de uma plataforma praticamente stateful. Diante disso, a indústria de software tem visto o ressurgimento do Padrão MVC, embora com algumas ligeiras modificações.

Um exemplo de uma tal modificação é que no MVC tradicional, o modelo pode "observar" a View através de uma associação indireta com ela. Isto permite que a Model possa alterar-se baseado nos eventos que ocorrem na View. Com MVC para a Web, no momento em que a View é enviado para o navegador, a Model não está na memória do browser e não tem a capacidade de observar eventos na View. Outra coisa, a Controller é mais uma vez "forefront". Aplicando este padrão para web exige que cada entrada do usuário para uma aplicação assuma a forma de uma requisição. Por exemplo, com o ASP.NET MVC, cada requisição é encaminhada (usando o roteamento). A Controller é inteiramente responsável por interpretar essa requisição, manipulando o modelo se necessário, e em seguida, selecionando uma View para enviar como a resposta de volta para o usuário.

#### Outras frameworks MVC

O ASP.NET MVC não é a primeira implementação do MVC Pattern no .NET Framework, tais como: 
- [MonoRail](http://www.castleproject.org/projects/monorail/): inspirada inicialmente pelo Ruby on Rails e ela trouxe o paradigma para o desenvolvimento Web .NET em 2005 e muitos dessa influência pode ser vista no ASP.NET MVC de hoje.
- [FubuMVC](http://mvc.fubu-project.org/): um projeto open source orientada por convenções (Convention-driven framework).
- [OpenRasta](http://openrasta.org): outro projeto de open source que se concentra na construção de aplicações web e serviços baseados em torno do conceito de recursos e métodos HTTP.

