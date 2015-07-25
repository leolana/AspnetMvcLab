using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MvcMusicStore.Models
{
    public class MusicStoreDbInitializer : DropCreateDatabaseAlways<MusicStoreDb>
    {
        protected override void Seed(MusicStoreDb context)
        {
            const string imgUrl = "~/Images/placeholder.png";

            AddAlbums(context, imgUrl, AddGenres(context), AddArtists(context));

            base.Seed(context);
        }

        private static void AddAlbums(
            MusicStoreDb context,
            string imgUrl,
            List<Genero> genres,
            List<Artista> artists)
        {
            var albums = new[]
            {
                new Album
                {
                    Titulo = "The Best Of The Men At Work",
                    Genero = genres.Single(g => g.Nome == "Pop"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Men At Work"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "...And Justice For All",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "עד גבול האור",
                    Genero = genres.Single(g => g.Nome == "World"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "אריק אינשטיין"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Black Light Syndrome",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Terry Bozzio, Tony Levin & Steve Stevens"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "10,000 Days",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Tool"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "11i",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Supreme Beings of Leisure"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "1960",
                    Genero = genres.Single(g => g.Nome == "Indie"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Soul-Junk"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "4x4=12 ",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "deadmau5"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "A Copland Celebration, Vol. I",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "London Symphony Orchestra"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "A Lively Mind",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Paul Oakenfold"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "A Matter of Life and Death",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "A Real Dead One",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "A Real Live One",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "A Rush of Blood to the Head",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Coldplay"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "A Soprano Inspired",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Britten Sinfonia, Ivor Bolton & Lesley Garrett"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "A Winter Symphony",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sarah Brightman"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Abbey Road",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Beatles"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Ace Of Spades",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Motörhead"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Achtung Baby",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "U2"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Acústico MTV",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Os Paralamas Do Sucesso"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Adams, John: The Chairman Dances",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Edo de Waart & San Francisco Symphony"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Adrenaline",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deftones"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Ænima",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Tool"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Afrociberdelia",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Chico Science & Nação Zumbi"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "After the Goldrush",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Neil Young"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Airdrawn Dagger",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sasha"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Album Title Goes Here",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "deadmau5"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Alcohol Fueled Brewtality Live! [Disc 1]",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Black Label Society"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Alcohol Fueled Brewtality Live! [Disc 2]",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Black Label Society"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Alive 2007",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Daft Punk"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "All I Ask of You",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sarah Brightman"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Amen (So Be It)",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Paddy Casey"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Animal Vehicle",
                    Genero = genres.Single(g => g.Nome == "Pop"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Axis of Awesome"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Ao Vivo [IMPORT]",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Zeca Pagodinho"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Apocalyptic Love",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Slash"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Appetite for Destruction",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Guns N' Roses"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Are You Experienced?",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Jimi Hendrix"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Arquivo II",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Os Paralamas Do Sucesso"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Arquivo Os Paralamas Do Sucesso",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Os Paralamas Do Sucesso"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "A-Sides",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Soundgarden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Audioslave",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Audioslave"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Automatic for the People",
                    Genero = genres.Single(g => g.Nome == "Alternative"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "R.E.M."),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Axé Bahia 2001",
                    Genero = genres.Single(g => g.Nome == "Pop"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Various Artists"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Babel",
                    Genero = genres.Single(g => g.Nome == "Alternative"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Mumford & Sons"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Bach: Goldberg Variations",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Wilhelm Kempff"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Bach: The Brandenburg Concertos",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Orchestra of The Age of Enlightenment"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Bach: The Cello Suites",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Yo-Yo Ma"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Bach: Toccata & Fugue in D Minor",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Ton Koopman"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Bad Motorfinger",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Soundgarden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Balls to the Wall",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Accept"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Banadeek Ta'ala",
                    Genero = genres.Single(g => g.Nome == "World"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Amr Diab"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Barbie Girl",
                    Genero = genres.Single(g => g.Nome == "Pop"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Aqua"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Bark at the Moon (Remastered)",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Ozzy Osbourne"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Bartok: Violin & Viola Concertos",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Yehudi Menuhin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Barulhinho Bom",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Marisa Monte"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "BBC Sessions [Disc 1] [Live]",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "BBC Sessions [Disc 2] [Live]",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Be Here Now",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Oasis"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Bedrock 11 Compiled & Mixed",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "John Digweed"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Berlioz: Symphonie Fantastique",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Michael Tilson Thomas"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Beyond Good And Evil",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Cult"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Big Bad Wolf ",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Armand Van Helden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Big Ones",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Aerosmith"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Black Album",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Black Sabbath Vol. 4 (Remaster)",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Black Sabbath"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Black Sabbath",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Black Sabbath"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Black",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Blackwater Park",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Opeth"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Blizzard of Ozz",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Ozzy Osbourne"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Blood",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "In This Moment"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Blue Moods",
                    Genero = genres.Single(g => g.Nome == "Jazz"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Incognito"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Blue",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Weezer"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Bongo Fury",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Frank Zappa & Captain Beefheart"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Boys & Girls",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Alabama Shakes"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Brave New World",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "B-Sides 1980-1990",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "U2"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Bunkka",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Paul Oakenfold"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "By The Way",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Red Hot Chili Peppers"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Cake: B-Sides and Rarities",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Cake"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Californication",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Red Hot Chili Peppers"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Carmina Burana",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Boston Symphony Orchestra & Seiji Ozawa"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Carried to Dust (Bonus Track Version)",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Calexico"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Carry On",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Chris Cornell"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Cássia Eller - Sem Limite [Disc 1]",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Cássia Eller"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Chemical Wedding",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Bruce Dickinson"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Chill: Brazil (Disc 1)",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Marcos Valle"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Chill: Brazil (Disc 2)",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Antônio Carlos Jobim"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Chocolate Starfish And The Hot Dog Flavored Water",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Limp Bizkit"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Chronicle, Vol. 1",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Creedence Clearwater Revival"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Chronicle, Vol. 2",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Creedence Clearwater Revival"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Ciao, Baby",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "TheStart"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Cidade Negra - Hits",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Cidade Negra"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Classic Munkle: Turbo Edition",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Munkle"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Classics: The Best of Sarah Brightman",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sarah Brightman"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Coda",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Come Away With Me",
                    Genero = genres.Single(g => g.Nome == "Jazz"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Norah Jones"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Come Taste The Band",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deep Purple"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Comfort Eagle",
                    Genero = genres.Single(g => g.Nome == "Alternative"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Cake"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Common Reaction",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Uh Huh Her "),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Compositores",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "O Terço"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Contraband",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Velvet Revolver"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Core",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Stone Temple Pilots"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Cornerstone",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Styx"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Cosmicolor",
                    Genero = genres.Single(g => g.Nome == "Rap"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "M-Flo"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Cross",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Justice"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Culture of Fear",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Thievery Corporation"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Da Lama Ao Caos",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Chico Science & Nação Zumbi"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Dakshina",
                    Genero = genres.Single(g => g.Nome == "World"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deva Premal"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Dark Side of the Moon",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Pink Floyd"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Death Magnetic",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Deep End of Down",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Above the Fold"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Deep Purple In Rock",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deep Purple"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Deixa Entrar",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Falamansa"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Deja Vu",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Crosby, Stills, Nash, and Young"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Di Korpu Ku Alma",
                    Genero = genres.Single(g => g.Nome == "World"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Lura"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Diary of a Madman (Remastered)",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Ozzy Osbourne"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Diary of a Madman",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Ozzy Osbourne"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Dirt",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Alice in Chains"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Diver Down",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Van Halen"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Djavan Ao Vivo - Vol. 02",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Djavan"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Djavan Ao Vivo - Vol. 1",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Djavan"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Drum'n'bass for Papa",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Plug"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Duluth",
                    Genero = genres.Single(g => g.Nome == "Country"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Trampled By Turtles"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Dummy",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Portishead"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Duos II",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Luciana Souza/Romero Lubambo"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Earl Scruggs and Friends",
                    Genero = genres.Single(g => g.Nome == "Country"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Earl Scruggs"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Eden",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sarah Brightman"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "El Camino",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Black Keys"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Elegant Gypsy",
                    Genero = genres.Single(g => g.Nome == "Jazz"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Al di Meola"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Elements Of Life",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Tiësto"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Elis Regina-Minha História",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Elis Regina"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Emergency On Planet Earth",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Jamiroquai"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Emotion",
                    Genero = genres.Single(g => g.Nome == "World"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Papa Wemba"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "English Renaissance",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The King's Singers"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Every Kind of Light",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Posies"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Faceless",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Godsmack"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Facelift",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Alice in Chains"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Fair Warning",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Van Halen"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Fear of a Black Planet",
                    Genero = genres.Single(g => g.Nome == "Rap"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Public Enemy"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Fear Of The Dark",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Feels Like Home",
                    Genero = genres.Single(g => g.Nome == "Jazz"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Norah Jones"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Fireball",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deep Purple"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Fly",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sarah Brightman"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "For Those About To Rock We Salute You",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "AC/DC"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Four",
                    Genero = genres.Single(g => g.Nome == "Blues"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Blues Traveler"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Frank",
                    Genero = genres.Single(g => g.Nome == "Pop"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Amy Winehouse"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Further Down the Spiral",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Nine Inch Nails"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Garage Inc. (Disc 1)",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Garage Inc. (Disc 2)",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Garbage",
                    Genero = genres.Single(g => g.Nome == "Alternative"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Garbage"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Good News For People Who Love Bad News",
                    Genero = genres.Single(g => g.Nome == "Indie"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Modest Mouse"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Gordon",
                    Genero = genres.Single(g => g.Nome == "Alternative"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Barenaked Ladies"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Górecki: Symphony No. 3",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Adrian Leaper & Doreen de Feis"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Greatest Hits I",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Queen"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Greatest Hits II",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Queen"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Greatest Hits",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Duck Sauce"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Greatest Hits",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Lenny Kravitz"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Greatest Hits",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Lenny Kravitz"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Greatest Kiss",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Kiss"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Greetings from Michigan",
                    Genero = genres.Single(g => g.Nome == "Indie"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sufjan Stevens"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Group Therapy",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Above & Beyond"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Handel: The Messiah (Highlights)",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Scholars Baroque Ensemble"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Haydn: Symphonies 99 - 104",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Royal Philharmonic Orchestra"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Heart of the Night",
                    Genero = genres.Single(g => g.Nome == "Jazz"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Spyro Gyra"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Heart On",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Eagles of Death Metal"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Holy Diver",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Dio"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Homework",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Daft Punk"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Hot Rocks, 1964-1971 (Disc 1)",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Rolling Stones"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Houses Of The Holy",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "How To Dismantle An Atomic Bomb",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "U2"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Human",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Projected"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Hunky Dory",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "David Bowie"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Hymns",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Projected"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Hysteria",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Def Leppard"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "In Absentia",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Porcupine Tree"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "In Between",
                    Genero = genres.Single(g => g.Nome == "Pop"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Paul Van Dyk"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "In Rainbows",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Radiohead"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "In Step",
                    Genero = genres.Single(g => g.Nome == "Blues"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Stevie Ray Vaughan & Double Trouble"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "In the court of the Crimson King",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "King Crimson"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "In Through The Out Door",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "In Your Honor [Disc 1]",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Foo Fighters"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "In Your Honor [Disc 2]",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Foo Fighters"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Indestructible",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Rancid"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Infinity",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Journey"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Into The Light",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "David Coverdale"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Introspective",
                    Genero = genres.Single(g => g.Nome == "Pop"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Pet Shop Boys"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Iron Maiden",
                    Genero = genres.Single(g => g.Nome == "Blues"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "ISAM",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Amon Tobin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "IV",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Jagged Little Pill",
                    Genero = genres.Single(g => g.Nome == "Alternative"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Alanis Morissette"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Jagged Little Pill",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Alanis Morissette"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Jorge Ben Jor 25 Anos",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Jorge Ben"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Jota Quest-1995",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Jota Quest"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Kick",
                    Genero = genres.Single(g => g.Nome == "Alternative"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "INXS"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Kill 'Em All",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Kind of Blue",
                    Genero = genres.Single(g => g.Nome == "Jazz"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Miles Davis"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "King For A Day Fool For A Lifetime",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Faith No More"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Kiss",
                    Genero = genres.Single(g => g.Nome == "Pop"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Carly Rae Jepsen"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Last Call",
                    Genero = genres.Single(g => g.Nome == "Country"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Cayouche"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Le Freak",
                    Genero = genres.Single(g => g.Nome == "R&B"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Chic"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Le Tigre",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Le Tigre"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Led Zeppelin I",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Led Zeppelin II",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Led Zeppelin III",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Let There Be Rock",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "AC/DC"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Little Earthquakes",
                    Genero = genres.Single(g => g.Nome == "Alternative"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Tori Amos"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Live [Disc 1]",
                    Genero = genres.Single(g => g.Nome == "Blues"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Black Crowes"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Live [Disc 2]",
                    Genero = genres.Single(g => g.Nome == "Blues"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Black Crowes"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Live After Death",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Live At Donington 1992 (Disc 1)",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Live At Donington 1992 (Disc 2)",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Live on Earth",
                    Genero = genres.Single(g => g.Nome == "Jazz"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Cat Empire"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Live On Two Legs [Live]",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Pearl Jam"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Living After Midnight",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Judas Priest"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Living",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Paddy Casey"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Load",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Love Changes Everything",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sarah Brightman"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "MacArthur Park Suite",
                    Genero = genres.Single(g => g.Nome == "R&B"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Donna Summer"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Machine Head",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deep Purple"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Magical Mystery Tour",
                    Genero = genres.Single(g => g.Nome == "Pop"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Beatles"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Mais Do Mesmo",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Legião Urbana"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Maquinarama",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Skank"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Marasim",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Jagjit Singh"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Mascagni: Cavalleria Rusticana",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "James Levine"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Master of Puppets",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Mechanics & Mathematics",
                    Genero = genres.Single(g => g.Nome == "Pop"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Venus Hum"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Mental Jewelry",
                    Genero = genres.Single(g => g.Nome == "Alternative"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Live"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Metallics",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "meteora",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Linkin Park"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Meus Momentos",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Gonzaguinha"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Mezmerize",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "System Of A Down"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Mezzanine",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Massive Attack"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Miles Ahead",
                    Genero = genres.Single(g => g.Nome == "Jazz"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Miles Davis"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Milton Nascimento Ao Vivo",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Milton Nascimento"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Minas",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Milton Nascimento"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Minha Historia",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Chico Buarque"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Misplaced Childhood",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Marillion"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "MK III The Final Concerts [Disc 1]",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deep Purple"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Morning Dance",
                    Genero = genres.Single(g => g.Nome == "Jazz"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Spyro Gyra"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Motley Crue Greatest Hits",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Mötley Crüe"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Moving Pictures",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Rush"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Mozart: Chamber Music",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Nash Ensemble"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Mozart: Symphonies Nos. 40 & 41",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Berliner Philharmoniker"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Murder Ballads",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Nick Cave and the Bad Seeds"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Music For The Jilted Generation",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Prodigy"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "My Generation - The Very Best Of The Who",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Who"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "My Name is Skrillex",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Skrillex"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Na Pista",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Cláudio Zoli"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Nevermind",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Nirvana"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "New Adventures In Hi-Fi",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "R.E.M."),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "New Divide",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Linkin Park"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "New York Dolls",
                    Genero = genres.Single(g => g.Nome == "Punk"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "New York Dolls"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "News Of The World",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Queen"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Nielsen: The Six Symphonies",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Göteborgs Symfoniker & Neeme Järvi"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Night At The Opera",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Queen"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Night Castle",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Trans-Siberian Orchestra"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Nkolo",
                    Genero = genres.Single(g => g.Nome == "World"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Lokua Kanza"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "No More Tears (Remastered)",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Ozzy Osbourne"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "No Prayer For The Dying",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "No Security",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Rolling Stones"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "O Brother, Where Art Thou?",
                    Genero = genres.Single(g => g.Nome == "Country"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Alison Krauss"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "O Samba Poconé",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Skank"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "O(+>",
                    Genero = genres.Single(g => g.Nome == "R&B"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Prince"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Oceania",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Smashing Pumpkins"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Off the Deep End",
                    Genero = genres.Single(g => g.Nome == "Pop"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Weird Al"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "OK Computer",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Radiohead"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Olodum",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Olodum"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "One Love",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "David Guetta"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Operation: Mindcrime",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Queensrÿche"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Opiate",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Tool"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Outbreak",
                    Genero = genres.Single(g => g.Nome == "Jazz"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Dennis Chambers"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Pachelbel: Canon & Gigue",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "English Concert & Trevor Pinnock"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Paid in Full",
                    Genero = genres.Single(g => g.Nome == "Rap"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Eric B. and Rakim"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Para Siempre",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Vicente Fernandez"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Pause",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Four Tet"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Peace Sells... but Who's Buying",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Megadeth"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Physical Graffiti [Disc 1]",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Physical Graffiti [Disc 2]",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Physical Graffiti",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Piece Of Mind",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Pinkerton",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Weezer"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Plays Metallica By Four Cellos",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Apocalyptica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Pop",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "U2"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Powerslave",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Prenda Minha",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Caetano Veloso"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Presence",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Pretty Hate Machine",
                    Genero = genres.Single(g => g.Nome == "Alternative"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Nine Inch Nails"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Prisoner",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Jezabels"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Privateering",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Mark Knopfler"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Prokofiev: Romeo & Juliet",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Michael Tilson Thomas"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Prokofiev: Symphony No.1",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sergei Prokofiev & Yuri Temirkanov"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "PSY's Best 6th Part 1",
                    Genero = genres.Single(g => g.Nome == "Pop"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "PSY"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Purcell: The Fairy Queen",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "London Classical Players"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Purpendicular",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deep Purple"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Purple",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Stone Temple Pilots"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Quanta Gente Veio Ver (Live)",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Gilberto Gil"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Quanta Gente Veio ver--Bônus De Carnaval",
                    Genero = genres.Single(g => g.Nome == "Jazz"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Gilberto Gil"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Quiet Songs",
                    Genero = genres.Single(g => g.Nome == "Jazz"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Aisha Duo"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Raices",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Los Tigres del Norte"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Raising Hell",
                    Genero = genres.Single(g => g.Nome == "Rap"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Run DMC"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Raoul and the Kings of Spain ",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Tears For Fears"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Rattle And Hum",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "U2"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Raul Seixas",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Raul Seixas"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Recovery [Explicit]",
                    Genero = genres.Single(g => g.Nome == "Rap"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Eminem"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Reign In Blood",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Slayer"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Relayed",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Yes"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "ReLoad",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Respighi:Pines of Rome",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Eugene Ormandy"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Restless and Wild",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Accept"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Retrospective I (1974-1980)",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Rush"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Revelations",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Audioslave"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Revolver",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Beatles"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Ride the Lighting ",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Ride The Lightning",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Ring My Bell",
                    Genero = genres.Single(g => g.Nome == "R&B"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Anita Ward"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Riot Act",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Pearl Jam"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Rise of the Phoenix",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Before the Dawn"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Rock In Rio [CD1]",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Rock In Rio [CD2]",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Rock In Rio [CD2]",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Roda De Funk",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Funk Como Le Gusta"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Room for Squares",
                    Genero = genres.Single(g => g.Nome == "Pop"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "John Mayer"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Root Down",
                    Genero = genres.Single(g => g.Nome == "Jazz"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Jimmy Smith"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Rounds",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Four Tet"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Rubber Factory",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Black Keys"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Rust in Peace",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Megadeth"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Sambas De Enredo 2001",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Various Artists"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Santana - As Years Go By",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Santana"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Santana Live",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Santana"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Saturday Night Fever",
                    Genero = genres.Single(g => g.Nome == "R&B"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Bee Gees"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Scary Monsters and Nice Sprites",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Skrillex"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Scheherazade",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Chicago Symphony Orchestra & Fritz Reiner"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "SCRIABIN: Vers la flamme",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Christopher O'Riley"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Second Coming",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Stone Roses"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Serie Sem Limite (Disc 1)",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Tim Maia"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Serie Sem Limite (Disc 2)",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Tim Maia"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Serious About Men",
                    Genero = genres.Single(g => g.Nome == "Rap"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Rubberbandits"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Seventh Son of a Seventh Son",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Short Bus",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Filter"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Sibelius: Finlandia",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Berliner Philharmoniker"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Singles Collection",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "David Bowie"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Six Degrees of Inner Turbulence",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Dream Theater"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Slave To The Empire",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "T&N"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Slaves And Masters",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deep Purple"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Slouching Towards Bethlehem",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Robert James"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Smash",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Offspring"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Something Special",
                    Genero = genres.Single(g => g.Nome == "Country"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Dolly Parton"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Somewhere in Time",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Song(s) You Know By Heart",
                    Genero = genres.Single(g => g.Nome == "Country"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Jimmy Buffett"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Sound of Music",
                    Genero = genres.Single(g => g.Nome == "Punk"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Adicts"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "South American Getaway",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The 12 Cellists of The Berlin Philharmonic"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Sozinho Remix Ao Vivo",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Caetano Veloso"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Speak of the Devil",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Ozzy Osbourne"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Spiritual State",
                    Genero = genres.Single(g => g.Nome == "Rap"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Nujabes"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "St. Anger",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Still Life",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Opeth"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Stop Making Sense",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Talking Heads"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Stormbringer",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deep Purple"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Stranger than Fiction",
                    Genero = genres.Single(g => g.Nome == "Punk"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Bad Religion"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Strauss: Waltzes",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Eugene Ormandy"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Supermodified",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Amon Tobin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Supernatural",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Santana"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Surfing with the Alien (Remastered)",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Joe Satriani"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Switched-On Bach",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Wendy Carlos"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Symphony",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sarah Brightman"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Szymanowski: Piano Works, Vol. 1",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Martin Roscoe"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Tchaikovsky: The Nutcracker",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "London Symphony Orchestra"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Ted Nugent",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Ted Nugent"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Teflon Don",
                    Genero = genres.Single(g => g.Nome == "Rap"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Rick Ross"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Tell Another Joke at the Ol' Choppin' Block",
                    Genero = genres.Single(g => g.Nome == "Indie"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Danielson Famile"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Temple of the Dog",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Temple of the Dog"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Ten",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Pearl Jam"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Texas Flood",
                    Genero = genres.Single(g => g.Nome == "Blues"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Stevie Ray Vaughan"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Battle Rages On",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deep Purple"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Beast Live",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Paul D'Ianno"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Best Of 1980-1990",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "U2"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Best of 1990–2000",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sarah Brightman"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Best of Beethoven",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Nicolaus Esterhazy Sinfonia"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Best Of Billy Cobham",
                    Genero = genres.Single(g => g.Nome == "Jazz"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Billy Cobham"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Best of Ed Motta",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Ed Motta"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Best Of Van Halen, Vol. I",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Van Halen"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Bridge",
                    Genero = genres.Single(g => g.Nome == "R&B"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Melanie Fiona"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Cage",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Tygers of Pan Tang"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Chicago Transit Authority",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Chicago "),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Chronic",
                    Genero = genres.Single(g => g.Nome == "Rap"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Dr. Dre"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Colour And The Shape",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Foo Fighters"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Crane Wife",
                    Genero = genres.Single(g => g.Nome == "Alternative"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Decemberists"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Cream Of Clapton",
                    Genero = genres.Single(g => g.Nome == "Blues"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Eric Clapton"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Cure",
                    Genero = genres.Single(g => g.Nome == "Pop"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Cure"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Dark Side Of The Moon",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Pink Floyd"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Divine Conspiracy",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Epica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Doors",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Doors"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Dream of the Blue Turtles",
                    Genero = genres.Single(g => g.Nome == "Pop"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sting"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Essential Miles Davis [Disc 1]",
                    Genero = genres.Single(g => g.Nome == "Jazz"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Miles Davis"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Essential Miles Davis [Disc 2]",
                    Genero = genres.Single(g => g.Nome == "Jazz"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Miles Davis"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Final Concerts (Disc 2)",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deep Purple"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Final Frontier",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Head and the Heart",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Head and the Heart"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Joshua Tree",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "U2"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Last Night of the Proms",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "BBC Concert Orchestra"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Lumineers",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Lumineers"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Number of The Beast",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Number of The Beast",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Police Greatest Hits",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Police"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Song Remains The Same (Disc 1)",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Song Remains The Same (Disc 2)",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Southern Harmony and Musical Companion",
                    Genero = genres.Single(g => g.Nome == "Blues"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Black Crowes"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Spade",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Butch Walker & The Black Widows"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Stone Roses",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Stone Roses"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Suburbs",
                    Genero = genres.Single(g => g.Nome == "Indie"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Arcade Fire"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Three Tenors Disc1/Disc2",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Carreras, Pavarotti, Domingo"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Trees They Grow So High",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sarah Brightman"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The Wall",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Pink Floyd"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "The X Factor",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Them Crooked Vultures",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Them Crooked Vultures"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "This Is Happening",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "LCD Soundsystem"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Thunder, Lightning, Strike",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Go! Team"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Time to Say Goodbye",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sarah Brightman"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Time, Love & Tenderness",
                    Genero = genres.Single(g => g.Nome == "Pop"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Michael Bolton"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Tomorrow Starts Today",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Mobile"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Tribute",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Ozzy Osbourne"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Tuesday Night Music Club",
                    Genero = genres.Single(g => g.Nome == "Alternative"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sheryl Crow"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Umoja",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "BLØF"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Under the Pink",
                    Genero = genres.Single(g => g.Nome == "Alternative"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Tori Amos"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Undertow",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Tool"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Un-Led-Ed",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Dread Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Unplugged [Live]",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Kiss"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Unplugged",
                    Genero = genres.Single(g => g.Nome == "Blues"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Eric Clapton"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Unplugged",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Eric Clapton"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Untrue",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Burial"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Use Your Illusion I",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Guns N' Roses"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Use Your Illusion II",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Guns N' Roses"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Use Your Illusion II",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Guns N' Roses"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Van Halen III",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Van Halen"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Van Halen",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Van Halen"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Version 2.0",
                    Genero = genres.Single(g => g.Nome == "Alternative"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Garbage"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Vinicius De Moraes",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Vinícius De Moraes"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Virtual XI",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Voodoo Lounge",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Rolling Stones"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Vozes do MPB",
                    Genero = genres.Single(g => g.Nome == "Latin"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Various Artists"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Vs.",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Pearl Jam"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Wagner: Favourite Overtures",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sir Georg Solti & Wiener Philharmoniker"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Walking Into Clarksdale",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Page & Plant"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Wapi Yo",
                    Genero = genres.Single(g => g.Nome == "World"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Lokua Kanza"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "War",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "U2"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Warner 25 Anos",
                    Genero = genres.Single(g => g.Nome == "Jazz"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Antônio Carlos Jobim"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Wasteland R&Btheque",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Raunchy"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Watermark",
                    Genero = genres.Single(g => g.Nome == "Electronic"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Enya"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "We Were Exploding Anyway",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "65daysofstatic"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Weill: The Seven Deadly Sins",
                    Genero = genres.Single(g => g.Nome == "Classical"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Orchestre de l'Opéra de Lyon"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "White Pony",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deftones"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Who's Next",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Who"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Wish You Were Here",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Pink Floyd"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "With Oden on Our Side",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Amon Amarth"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Worlds",
                    Genero = genres.Single(g => g.Nome == "Jazz"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Aaron Goldberg"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Worship Music",
                    Genero = genres.Single(g => g.Nome == "Metal"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Anthrax"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "X&Y",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Coldplay"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Xinti",
                    Genero = genres.Single(g => g.Nome == "World"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sara Tavares"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Yano",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Yano"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Yesterday Once More Disc 1/Disc 2",
                    Genero = genres.Single(g => g.Nome == "Pop"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Carpenters"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Zooropa",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "U2"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Titulo = "Zoso",
                    Genero = genres.Single(g => g.Nome == "Rock"),
                    Preco = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                }
            };

            context.Albums.AddRange(albums);
        }

        private static List<Artista> AddArtists(MusicStoreDb context)
        {
            var artists = new List<Artista>
            {
                new Artista {Nome = "65daysofstatic"},
                new Artista {Nome = "Aaron Goldberg"},
                new Artista {Nome = "Above & Beyond"},
                new Artista {Nome = "Above the Fold"},
                new Artista {Nome = "AC/DC"},
                new Artista {Nome = "Accept"},
                new Artista {Nome = "Adicts"},
                new Artista {Nome = "Adrian Leaper & Doreen de Feis"},
                new Artista {Nome = "Aerosmith"},
                new Artista {Nome = "Aisha Duo"},
                new Artista {Nome = "Al di Meola"},
                new Artista {Nome = "Alabama Shakes"},
                new Artista {Nome = "Alanis Morissette"},
                new Artista {Nome = "Alberto Turco & Nova Schola Gregoriana"},
                new Artista {Nome = "Alice in Chains"},
                new Artista {Nome = "Alison Krauss"},
                new Artista {Nome = "Amon Amarth"},
                new Artista {Nome = "Amon Tobin"},
                new Artista {Nome = "Amr Diab"},
                new Artista {Nome = "Amy Winehouse"},
                new Artista {Nome = "Anita Ward"},
                new Artista {Nome = "Anthrax"},
                new Artista {Nome = "Antônio Carlos Jobim"},
                new Artista {Nome = "Apocalyptica"},
                new Artista {Nome = "Aqua"},
                new Artista {Nome = "Armand Van Helden"},
                new Artista {Nome = "Arcade Fire"},
                new Artista {Nome = "Audioslave"},
                new Artista {Nome = "Bad Religion"},
                new Artista {Nome = "Barenaked Ladies"},
                new Artista {Nome = "BBC Concert Orchestra"},
                new Artista {Nome = "Bee Gees"},
                new Artista {Nome = "Before the Dawn"},
                new Artista {Nome = "Berliner Philharmoniker"},
                new Artista {Nome = "Billy Cobham"},
                new Artista {Nome = "Black Label Society"},
                new Artista {Nome = "Black Sabbath"},
                new Artista {Nome = "BLØF"},
                new Artista {Nome = "Blues Traveler"},
                new Artista {Nome = "Boston Symphony Orchestra & Seiji Ozawa"},
                new Artista {Nome = "Britten Sinfonia, Ivor Bolton & Lesley Garrett"},
                new Artista {Nome = "Bruce Dickinson"},
                new Artista {Nome = "Buddy Guy"},
                new Artista {Nome = "Burial"},
                new Artista {Nome = "Butch Walker & The Black Widows"},
                new Artista {Nome = "Caetano Veloso"},
                new Artista {Nome = "Cake"},
                new Artista {Nome = "Calexico"},
                new Artista {Nome = "Carly Rae Jepsen"},
                new Artista {Nome = "Carreras, Pavarotti, Domingo"},
                new Artista {Nome = "Cássia Eller"},
                new Artista {Nome = "Cayouche"},
                new Artista {Nome = "Chic"},
                new Artista {Nome = "Chicago "},
                new Artista {Nome = "Chicago Symphony Orchestra & Fritz Reiner"},
                new Artista {Nome = "Chico Buarque"},
                new Artista {Nome = "Chico Science & Nação Zumbi"},
                new Artista {Nome = "Choir Of Westminster Abbey & Simon Preston"},
                new Artista {Nome = "Chris Cornell"},
                new Artista {Nome = "Christopher O'Riley"},
                new Artista {Nome = "Cidade Negra"},
                new Artista {Nome = "Cláudio Zoli"},
                new Artista {Nome = "Coldplay"},
                new Artista {Nome = "Creedence Clearwater Revival"},
                new Artista {Nome = "Crosby, Stills, Nash, and Young"},
                new Artista {Nome = "Daft Punk"},
                new Artista {Nome = "Danielson Famile"},
                new Artista {Nome = "David Bowie"},
                new Artista {Nome = "David Coverdale"},
                new Artista {Nome = "David Guetta"},
                new Artista {Nome = "deadmau5"},
                new Artista {Nome = "Deep Purple"},
                new Artista {Nome = "Def Leppard"},
                new Artista {Nome = "Deftones"},
                new Artista {Nome = "Dennis Chambers"},
                new Artista {Nome = "Deva Premal"},
                new Artista {Nome = "Dio"},
                new Artista {Nome = "Djavan"},
                new Artista {Nome = "Dolly Parton"},
                new Artista {Nome = "Donna Summer"},
                new Artista {Nome = "Dr. Dre"},
                new Artista {Nome = "Dread Zeppelin"},
                new Artista {Nome = "Dream Theater"},
                new Artista {Nome = "Duck Sauce"},
                new Artista {Nome = "Earl Scruggs"},
                new Artista {Nome = "Ed Motta"},
                new Artista {Nome = "Edo de Waart & San Francisco Symphony"},
                new Artista {Nome = "Elis Regina"},
                new Artista {Nome = "Eminem"},
                new Artista {Nome = "English Concert & Trevor Pinnock"},
                new Artista {Nome = "Enya"},
                new Artista {Nome = "Epica"},
                new Artista {Nome = "Eric B. and Rakim"},
                new Artista {Nome = "Eric Clapton"},
                new Artista {Nome = "Eugene Ormandy"},
                new Artista {Nome = "Faith No More"},
                new Artista {Nome = "Falamansa"},
                new Artista {Nome = "Filter"},
                new Artista {Nome = "Foo Fighters"},
                new Artista {Nome = "Four Tet"},
                new Artista {Nome = "Frank Zappa & Captain Beefheart"},
                new Artista {Nome = "Fretwork"},
                new Artista {Nome = "Funk Como Le Gusta"},
                new Artista {Nome = "Garbage"},
                new Artista {Nome = "Gerald Moore"},
                new Artista {Nome = "Gilberto Gil"},
                new Artista {Nome = "Godsmack"},
                new Artista {Nome = "Gonzaguinha"},
                new Artista {Nome = "Göteborgs Symfoniker & Neeme Järvi"},
                new Artista {Nome = "Guns N' Roses"},
                new Artista {Nome = "Gustav Mahler"},
                new Artista {Nome = "In This Moment"},
                new Artista {Nome = "Incognito"},
                new Artista {Nome = "INXS"},
                new Artista {Nome = "Iron Maiden"},
                new Artista {Nome = "Jagjit Singh"},
                new Artista {Nome = "James Levine"},
                new Artista {Nome = "Jamiroquai"},
                new Artista {Nome = "Jimi Hendrix"},
                new Artista {Nome = "Jimmy Buffett"},
                new Artista {Nome = "Jimmy Smith"},
                new Artista {Nome = "Joe Satriani"},
                new Artista {Nome = "John Digweed"},
                new Artista {Nome = "John Mayer"},
                new Artista {Nome = "Jorge Ben"},
                new Artista {Nome = "Jota Quest"},
                new Artista {Nome = "Journey"},
                new Artista {Nome = "Judas Priest"},
                new Artista {Nome = "Julian Bream"},
                new Artista {Nome = "Justice"},
                new Artista {Nome = "Orchestre de l'Opéra de Lyon"},
                new Artista {Nome = "King Crimson"},
                new Artista {Nome = "Kiss"},
                new Artista {Nome = "LCD Soundsystem"},
                new Artista {Nome = "Le Tigre"},
                new Artista {Nome = "Led Zeppelin"},
                new Artista {Nome = "Legião Urbana"},
                new Artista {Nome = "Lenny Kravitz"},
                new Artista {Nome = "Les Arts Florissants & William Christie"},
                new Artista {Nome = "Limp Bizkit"},
                new Artista {Nome = "Linkin Park"},
                new Artista {Nome = "Live"},
                new Artista {Nome = "Lokua Kanza"},
                new Artista {Nome = "London Symphony Orchestra"},
                new Artista {Nome = "Los Tigres del Norte"},
                new Artista {Nome = "Luciana Souza/Romero Lubambo"},
                new Artista {Nome = "Lulu Santos"},
                new Artista {Nome = "Lura"},
                new Artista {Nome = "Marcos Valle"},
                new Artista {Nome = "Marillion"},
                new Artista {Nome = "Marisa Monte"},
                new Artista {Nome = "Mark Knopfler"},
                new Artista {Nome = "Martin Roscoe"},
                new Artista {Nome = "Massive Attack"},
                new Artista {Nome = "Maurizio Pollini"},
                new Artista {Nome = "Megadeth"},
                new Artista {Nome = "Mela Tenenbaum, Pro Musica Prague & Richard Kapp"},
                new Artista {Nome = "Melanie Fiona"},
                new Artista {Nome = "Men At Work"},
                new Artista {Nome = "Metallica"},
                new Artista {Nome = "M-Flo"},
                new Artista {Nome = "Michael Bolton"},
                new Artista {Nome = "Michael Tilson Thomas"},
                new Artista {Nome = "Miles Davis"},
                new Artista {Nome = "Milton Nascimento"},
                new Artista {Nome = "Mobile"},
                new Artista {Nome = "Modest Mouse"},
                new Artista {Nome = "Mötley Crüe"},
                new Artista {Nome = "Motörhead"},
                new Artista {Nome = "Mumford & Sons"},
                new Artista {Nome = "Munkle"},
                new Artista {Nome = "Nash Ensemble"},
                new Artista {Nome = "Neil Young"},
                new Artista {Nome = "New York Dolls"},
                new Artista {Nome = "Nick Cave and the Bad Seeds"},
                new Artista {Nome = "Nicolaus Esterhazy Sinfonia"},
                new Artista {Nome = "Nine Inch Nails"},
                new Artista {Nome = "Nirvana"},
                new Artista {Nome = "Norah Jones"},
                new Artista {Nome = "Nujabes"},
                new Artista {Nome = "O Terço"},
                new Artista {Nome = "Oasis"},
                new Artista {Nome = "Olodum"},
                new Artista {Nome = "Opeth"},
                new Artista {Nome = "Orchestra of The Age of Enlightenment"},
                new Artista {Nome = "Os Paralamas Do Sucesso"},
                new Artista {Nome = "Ozzy Osbourne"},
                new Artista {Nome = "Paddy Casey"},
                new Artista {Nome = "Page & Plant"},
                new Artista {Nome = "Papa Wemba"},
                new Artista {Nome = "Paul D'Ianno"},
                new Artista {Nome = "Paul Oakenfold"},
                new Artista {Nome = "Paul Van Dyk"},
                new Artista {Nome = "Pearl Jam"},
                new Artista {Nome = "Pet Shop Boys"},
                new Artista {Nome = "Pink Floyd"},
                new Artista {Nome = "Plug"},
                new Artista {Nome = "Porcupine Tree"},
                new Artista {Nome = "Portishead"},
                new Artista {Nome = "Prince"},
                new Artista {Nome = "Projected"},
                new Artista {Nome = "PSY"},
                new Artista {Nome = "Public Enemy"},
                new Artista {Nome = "Queen"},
                new Artista {Nome = "Queensrÿche"},
                new Artista {Nome = "R.E.M."},
                new Artista {Nome = "Radiohead"},
                new Artista {Nome = "Rancid"},
                new Artista {Nome = "Raul Seixas"},
                new Artista {Nome = "Raunchy"},
                new Artista {Nome = "Red Hot Chili Peppers"},
                new Artista {Nome = "Rick Ross"},
                new Artista {Nome = "Robert James"},
                new Artista {Nome = "London Classical Players"},
                new Artista {Nome = "Royal Philharmonic Orchestra"},
                new Artista {Nome = "Run DMC"},
                new Artista {Nome = "Rush"},
                new Artista {Nome = "Santana"},
                new Artista {Nome = "Sara Tavares"},
                new Artista {Nome = "Sarah Brightman"},
                new Artista {Nome = "Sasha"},
                new Artista {Nome = "Scholars Baroque Ensemble"},
                new Artista {Nome = "Scorpions"},
                new Artista {Nome = "Sergei Prokofiev & Yuri Temirkanov"},
                new Artista {Nome = "Sheryl Crow"},
                new Artista {Nome = "Sir Georg Solti & Wiener Philharmoniker"},
                new Artista {Nome = "Skank"},
                new Artista {Nome = "Skrillex"},
                new Artista {Nome = "Slash"},
                new Artista {Nome = "Slayer"},
                new Artista {Nome = "Soul-Junk"},
                new Artista {Nome = "Soundgarden"},
                new Artista {Nome = "Spyro Gyra"},
                new Artista {Nome = "Stevie Ray Vaughan & Double Trouble"},
                new Artista {Nome = "Stevie Ray Vaughan"},
                new Artista {Nome = "Sting"},
                new Artista {Nome = "Stone Temple Pilots"},
                new Artista {Nome = "Styx"},
                new Artista {Nome = "Sufjan Stevens"},
                new Artista {Nome = "Supreme Beings of Leisure"},
                new Artista {Nome = "System Of A Down"},
                new Artista {Nome = "T&N"},
                new Artista {Nome = "Talking Heads"},
                new Artista {Nome = "Tears For Fears"},
                new Artista {Nome = "Ted Nugent"},
                new Artista {Nome = "Temple of the Dog"},
                new Artista {Nome = "Terry Bozzio, Tony Levin & Steve Stevens"},
                new Artista {Nome = "The 12 Cellists of The Berlin Philharmonic"},
                new Artista {Nome = "The Axis of Awesome"},
                new Artista {Nome = "The Beatles"},
                new Artista {Nome = "The Black Crowes"},
                new Artista {Nome = "The Black Keys"},
                new Artista {Nome = "The Carpenters"},
                new Artista {Nome = "The Cat Empire"},
                new Artista {Nome = "The Cult"},
                new Artista {Nome = "The Cure"},
                new Artista {Nome = "The Decemberists"},
                new Artista {Nome = "The Doors"},
                new Artista {Nome = "The Eagles of Death Metal"},
                new Artista {Nome = "The Go! Team"},
                new Artista {Nome = "The Head and the Heart"},
                new Artista {Nome = "The Jezabels"},
                new Artista {Nome = "The King's Singers"},
                new Artista {Nome = "The Lumineers"},
                new Artista {Nome = "The Offspring"},
                new Artista {Nome = "The Police"},
                new Artista {Nome = "The Posies"},
                new Artista {Nome = "The Prodigy"},
                new Artista {Nome = "The Rolling Stones"},
                new Artista {Nome = "The Rubberbandits"},
                new Artista {Nome = "The Smashing Pumpkins"},
                new Artista {Nome = "The Stone Roses"},
                new Artista {Nome = "The Who"},
                new Artista {Nome = "Them Crooked Vultures"},
                new Artista {Nome = "TheStart"},
                new Artista {Nome = "Thievery Corporation"},
                new Artista {Nome = "Tiësto"},
                new Artista {Nome = "Tim Maia"},
                new Artista {Nome = "Ton Koopman"},
                new Artista {Nome = "Tool"},
                new Artista {Nome = "Tori Amos"},
                new Artista {Nome = "Trampled By Turtles"},
                new Artista {Nome = "Trans-Siberian Orchestra"},
                new Artista {Nome = "Tygers of Pan Tang"},
                new Artista {Nome = "U2"},
                new Artista {Nome = "UB40"},
                new Artista {Nome = "Uh Huh Her "},
                new Artista {Nome = "Van Halen"},
                new Artista {Nome = "Various Artists"},
                new Artista {Nome = "Velvet Revolver"},
                new Artista {Nome = "Venus Hum"},
                new Artista {Nome = "Vicente Fernandez"},
                new Artista {Nome = "Vinícius De Moraes"},
                new Artista {Nome = "Weezer"},
                new Artista {Nome = "Weird Al"},
                new Artista {Nome = "Wendy Carlos"},
                new Artista {Nome = "Wilhelm Kempff"},
                new Artista {Nome = "Yano"},
                new Artista {Nome = "Yehudi Menuhin"},
                new Artista {Nome = "Yes"},
                new Artista {Nome = "Yo-Yo Ma"},
                new Artista {Nome = "Zeca Pagodinho"},
                new Artista {Nome = "אריק אינשטיין"}
            };

            context.Artists.AddRange(artists);

            return artists;
        }

        private static List<Genero> AddGenres(MusicStoreDb context)
        {
            var genres = new List<Genero>
            {
                new Genero {Nome = "Pop"},
                new Genero {Nome = "Rock"},
                new Genero {Nome = "Jazz"},
                new Genero {Nome = "Metal"},
                new Genero {Nome = "Electronic"},
                new Genero {Nome = "Blues"},
                new Genero {Nome = "Latin"},
                new Genero {Nome = "Rap"},
                new Genero {Nome = "Classical"},
                new Genero {Nome = "Alternative"},
                new Genero {Nome = "Country"},
                new Genero {Nome = "R&B"},
                new Genero {Nome = "Indie"},
                new Genero {Nome = "Punk"},
                new Genero {Nome = "World"}
            };

            context.Genres.AddRange(genres);

            return genres;
        }
    }
}