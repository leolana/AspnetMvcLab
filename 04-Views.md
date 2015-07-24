## View

A View é responsável por fornecer a interface de usuário (UI) para o usuário. Após a Controller executar a lógica apropriada
para a URL solicitada, ela delega a exibição para a View.
Ao contrário de frameworks web baseados em arquivos, como ASP.NET Web Forms e PHP, Views não estão diretamente acessíveis.
Você não pode chamar a View do seu browser para que ele renderize-a. Em vez disso, a View é sempre chamada por uma Controller, 
que fornece os dados para esta View.
Em alguns casos simples, a View precisa de pouca ou nenhuma informação a partir da Controller. Mais frequentemente, a
Controller precisa fornecer algumas informações para a View, assim ela passa um objeto de transferência de dados (DTO) chamado de
Model. A View transforma a Model para um formato pronto para ser apresentada ao usuário. Em ASP.NET MVC, a View realiza isso examinando 
o objeto Model entregue a ele pela Controller e transforma o conteúdo para uma representação em HTML.

### Convenções
Como ASP.NET MVC encontra a View correta para renderizar e como você pode substituí-lo para especificar uma View em especial para uma 
Action da Controller.
As Actions da Controller você olhou até agora neste capítulo chamado apenas de 

```cs
	return View ();
```

para retornar a View que não foi necessário especificar o nome da View. Isso porque eles tiram proveito de algumas convenções implícitas 
no ASP.NET MVC Framework, que definem a lógica para selecionar a View.
Quando você cria uma novo projeto, você vai perceber que o projeto contém um diretório Views estruturado de um modo 
muito específico (ver Figura).

Cada pasta da Controller contém um arquivo de exibição para cada método Action, e o arquivo (.cshtml) é nomeado com o mesmo nome da Action. 
Isso fornece a base para Views como estão associados a uma Action.
A lógica da View seleção olha para uma exibição com o mesmo nome que a ação dentro do diretórico */Views/ControllerName* 
(o nome da Controller sem o sufixo da Controller neste caso). A View selecionada, neste caso, seria */Views/Home/Index.cshtml*.

Como a maioria das coisas no ASP.NET MVC, você pode sobreescrever esta convenção. Suponha que você queira a ação Índice para renderizar 
uma View diferente. Você poderia fornecer um nome de exibição diferente, como segue:



### Conhecendo ViewBag, ViewData e ViewDataDictionary

### Views fortemente tipadas

### View Models

### View Engines

### Razor View Engine

#### Síntaxe do Razor

### Code Expressions

### Layouts

### Partial Views

### ViewStart