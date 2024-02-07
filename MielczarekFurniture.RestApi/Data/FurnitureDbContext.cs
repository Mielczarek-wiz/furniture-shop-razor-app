using Microsoft.EntityFrameworkCore;
using MielczarekFurniture.RestApi.Entities;

namespace MielczarekFurniture.RestApi.Data
{
    public class FurnitureDbContext : DbContext
    {
		public FurnitureDbContext(DbContextOptions<FurnitureDbContext> options) : base(options)
		{

		}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Producer>().HasData(new Producer
			{
				Id = 1,
				Name = "Black Red White",
				Star = Core.Enums.Stars.Unknown

			});
			modelBuilder.Entity<Producer>().HasData(new Producer
			{
				Id = 2,
				Name = "Bodzio",
				Star = Core.Enums.Stars.Medium

			});
			modelBuilder.Entity<Producer>().HasData(new Producer
			{
				Id = 3,
				Name = "Agata Meble",
				Star = Core.Enums.Stars.Okay

			});
			modelBuilder.Entity<Producer>().HasData(new Producer
			{
				Id = 4,
				Name = "Kler",
				Star = Core.Enums.Stars.Good

			});
			modelBuilder.Entity<Producer>().HasData(new Producer
			{
				Id = 5,
				Name = "Ikea",
				Star = Core.Enums.Stars.Excelent

			});
			modelBuilder.Entity<Producer>().HasData(new Producer
			{
				Id = 6,
				Name = "Komfort",
				Star = Core.Enums.Stars.Unknown

			});
			modelBuilder.Entity<Producer>().HasData(new Producer
			{
				Id = 7,
				Name = "Abra",
				Star = Core.Enums.Stars.Good

			});
			modelBuilder.Entity<Producer>().HasData(new Producer
			{
				Id = 8,
				Name = "Euforma",
				Star = Core.Enums.Stars.Okay

			});
			modelBuilder.Entity<Producer>().HasData(new Producer
			{
				Id = 9,
				Name = "Świat Mebli",
				Star = Core.Enums.Stars.Bad

			});


			//Products

