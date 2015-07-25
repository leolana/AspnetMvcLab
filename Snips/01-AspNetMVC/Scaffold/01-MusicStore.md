# Criação do projeto

1. Escolha o template ASP.NET MVC
2. Escolha a autenticação individual por usuário
3. Criar a Controller MVC Empty: LojaController.cs
4. Vamos enviar uma string para ilustrar as rotas, colando o código abaixo:

```csharp
        public string Index()
        {
            return "Estamos na Loja.Index()";
        }

        public string Browse()
        {
            return "Estamos na Loja.Browse()";
        }

        public string Details()
        {
            return "Estamos na Loja.Details()";
        }
```

5. Passando parâmetros para a Action da Controller Loja

```csharp
        public string Browse(string genre)
	{
		string message =
		HttpUtility.HtmlEncode("Loja.Browse, Genre = " + genre);
		
		return message;
	}
	
	public string Details(int id)
	{
        	string message = "Loja.Details, ID = " + id;
        	return message;
	}
```

6. Criando uma View
7. Exibindo uma lista de gêneros utilizando ViewBag

LojaController.cs
```csharp
        public ActionResult Index()
        {
	       var generos = new List<string>();
                for (var i = 0; i < 10; i++)
                {
                        generos.Add("Gênero " + i);
                }
                ViewBag.Generos = generos;
                return View();
	}
```

Loja/Index.cshtml
```html
        <ul>
	       @foreach (var g in ViewBag.Generos) {
		   <li>@g</li>
		}
	</ul>
```

8. Criar a classe Model Genero.cs e alterar a Action Index para enviar uma Model para View, criando uma View fortemente tipada
Models/Genero.cs
```csharp
        public class Genero
        {
                public int Id { get; set; }
                public string Nome { get; set; }
                public string Descricao { get; set; }
        }
```
LojaController.cs
```csharp
        public ActionResult Index()
        {
	       var generos = new List<Genero>();
                for (var i = 0; i < 10; i++)
                {
                        generos.Add(new Genero { Id = i, Nome = "Rock" });
                }
                return View(generos);
	}
```

Loja/Index.cshtml
```html
        @model IEnumerable<MvcLojaMusica.Models.Genero>
                
        @foreach (var genero in Model)
        {
                <li>Gênero: @genero.Nome</li>
        }
```
Ou

```html
        @using MvcLojaMusica.Models
        @model IEnumerable<Genero>
```

Ou põe no Web.config o namespace

9. Definir as classes do Model
10. Definir a classe MusicStoreDb
11. Definir a classe MusicStoreDbInitialize com o Seed
12. Instanciar no global.asax a classe MusicStoreDbInitialize

Global.asax.cs
```csharp

        Database.SetInitializer(new MusicStoreDbInitializer());
        
```

13. Acertar o web.config com a connectionString para o contexto MusicStoreDb
```xml
<add name="MusicStoreDb" connectionString="Data Source=(localdb)\v11.0; Initial Catalog=MusicStoreDb-20130929160340; Integrated Security=True; MultipleActiveResultSets=True; AttachDbFilename=|DataDirectory|MusicStoreDB-20130929160340.mdf" providerName="System.Data.SqlClient" />
```

12. Vamos criar uma nova controller para fazer o controle da nossa loja de música utilizando o scaffold read/write chamado
AlbumController.cs.

13. Scaffold com Entity Framework

        
        