# Html Helpers

1. Html.BeginForm

```html

@{Html.BeginForm("Criar", "Loja", FormMethod.Post);}
    <input type="text" name="Title" />
    <button type="submit">Criar</button>
@{Html.EndForm();}

```

```html

@using (Html.BeginForm("Criar", "Loja", FormMethod.Post, new { @class = "form-horizontal" }))) {
	<hr/>
    <div class="form-group">
		 @Html.LabelFor(model => model.Titulo, "Título", htmlAttributes: new { @class = "control-label col-md-2" })
		 <div class="col-md-10">
    		<input type="text" name="Titulo" />
		</div>
    </div>
	
    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <input type="submit" value="Criar" class="btn btn-primary" />
        </div>
    </div>
}

```

2. Html.TextBox

```html

@Html.TextBoxFor(model => model.Titulo, new { htmlAttributes = new {@class = "form-control"}})

```

3. Html.DropDownList
AlbumViewModel.cs
```csharp
        public int AlbumId { get; set; }
        public IEnumerable<int> GeneroIds { get; set; }
        public IEnumerable<SelectListItem> Generos { get; set; }
        public int ArtistaId { get; set; }
        public IEnumerable<SelectListItem> Artistas { get; set; }
        public string Titulo { get; set; }
        public decimal Preco { get; set; }
        public string AlbumArtUrl { get; set; }
        public DayOfWeek DiaSemana { get; set; }
```

AlbumController.cs
```csharp
    public ActionResult Criar()
    {
        var dados = new MeusDados();
        var model = new AlbumViewModel
        {
            Artistas = new SelectList(dados.Artistas, "Id", "Nome"),
            Generos = new MultiSelectList(dados.Generos, "Id", "Nome"),
            AlbumArtUrl = "~/Images/placeholder.png"
        };
        return View(model);
    }

    [HttpPost]
    public ActionResult Criar(AlbumViewModel model)
    {
        var dados = new MeusDados();
        model = new AlbumViewModel
        {
            Artistas = new SelectList(items: dados.Artistas, dataValueField: "Id", dataTextField: "Nome"),
            Generos = new MultiSelectList(dados.Generos, "Id", "Nome"),
            AlbumArtUrl = "~/Images/placeholder.png"
        };
        return View(model);
    }
```

```html

<div class="form-group">
    @Html.LabelFor(model => model.ArtistaId, "Artista", htmlAttributes: new {@class = "control-label col-md-2"})
    <div class="col-md-10">
        @Html.DropDownListFor(model => model.ArtistaId, Model.Artistas, htmlAttributes: new {@class = "form-control"})
    </div>
</div>

```

4. Html.ListBox

```html

    <div class="form-group">
        @Html.LabelFor(model => model.GeneroIds, "Gêneros", htmlAttributes: new {@class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.ListBoxFor(model => model.GeneroIds, Model.Generos, htmlAttributes: new {@class = "form-control"})
        </div>
    </div>

```

4. Html.Editor

```csharp

	[StringLength(160)]
    [DataType(DataType.MultilineText)]
    public string Titulo { get; set; }

```

4. Template para editor

```html

    <div class="form-group">
        @Html.LabelFor(model => model.AlbumArtUrl, htmlAttributes: new {@class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(model => model.AlbumArtUrl)
        </div>
    </div>

```

Shared/EditorTemplates/Thumbnail.cshtml
```html

@model string
<div class="col-xs-6 col-md-3">
    <a href="#" class="thumbnail">
        <img src="@Url.Content(Model)" />
    </a>
</div>

```

```csharp

	[UIHint("Thumbnail")]
    public string AlbumArtUrl { get; set; }

```

4. Suporte para Enums

```html

    <div class="form-group">
        @Html.Label("Dias da semana", htmlAttributes: new { @class = "control-label col-md-2" })
        <div class="col-md-10">
            @Html.EnumDropDownListFor(model => model.DiaSemana, htmlAttributes: new { @class = "form-control" })
        </div>
    </div>

```