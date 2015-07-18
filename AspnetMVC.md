## Asp.net MVC

ASP.NET MVC oferece uma alternativa para Web Forms para a construção de aplicações web na a plataforma .NET. 
Ele foi primeiramente revelada pela Microsoft em novembro de 2007 e, desde então, teve 5 grandes lançamentos até agora e estamos aguardando a 6 versão que promete revolucionar tudo o que acreditamos na plataforma ASP.NET. 
MVC significa Model-View-Controller, um padrão de projeto que é muito popular no espaço de desenvolvimento web.
Como uma alternativa para Web Forms, ASP.NET MVC tem uma abordagem diferente quando se trata de estrtuturações de aplicações web. Isto significa que você não vai ser lidar com páginas e controls ASPX, postbacks ou view state, ou ciclos de vida de eventos complicados. Em vez disso, você estará definindo Controllers, Actions e Views. A plataforma ASP.NET é a mesmo, porém,assim que coisas como HTTP handlers e HTTP modules ainda se aplicam.

### Benefícios do ASP.NET MVC

Ao fazer uso do padrão MVC, o ASP.NET MVC oferece várias vantagens sobre ASP.NET Web Forms.

#### Mais próximo do protocolo

Enquanto o ASP.NET Web Forms tenta esconder completamente a natureza stateless do HTTP, o ASP.NET MVC NÃO. 
Ao adotar o padrão MVC e mapear uma única solicitação HTTP para uma única chamada de método. O ASP.NET MVC oferece uma experiência de desenvolvimento que é muito mais familiar a qualquer pessoa com um pouco de desenvolvimento web. O modelo é também drasticamente simplificado - ido são os eventos de ciclo de vida complexos da página do Web Forms e as abstrações sobre HTTP são mínimas.

#### Separação de conceitos

Enquanto o ASP.NET Web Forms acoplava a interface de usuário com o seu code-behind, ASP.NET MVC encouraja um design de projeto onde a interface de usuário (a View) é mantida separada a partir do código que à aciona (a Controller). Quando implementado bem, isto significa que aplicações podem facilmente ser navegadas por desenvolvedores e também criar uma aplicação mais fácil de dar manutenção - criando alterações na Controller que não necessariamente significa que tenha que alterar a sua interface do usuário (View).

#### Testabilidade

Separando a lógica da aplicação a partir da interface do usuário ASP.NET MVC criar uma forma de realizar testes mais facilmente de forma a isolar os componentes individualmente. Classes Controllers podem ser testadas sem testar a sua atual interface do usuário. AO contrário do Web Forms, MVC Controllers não tem dependência direta com a classe HttpContext, cuja qual era o problema ao tentar realizar testes no code-behind do Web Forms.
