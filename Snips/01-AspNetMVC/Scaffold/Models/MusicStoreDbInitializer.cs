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
                    Title = "The Best Of The Men At Work",
                    Genre = genres.Single(g => g.Nome == "Pop"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Men At Work"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "...And Justice For All",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "עד גבול האור",
                    Genre = genres.Single(g => g.Nome == "World"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "אריק אינשטיין"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Black Light Syndrome",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Terry Bozzio, Tony Levin & Steve Stevens"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "10,000 Days",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Tool"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "11i",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Supreme Beings of Leisure"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "1960",
                    Genre = genres.Single(g => g.Nome == "Indie"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Soul-Junk"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "4x4=12 ",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "deadmau5"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "A Copland Celebration, Vol. I",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "London Symphony Orchestra"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "A Lively Mind",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Paul Oakenfold"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "A Matter of Life and Death",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "A Real Dead One",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "A Real Live One",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "A Rush of Blood to the Head",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Coldplay"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "A Soprano Inspired",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Britten Sinfonia, Ivor Bolton & Lesley Garrett"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "A Winter Symphony",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sarah Brightman"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Abbey Road",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Beatles"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Ace Of Spades",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Motörhead"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Achtung Baby",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "U2"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Acústico MTV",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Os Paralamas Do Sucesso"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Adams, John: The Chairman Dances",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Edo de Waart & San Francisco Symphony"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Adrenaline",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deftones"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Ænima",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Tool"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Afrociberdelia",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Chico Science & Nação Zumbi"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "After the Goldrush",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Neil Young"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Airdrawn Dagger",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sasha"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Album Title Goes Here",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "deadmau5"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Alcohol Fueled Brewtality Live! [Disc 1]",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Black Label Society"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Alcohol Fueled Brewtality Live! [Disc 2]",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Black Label Society"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Alive 2007",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Daft Punk"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "All I Ask of You",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sarah Brightman"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Amen (So Be It)",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Paddy Casey"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Animal Vehicle",
                    Genre = genres.Single(g => g.Nome == "Pop"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Axis of Awesome"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Ao Vivo [IMPORT]",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Zeca Pagodinho"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Apocalyptic Love",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Slash"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Appetite for Destruction",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Guns N' Roses"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Are You Experienced?",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Jimi Hendrix"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Arquivo II",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Os Paralamas Do Sucesso"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Arquivo Os Paralamas Do Sucesso",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Os Paralamas Do Sucesso"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "A-Sides",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Soundgarden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Audioslave",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Audioslave"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Automatic for the People",
                    Genre = genres.Single(g => g.Nome == "Alternative"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "R.E.M."),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Axé Bahia 2001",
                    Genre = genres.Single(g => g.Nome == "Pop"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Various Artists"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Babel",
                    Genre = genres.Single(g => g.Nome == "Alternative"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Mumford & Sons"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Bach: Goldberg Variations",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Wilhelm Kempff"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Bach: The Brandenburg Concertos",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Orchestra of The Age of Enlightenment"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Bach: The Cello Suites",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Yo-Yo Ma"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Bach: Toccata & Fugue in D Minor",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Ton Koopman"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Bad Motorfinger",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Soundgarden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Balls to the Wall",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Accept"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Banadeek Ta'ala",
                    Genre = genres.Single(g => g.Nome == "World"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Amr Diab"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Barbie Girl",
                    Genre = genres.Single(g => g.Nome == "Pop"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Aqua"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Bark at the Moon (Remastered)",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Ozzy Osbourne"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Bartok: Violin & Viola Concertos",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Yehudi Menuhin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Barulhinho Bom",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Marisa Monte"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "BBC Sessions [Disc 1] [Live]",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "BBC Sessions [Disc 2] [Live]",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Be Here Now",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Oasis"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Bedrock 11 Compiled & Mixed",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "John Digweed"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Berlioz: Symphonie Fantastique",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Michael Tilson Thomas"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Beyond Good And Evil",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Cult"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Big Bad Wolf ",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Armand Van Helden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Big Ones",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Aerosmith"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Black Album",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Black Sabbath Vol. 4 (Remaster)",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Black Sabbath"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Black Sabbath",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Black Sabbath"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Black",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Blackwater Park",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Opeth"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Blizzard of Ozz",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Ozzy Osbourne"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Blood",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "In This Moment"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Blue Moods",
                    Genre = genres.Single(g => g.Nome == "Jazz"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Incognito"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Blue",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Weezer"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Bongo Fury",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Frank Zappa & Captain Beefheart"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Boys & Girls",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Alabama Shakes"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Brave New World",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "B-Sides 1980-1990",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "U2"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Bunkka",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Paul Oakenfold"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "By The Way",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Red Hot Chili Peppers"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Cake: B-Sides and Rarities",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Cake"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Californication",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Red Hot Chili Peppers"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Carmina Burana",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Boston Symphony Orchestra & Seiji Ozawa"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Carried to Dust (Bonus Track Version)",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Calexico"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Carry On",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Chris Cornell"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Cássia Eller - Sem Limite [Disc 1]",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Cássia Eller"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Chemical Wedding",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Bruce Dickinson"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Chill: Brazil (Disc 1)",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Marcos Valle"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Chill: Brazil (Disc 2)",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Antônio Carlos Jobim"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Chocolate Starfish And The Hot Dog Flavored Water",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Limp Bizkit"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Chronicle, Vol. 1",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Creedence Clearwater Revival"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Chronicle, Vol. 2",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Creedence Clearwater Revival"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Ciao, Baby",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "TheStart"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Cidade Negra - Hits",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Cidade Negra"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Classic Munkle: Turbo Edition",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Munkle"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Classics: The Best of Sarah Brightman",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sarah Brightman"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Coda",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Come Away With Me",
                    Genre = genres.Single(g => g.Nome == "Jazz"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Norah Jones"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Come Taste The Band",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deep Purple"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Comfort Eagle",
                    Genre = genres.Single(g => g.Nome == "Alternative"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Cake"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Common Reaction",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Uh Huh Her "),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Compositores",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "O Terço"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Contraband",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Velvet Revolver"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Core",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Stone Temple Pilots"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Cornerstone",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Styx"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Cosmicolor",
                    Genre = genres.Single(g => g.Nome == "Rap"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "M-Flo"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Cross",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Justice"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Culture of Fear",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Thievery Corporation"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Da Lama Ao Caos",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Chico Science & Nação Zumbi"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Dakshina",
                    Genre = genres.Single(g => g.Nome == "World"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deva Premal"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Dark Side of the Moon",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Pink Floyd"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Death Magnetic",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Deep End of Down",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Above the Fold"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Deep Purple In Rock",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deep Purple"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Deixa Entrar",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Falamansa"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Deja Vu",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Crosby, Stills, Nash, and Young"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Di Korpu Ku Alma",
                    Genre = genres.Single(g => g.Nome == "World"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Lura"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Diary of a Madman (Remastered)",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Ozzy Osbourne"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Diary of a Madman",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Ozzy Osbourne"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Dirt",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Alice in Chains"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Diver Down",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Van Halen"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Djavan Ao Vivo - Vol. 02",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Djavan"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Djavan Ao Vivo - Vol. 1",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Djavan"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Drum'n'bass for Papa",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Plug"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Duluth",
                    Genre = genres.Single(g => g.Nome == "Country"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Trampled By Turtles"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Dummy",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Portishead"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Duos II",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Luciana Souza/Romero Lubambo"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Earl Scruggs and Friends",
                    Genre = genres.Single(g => g.Nome == "Country"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Earl Scruggs"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Eden",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sarah Brightman"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "El Camino",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Black Keys"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Elegant Gypsy",
                    Genre = genres.Single(g => g.Nome == "Jazz"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Al di Meola"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Elements Of Life",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Tiësto"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Elis Regina-Minha História",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Elis Regina"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Emergency On Planet Earth",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Jamiroquai"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Emotion",
                    Genre = genres.Single(g => g.Nome == "World"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Papa Wemba"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "English Renaissance",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The King's Singers"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Every Kind of Light",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Posies"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Faceless",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Godsmack"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Facelift",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Alice in Chains"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Fair Warning",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Van Halen"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Fear of a Black Planet",
                    Genre = genres.Single(g => g.Nome == "Rap"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Public Enemy"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Fear Of The Dark",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Feels Like Home",
                    Genre = genres.Single(g => g.Nome == "Jazz"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Norah Jones"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Fireball",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deep Purple"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Fly",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sarah Brightman"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "For Those About To Rock We Salute You",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "AC/DC"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Four",
                    Genre = genres.Single(g => g.Nome == "Blues"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Blues Traveler"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Frank",
                    Genre = genres.Single(g => g.Nome == "Pop"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Amy Winehouse"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Further Down the Spiral",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Nine Inch Nails"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Garage Inc. (Disc 1)",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Garage Inc. (Disc 2)",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Garbage",
                    Genre = genres.Single(g => g.Nome == "Alternative"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Garbage"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Good News For People Who Love Bad News",
                    Genre = genres.Single(g => g.Nome == "Indie"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Modest Mouse"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Gordon",
                    Genre = genres.Single(g => g.Nome == "Alternative"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Barenaked Ladies"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Górecki: Symphony No. 3",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Adrian Leaper & Doreen de Feis"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Greatest Hits I",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Queen"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Greatest Hits II",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Queen"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Greatest Hits",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Duck Sauce"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Greatest Hits",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Lenny Kravitz"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Greatest Hits",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Lenny Kravitz"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Greatest Kiss",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Kiss"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Greetings from Michigan",
                    Genre = genres.Single(g => g.Nome == "Indie"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sufjan Stevens"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Group Therapy",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Above & Beyond"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Handel: The Messiah (Highlights)",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Scholars Baroque Ensemble"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Haydn: Symphonies 99 - 104",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Royal Philharmonic Orchestra"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Heart of the Night",
                    Genre = genres.Single(g => g.Nome == "Jazz"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Spyro Gyra"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Heart On",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Eagles of Death Metal"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Holy Diver",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Dio"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Homework",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Daft Punk"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Hot Rocks, 1964-1971 (Disc 1)",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Rolling Stones"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Houses Of The Holy",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "How To Dismantle An Atomic Bomb",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "U2"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Human",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Projected"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Hunky Dory",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "David Bowie"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Hymns",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Projected"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Hysteria",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Def Leppard"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "In Absentia",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Porcupine Tree"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "In Between",
                    Genre = genres.Single(g => g.Nome == "Pop"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Paul Van Dyk"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "In Rainbows",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Radiohead"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "In Step",
                    Genre = genres.Single(g => g.Nome == "Blues"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Stevie Ray Vaughan & Double Trouble"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "In the court of the Crimson King",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "King Crimson"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "In Through The Out Door",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "In Your Honor [Disc 1]",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Foo Fighters"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "In Your Honor [Disc 2]",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Foo Fighters"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Indestructible",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Rancid"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Infinity",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Journey"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Into The Light",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "David Coverdale"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Introspective",
                    Genre = genres.Single(g => g.Nome == "Pop"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Pet Shop Boys"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Iron Maiden",
                    Genre = genres.Single(g => g.Nome == "Blues"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "ISAM",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Amon Tobin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "IV",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Jagged Little Pill",
                    Genre = genres.Single(g => g.Nome == "Alternative"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Alanis Morissette"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Jagged Little Pill",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Alanis Morissette"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Jorge Ben Jor 25 Anos",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Jorge Ben"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Jota Quest-1995",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Jota Quest"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Kick",
                    Genre = genres.Single(g => g.Nome == "Alternative"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "INXS"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Kill 'Em All",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Kind of Blue",
                    Genre = genres.Single(g => g.Nome == "Jazz"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Miles Davis"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "King For A Day Fool For A Lifetime",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Faith No More"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Kiss",
                    Genre = genres.Single(g => g.Nome == "Pop"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Carly Rae Jepsen"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Last Call",
                    Genre = genres.Single(g => g.Nome == "Country"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Cayouche"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Le Freak",
                    Genre = genres.Single(g => g.Nome == "R&B"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Chic"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Le Tigre",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Le Tigre"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Led Zeppelin I",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Led Zeppelin II",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Led Zeppelin III",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Let There Be Rock",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "AC/DC"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Little Earthquakes",
                    Genre = genres.Single(g => g.Nome == "Alternative"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Tori Amos"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Live [Disc 1]",
                    Genre = genres.Single(g => g.Nome == "Blues"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Black Crowes"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Live [Disc 2]",
                    Genre = genres.Single(g => g.Nome == "Blues"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Black Crowes"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Live After Death",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Live At Donington 1992 (Disc 1)",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Live At Donington 1992 (Disc 2)",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Live on Earth",
                    Genre = genres.Single(g => g.Nome == "Jazz"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Cat Empire"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Live On Two Legs [Live]",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Pearl Jam"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Living After Midnight",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Judas Priest"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Living",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Paddy Casey"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Load",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Love Changes Everything",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sarah Brightman"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "MacArthur Park Suite",
                    Genre = genres.Single(g => g.Nome == "R&B"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Donna Summer"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Machine Head",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deep Purple"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Magical Mystery Tour",
                    Genre = genres.Single(g => g.Nome == "Pop"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Beatles"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Mais Do Mesmo",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Legião Urbana"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Maquinarama",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Skank"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Marasim",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Jagjit Singh"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Mascagni: Cavalleria Rusticana",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "James Levine"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Master of Puppets",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Mechanics & Mathematics",
                    Genre = genres.Single(g => g.Nome == "Pop"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Venus Hum"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Mental Jewelry",
                    Genre = genres.Single(g => g.Nome == "Alternative"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Live"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Metallics",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "meteora",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Linkin Park"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Meus Momentos",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Gonzaguinha"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Mezmerize",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "System Of A Down"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Mezzanine",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Massive Attack"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Miles Ahead",
                    Genre = genres.Single(g => g.Nome == "Jazz"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Miles Davis"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Milton Nascimento Ao Vivo",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Milton Nascimento"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Minas",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Milton Nascimento"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Minha Historia",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Chico Buarque"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Misplaced Childhood",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Marillion"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "MK III The Final Concerts [Disc 1]",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deep Purple"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Morning Dance",
                    Genre = genres.Single(g => g.Nome == "Jazz"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Spyro Gyra"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Motley Crue Greatest Hits",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Mötley Crüe"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Moving Pictures",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Rush"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Mozart: Chamber Music",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Nash Ensemble"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Mozart: Symphonies Nos. 40 & 41",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Berliner Philharmoniker"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Murder Ballads",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Nick Cave and the Bad Seeds"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Music For The Jilted Generation",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Prodigy"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "My Generation - The Very Best Of The Who",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Who"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "My Name is Skrillex",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Skrillex"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Na Pista",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Cláudio Zoli"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Nevermind",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Nirvana"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "New Adventures In Hi-Fi",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "R.E.M."),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "New Divide",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Linkin Park"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "New York Dolls",
                    Genre = genres.Single(g => g.Nome == "Punk"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "New York Dolls"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "News Of The World",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Queen"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Nielsen: The Six Symphonies",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Göteborgs Symfoniker & Neeme Järvi"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Night At The Opera",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Queen"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Night Castle",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Trans-Siberian Orchestra"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Nkolo",
                    Genre = genres.Single(g => g.Nome == "World"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Lokua Kanza"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "No More Tears (Remastered)",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Ozzy Osbourne"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "No Prayer For The Dying",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "No Security",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Rolling Stones"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "O Brother, Where Art Thou?",
                    Genre = genres.Single(g => g.Nome == "Country"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Alison Krauss"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "O Samba Poconé",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Skank"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "O(+>",
                    Genre = genres.Single(g => g.Nome == "R&B"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Prince"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Oceania",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Smashing Pumpkins"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Off the Deep End",
                    Genre = genres.Single(g => g.Nome == "Pop"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Weird Al"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "OK Computer",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Radiohead"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Olodum",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Olodum"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "One Love",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "David Guetta"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Operation: Mindcrime",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Queensrÿche"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Opiate",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Tool"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Outbreak",
                    Genre = genres.Single(g => g.Nome == "Jazz"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Dennis Chambers"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Pachelbel: Canon & Gigue",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "English Concert & Trevor Pinnock"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Paid in Full",
                    Genre = genres.Single(g => g.Nome == "Rap"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Eric B. and Rakim"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Para Siempre",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Vicente Fernandez"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Pause",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Four Tet"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Peace Sells... but Who's Buying",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Megadeth"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Physical Graffiti [Disc 1]",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Physical Graffiti [Disc 2]",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Physical Graffiti",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Piece Of Mind",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Pinkerton",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Weezer"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Plays Metallica By Four Cellos",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Apocalyptica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Pop",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "U2"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Powerslave",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Prenda Minha",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Caetano Veloso"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Presence",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Pretty Hate Machine",
                    Genre = genres.Single(g => g.Nome == "Alternative"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Nine Inch Nails"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Prisoner",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Jezabels"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Privateering",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Mark Knopfler"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Prokofiev: Romeo & Juliet",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Michael Tilson Thomas"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Prokofiev: Symphony No.1",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sergei Prokofiev & Yuri Temirkanov"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "PSY's Best 6th Part 1",
                    Genre = genres.Single(g => g.Nome == "Pop"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "PSY"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Purcell: The Fairy Queen",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "London Classical Players"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Purpendicular",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deep Purple"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Purple",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Stone Temple Pilots"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Quanta Gente Veio Ver (Live)",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Gilberto Gil"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Quanta Gente Veio ver--Bônus De Carnaval",
                    Genre = genres.Single(g => g.Nome == "Jazz"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Gilberto Gil"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Quiet Songs",
                    Genre = genres.Single(g => g.Nome == "Jazz"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Aisha Duo"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Raices",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Los Tigres del Norte"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Raising Hell",
                    Genre = genres.Single(g => g.Nome == "Rap"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Run DMC"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Raoul and the Kings of Spain ",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Tears For Fears"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Rattle And Hum",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "U2"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Raul Seixas",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Raul Seixas"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Recovery [Explicit]",
                    Genre = genres.Single(g => g.Nome == "Rap"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Eminem"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Reign In Blood",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Slayer"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Relayed",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Yes"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "ReLoad",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Respighi:Pines of Rome",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Eugene Ormandy"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Restless and Wild",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Accept"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Retrospective I (1974-1980)",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Rush"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Revelations",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Audioslave"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Revolver",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Beatles"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Ride the Lighting ",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Ride The Lightning",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Ring My Bell",
                    Genre = genres.Single(g => g.Nome == "R&B"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Anita Ward"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Riot Act",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Pearl Jam"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Rise of the Phoenix",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Before the Dawn"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Rock In Rio [CD1]",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Rock In Rio [CD2]",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Rock In Rio [CD2]",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Roda De Funk",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Funk Como Le Gusta"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Room for Squares",
                    Genre = genres.Single(g => g.Nome == "Pop"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "John Mayer"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Root Down",
                    Genre = genres.Single(g => g.Nome == "Jazz"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Jimmy Smith"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Rounds",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Four Tet"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Rubber Factory",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Black Keys"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Rust in Peace",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Megadeth"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Sambas De Enredo 2001",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Various Artists"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Santana - As Years Go By",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Santana"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Santana Live",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Santana"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Saturday Night Fever",
                    Genre = genres.Single(g => g.Nome == "R&B"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Bee Gees"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Scary Monsters and Nice Sprites",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Skrillex"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Scheherazade",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Chicago Symphony Orchestra & Fritz Reiner"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "SCRIABIN: Vers la flamme",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Christopher O'Riley"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Second Coming",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Stone Roses"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Serie Sem Limite (Disc 1)",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Tim Maia"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Serie Sem Limite (Disc 2)",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Tim Maia"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Serious About Men",
                    Genre = genres.Single(g => g.Nome == "Rap"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Rubberbandits"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Seventh Son of a Seventh Son",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Short Bus",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Filter"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Sibelius: Finlandia",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Berliner Philharmoniker"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Singles Collection",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "David Bowie"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Six Degrees of Inner Turbulence",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Dream Theater"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Slave To The Empire",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "T&N"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Slaves And Masters",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deep Purple"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Slouching Towards Bethlehem",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Robert James"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Smash",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Offspring"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Something Special",
                    Genre = genres.Single(g => g.Nome == "Country"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Dolly Parton"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Somewhere in Time",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Song(s) You Know By Heart",
                    Genre = genres.Single(g => g.Nome == "Country"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Jimmy Buffett"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Sound of Music",
                    Genre = genres.Single(g => g.Nome == "Punk"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Adicts"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "South American Getaway",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The 12 Cellists of The Berlin Philharmonic"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Sozinho Remix Ao Vivo",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Caetano Veloso"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Speak of the Devil",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Ozzy Osbourne"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Spiritual State",
                    Genre = genres.Single(g => g.Nome == "Rap"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Nujabes"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "St. Anger",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Metallica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Still Life",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Opeth"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Stop Making Sense",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Talking Heads"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Stormbringer",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deep Purple"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Stranger than Fiction",
                    Genre = genres.Single(g => g.Nome == "Punk"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Bad Religion"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Strauss: Waltzes",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Eugene Ormandy"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Supermodified",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Amon Tobin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Supernatural",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Santana"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Surfing with the Alien (Remastered)",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Joe Satriani"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Switched-On Bach",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Wendy Carlos"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Symphony",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sarah Brightman"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Szymanowski: Piano Works, Vol. 1",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Martin Roscoe"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Tchaikovsky: The Nutcracker",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "London Symphony Orchestra"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Ted Nugent",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Ted Nugent"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Teflon Don",
                    Genre = genres.Single(g => g.Nome == "Rap"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Rick Ross"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Tell Another Joke at the Ol' Choppin' Block",
                    Genre = genres.Single(g => g.Nome == "Indie"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Danielson Famile"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Temple of the Dog",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Temple of the Dog"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Ten",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Pearl Jam"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Texas Flood",
                    Genre = genres.Single(g => g.Nome == "Blues"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Stevie Ray Vaughan"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Battle Rages On",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deep Purple"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Beast Live",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Paul D'Ianno"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Best Of 1980-1990",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "U2"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Best of 1990–2000",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sarah Brightman"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Best of Beethoven",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Nicolaus Esterhazy Sinfonia"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Best Of Billy Cobham",
                    Genre = genres.Single(g => g.Nome == "Jazz"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Billy Cobham"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Best of Ed Motta",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Ed Motta"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Best Of Van Halen, Vol. I",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Van Halen"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Bridge",
                    Genre = genres.Single(g => g.Nome == "R&B"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Melanie Fiona"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Cage",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Tygers of Pan Tang"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Chicago Transit Authority",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Chicago "),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Chronic",
                    Genre = genres.Single(g => g.Nome == "Rap"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Dr. Dre"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Colour And The Shape",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Foo Fighters"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Crane Wife",
                    Genre = genres.Single(g => g.Nome == "Alternative"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Decemberists"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Cream Of Clapton",
                    Genre = genres.Single(g => g.Nome == "Blues"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Eric Clapton"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Cure",
                    Genre = genres.Single(g => g.Nome == "Pop"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Cure"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Dark Side Of The Moon",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Pink Floyd"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Divine Conspiracy",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Epica"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Doors",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Doors"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Dream of the Blue Turtles",
                    Genre = genres.Single(g => g.Nome == "Pop"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sting"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Essential Miles Davis [Disc 1]",
                    Genre = genres.Single(g => g.Nome == "Jazz"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Miles Davis"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Essential Miles Davis [Disc 2]",
                    Genre = genres.Single(g => g.Nome == "Jazz"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Miles Davis"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Final Concerts (Disc 2)",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deep Purple"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Final Frontier",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Head and the Heart",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Head and the Heart"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Joshua Tree",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "U2"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Last Night of the Proms",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "BBC Concert Orchestra"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Lumineers",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Lumineers"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Number of The Beast",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Number of The Beast",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Police Greatest Hits",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Police"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Song Remains The Same (Disc 1)",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Song Remains The Same (Disc 2)",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Led Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Southern Harmony and Musical Companion",
                    Genre = genres.Single(g => g.Nome == "Blues"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Black Crowes"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Spade",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Butch Walker & The Black Widows"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Stone Roses",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Stone Roses"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Suburbs",
                    Genre = genres.Single(g => g.Nome == "Indie"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Arcade Fire"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Three Tenors Disc1/Disc2",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Carreras, Pavarotti, Domingo"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Trees They Grow So High",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sarah Brightman"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The Wall",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Pink Floyd"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "The X Factor",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Them Crooked Vultures",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Them Crooked Vultures"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "This Is Happening",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "LCD Soundsystem"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Thunder, Lightning, Strike",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Go! Team"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Time to Say Goodbye",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sarah Brightman"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Time, Love & Tenderness",
                    Genre = genres.Single(g => g.Nome == "Pop"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Michael Bolton"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Tomorrow Starts Today",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Mobile"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Tribute",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Ozzy Osbourne"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Tuesday Night Music Club",
                    Genre = genres.Single(g => g.Nome == "Alternative"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sheryl Crow"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Umoja",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "BLØF"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Under the Pink",
                    Genre = genres.Single(g => g.Nome == "Alternative"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Tori Amos"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Undertow",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Tool"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Un-Led-Ed",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Dread Zeppelin"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Unplugged [Live]",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Kiss"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Unplugged",
                    Genre = genres.Single(g => g.Nome == "Blues"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Eric Clapton"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Unplugged",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Eric Clapton"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Untrue",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Burial"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Use Your Illusion I",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Guns N' Roses"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Use Your Illusion II",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Guns N' Roses"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Use Your Illusion II",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Guns N' Roses"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Van Halen III",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Van Halen"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Van Halen",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Van Halen"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Version 2.0",
                    Genre = genres.Single(g => g.Nome == "Alternative"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Garbage"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Vinicius De Moraes",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Vinícius De Moraes"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Virtual XI",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Iron Maiden"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Voodoo Lounge",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Rolling Stones"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Vozes do MPB",
                    Genre = genres.Single(g => g.Nome == "Latin"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Various Artists"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Vs.",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Pearl Jam"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Wagner: Favourite Overtures",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sir Georg Solti & Wiener Philharmoniker"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Walking Into Clarksdale",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Page & Plant"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Wapi Yo",
                    Genre = genres.Single(g => g.Nome == "World"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Lokua Kanza"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "War",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "U2"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Warner 25 Anos",
                    Genre = genres.Single(g => g.Nome == "Jazz"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Antônio Carlos Jobim"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Wasteland R&Btheque",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Raunchy"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Watermark",
                    Genre = genres.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Enya"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "We Were Exploding Anyway",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "65daysofstatic"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Weill: The Seven Deadly Sins",
                    Genre = genres.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Orchestre de l'Opéra de Lyon"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "White Pony",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Deftones"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Who's Next",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Who"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Wish You Were Here",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Pink Floyd"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "With Oden on Our Side",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Amon Amarth"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Worlds",
                    Genre = genres.Single(g => g.Nome == "Jazz"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Aaron Goldberg"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Worship Music",
                    Genre = genres.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Anthrax"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "X&Y",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Coldplay"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Xinti",
                    Genre = genres.Single(g => g.Nome == "World"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Sara Tavares"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Yano",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "Yano"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Yesterday Once More Disc 1/Disc 2",
                    Genre = genres.Single(g => g.Nome == "Pop"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "The Carpenters"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Zooropa",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = artists.Single(a => a.Nome == "U2"),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "Zoso",
                    Genre = genres.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
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