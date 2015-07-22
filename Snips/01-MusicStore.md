# Criação do projeto

1. Escolha o template ASP.NET MVC
2. Escolha a autenticação individual por usuário
3. Criar a Controller MVC Empty: StoreController.cs
4. Vamos enviar uma string para ilustrar as rotas, colando o código abaixo:

```csharp
        public string Index()
        {
            return "Estamos na Store.Index()";
        }

        public string Browse()
        {
            return "Estamos na Store.Browse()";
        }

        public string Details()
        {
            return "Estamos na Store.Details()";
        }
```

5. Passando parâmetros para a Action da Controller Store

```csharp
        public string Browse(string genre)
	{
		string message =
		HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
		
		return message;
	}
	
	public string Details(int id)
	{
        	string message = "Store.Details, ID = " + id;
        	return message;
	}
```

6. Criando uma View
7. Exibindo uma lista de gêneros utilizando ViewBag

StoreController.cs
```csharp
        public ActionResult Index()
        {
	       var genres = new List<string>();
                for (var i = 0; i < 10; i++)
                {
                        genres.Add("Gênero " + i);
                }
                ViewBag.Genres = genres;
                return View();
	}
```

Store/Index.cshtml
```html
        <ul>
	       @foreach (var g in ViewBag.Genres) {
		   <li>@g</li>
		}
	</ul>
```

8. Criar a classe Model Genre.cs e alterar a Action Index para enviar uma Model para View, criando uma View fortemente tipada
Models/Genre.cs
```csharp
        public class Genre
        {
                public int GenreId { get; set; }
                public string Name { get; set; }
                public string Description { get; set; }
        }
```
StoreController.cs
```csharp
        public ActionResult Index()
        {
	       var genres = new List<Genre>();
                for (var i = 0; i < 10; i++)
                {
                        genres.Add(new Genre { GenreId = i, Name = "Rock" });
                }
                return View(genres);
	}
```

Store/Index.cshtml
```html
        @model IEnumerable<MvcMusicStore.Models.Genre>
                
        @foreach (var genre in Model)
        {
                <li>Gênero: @genre.Name</li>
        }
```
Ou
```html
        @using MvcMusicStore.Models
        @model IEnumerable<Genre>
```

9. Definir as classes do Model
10. Definir a classe MusicStoreDb
11. Definir a classe MusicStoreDbInitialize com o Seed
12. Instanciar no global.asax a classe MusicStoreDbInitialize
13. Acertar o web.config com a connectionString para o contexto MusicStoreDb


12. Vamos criar uma nova controller para fazer o controle da nossa loja de música utilizando o scaffold read/write chamado
StoreManagerController.cs, onde vamos alterar o código gerado para ficar igual o debaixo:

StoreManagerController.cs
```csharp
         // GET: StoreManager
        public ActionResult Index()
        {
            return View();
        }

        // GET: StoreManager/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StoreManager/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StoreManager/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: StoreManager/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StoreManager/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: StoreManager/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StoreManager/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            // TODO: Add delete logic here

            return RedirectToAction("Index");
        }
```

10. Agora vamos criar as seguintes Views para a StoreManagerController.cs:
        1. Index
        2. Details
        3. Create
        4. Edit
        5. Delete
        
        
        