			//BRW
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 1,
				Name = "Narożnik Neto",
				Description = "Minimalistyczny, prosty narożnik Neto jest idealną propozycją do kawalerki lub pokoju młodzieżowego, gdzie każdy metr powierzchni jest na wagę złota.",
				Price = 1679M,
				ImageURL = "/Images/naroznik-neto.png",
				ProducerId = 1,

			});
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 2,
				Name = "Narożnik Risten",
				Description = "Narożnik z funkcją spania Risten- piękny i wygodny mebel.",
				Price = 3149M,
				ImageURL = "/Images/naroznik-risten.png",
				ProducerId = 1,

			});
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 3,
				Name = "Narożnik Feliz",
				Price = 2559M,
				Description = "Nowoczesny, lekki wizualnie i stylowy - taki właśnie jest narożnik Feliz, który dopełni wystrój Twojego salonu.",
				ImageURL = "/Images/naroznik-feliz.png",
				ProducerId = 1,

			});

			//Bodzio
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 4,
				Name = "Rozkładany stół kuchenny 116 cm (biały)",
				Description = "Rozkładany stół kuchenny o długości 116 cm, będzie idealnym rozwiązaniem w Twoim domu.",
				Price = 469M,
				ImageURL = "/Images/rozkladany-stol-kuchenny-bialy.png",
				ProducerId = 2,

			});
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 5,
				Name = "Stół okrągły rozkładany (dąb Soma ciemny/biały)",
				Description = "Okrągły stół o średnicy 110 cm, będzie idealnym rozwiązaniem w Twoim domu.",
				Price = 715M,
				ImageURL = "/Images/rozkladany-okragly-stol-dab-bialy.png",
				ProducerId = 2,

			});
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 6,
				Name = "Stół okrągły szklany GOLDIMOS",
				Description = "Nowoczesny i bardzo oryginalny stół okrągły Goldimos z blatem wykonanym ze szkła hartowanego i stelażem w kolorze złotym. Idealnie będzie pasował do kuchni oraz jadalni.",
				Price = 900M,
				ImageURL = "/Images/stol-okragly-szklany-goldimos.png",
				ProducerId = 2,

			});

			//Agata Meble
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 7,
				Name = "Regał SCALAR biały",
				Description = "Nowoczesny regał możesz postawić w salonie, jadalni, domowym biurze czy pokoju młodzieżowym.",
				Price = 399M,
				ImageURL = "/Images/regal-scalar-bialy.png",
				ProducerId = 3,
			});
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 8,
				Name = "Regał UNIWERSUM dąb artisan/czarny",
				Description = "Regał świetnie sprawdzi się jako forma domowej biblioteczki lub miejsce na uporządkowanie dokumentów w domowym biurze. Lekka konstrukcja pozwala na wiele możliwości wykorzystania bryły.",
				Price = 259M,
				ImageURL = "/Images/regal-universum-dab-artisan-czarny.png",
				ProducerId = 3,
			});
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 9,
				Name = "Regał NORTON",
				Description = "Regał z szufladami Norton charakteryzuje się prostą minimalistyczną formą, która sprawia, że mebel pasuje do nowoczesnych wnętrz.",
				Price = 669M,
				ImageURL = "/Images/regal-norton.png",
				ProducerId = 3,

			});

			//Kler
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 10,
				Name = "Biurko Kartell Max",
				Description = "Biurko Max stworzone zostało z myślą o nauce i pracy, jest bowiem idealne do pokoju młodzieżowego, domowego gabinetu czy do biura.",
				Price = 5790M,
				ImageURL = "/Images/biurko-kartell-max.png",
				ProducerId = 4,

			});
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 11,
				Name = "Biurko Trebord Soft",
				Description = "Biurko Soft to kwintesencja skandynawskiej prostoty i minimalizmu.",
				Price = 4025M,
				ImageURL = "/Images/biurko-trebord-soft.png",
				ProducerId = 4,

			});
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 12,
				Name = "Biurko Bontempi Zac",
				Description = "Zac to eleganckie i nowoczesne biurko. Wspaniały mebel o absolutnym designie, który pięknie komponuje się z każdym otoczeniem.",
				Price = 9255M,
				ImageURL = "/Images/biurko-bontempi-zac.png",
				ProducerId = 4,

			});

			//Ikea
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 13,
				Name = "Łóżko Malm",
				Description = "roste wzornictwo, równie piękne z każdej strony - łózko może stać w pokoju wolnostojąco lub z wezgłowiem przy ścianie.",
				Price = 999M,
				ImageURL = "/Images/lozko-malm.png",
				ProducerId = 5,

			});
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 14,
				Name = "Łóżko Slattum",
				Description = "Tapicerowane miękką tkaniną, która wnosi przytulną atmosferę do sypialni.",
				Price = 699M,
				ImageURL = "/Images/lozko-slattum.png",
				ProducerId = 5,

			});
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 15,
				Name = "Łóżko Tarva",
				Description = "Rama łóżka TARVA to nowoczesny przykład skandynawskiej tradycji meblarskiej - proste wzornictwo i surowe drewno.",
				Price = 919M,
				ImageURL = "/Images/lozko-tarva.png",
				ProducerId = 5,

			});

			//Komfort
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 16,
				Name = "Witryna Wysoka Vigo",
				Description = "Aby podkreślić nowoczesny charakter wnętrza wybierz meble utrzymane w stonowanej kolorystyce i o prostej formie.",
				Price = 959M,
				ImageURL = "/Images/witryna-wysoka-vigo.png",
				ProducerId = 6,

			});
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 17,
				Name = "Witryna Wysoka Davin",
				Description = "Jest utrzymana w nowoczesnym stylu. Łączy w sobie dwa kolory – biały i naturalnego drewna. Należy do systemu meblowego Davin.",
				Price = 799M,
				ImageURL = "/Images/witryna-wysoka-davin.png",
				ProducerId = 6,

			});
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 18,
				Name = "Witryna Wysoka Kalmar",
				Description = "WITRYNA WYSOKA KALMAR to wąska propozycja systemu meblowego Kalmar, która łączy wysoki walor estetyczny z funkcjonalnością.",
				Price = 899M,
				ImageURL = "/Images/witryna-wysoka-kalmar.png",
				ProducerId = 6,

			});

			//Abra
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 19,
				Name = "Wersalka Zenit Primo",
				Description = "Stylowe i proste w formie rozkładane sofy i wersalki to idealne rozwiązanie do małego mieszkania.",
				Price = 1349M,
				ImageURL = "/Images/wersalka-zenit-primo.png",
				ProducerId = 7,

			});
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 20,
				Name = "Kanapa Tango Zetta",
				Description = "Kanapa Tango w kolorze brązowym to praktyczna i funkcjonalna kanapa zaprojektowana w nowoczesnym stylu.",
				Price = 1599M,
				ImageURL = "/Images/kanapa-tango-zetta.png",
				ProducerId = 7,

			});
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 21,
				Name = "Sofa Sally Monolith",
				Description = "Stylowe i proste w formie rozkładane sofy i wersalki to idealne rozwiązanie do małego mieszkania, czy też w salonie, sypialni.",
				Price = 2209M,
				ImageURL = "/Images/sofa-sally-monolith.png",
				ProducerId = 7,

			});

			//Euforma
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 22,
				Name = "Komoda xoxo Kiss",
				Description = "XOXO to rodzina szafek Hug&Kiss. Kolekcja powstała z miłości do prostoty i otwartości na personalizację użytkowania.",
				Price = 7990M,
				ImageURL = "/Images/komoda-xoxo-kiss.png",
				ProducerId = 8,

			});
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 23,
				Name = "Komoda xoxo Hug",
				Description = "XOXO to rodzina szafek Hug&Kiss. Kolekcja powstała z miłości do prostoty i otwartości na personalizację użytkowania. W zależności od sposobu wykończenia mebla, nabiera on zupełnie nowego charakteru.",
				Price = 7990M,
				ImageURL = "/Images/komoda-xoxo-hug.png",
				ProducerId = 8,

			});
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 24,
				Name = "Komoda Ren",
				Description = "Komoda Ren to niezwykle reprezentacyjny, elegancki i ekskluzywny mebel. Piękna i praktyczna komoda pomieści wszystkie niezbędne przedmioty.",
				Price = 6207M,
				ImageURL = "/Images/komoda-ren.png",
				ProducerId = 8,
			});

			//Świat Mebli
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 25,
				Name = "Krzesło Kashmir",
				Description = "Krzesła z kolekcji KASHMIR to idealny wybór do nowoczesnej jadalni.",
				Price = 369M,
				ImageURL = "/Images/krzeslo-kashmir.png",
				ProducerId = 9,

			});
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 26,
				Name = "Krzesło Myrtos",
				Description = "Prosta i minimalistyczna, konstrukcja krzesła z kolekcji MYRTOS, sprawdzi się w nowocześnie urządzonej jadalni lub pokoju dziennym.",
				Price = 399M,
				ImageURL = "/Images/krzeslo-myrtos.png",
				ProducerId = 9,

			});
			modelBuilder.Entity<Product>().HasData(new
			{
				Id = 27,
				Name = "Krzesło Metal Yadgir",
				Description = "Krzesło z kolekcji YADGIR łączy w sobie nowoczesność i funkcjonalność.",
				Price = 439M,
				ImageURL = "/Images/krzeslo-metal-yadgir.png",
				ProducerId = 9,

			});
		}
        public DbSet<Producer> producers { get; set; }
		public DbSet<Product> products { get; set; }
	}
}
