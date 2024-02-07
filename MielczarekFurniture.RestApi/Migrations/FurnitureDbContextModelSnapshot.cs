﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MielczarekFurniture.RestApi.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MielczarekFurniture.RestApi.Migrations
{
    [DbContext(typeof(FurnitureDbContext))]
    partial class FurnitureDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MielczarekFurniture.RestApi.Entities.Producer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Star")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("producers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Black Red White",
                            Star = 0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bodzio",
                            Star = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Agata Meble",
                            Star = 3
                        },
                        new
                        {
                            Id = 4,
                            Name = "Kler",
                            Star = 4
                        },
                        new
                        {
                            Id = 5,
                            Name = "Ikea",
                            Star = 5
                        },
                        new
                        {
                            Id = 6,
                            Name = "Komfort",
                            Star = 0
                        },
                        new
                        {
                            Id = 7,
                            Name = "Abra",
                            Star = 4
                        },
                        new
                        {
                            Id = 8,
                            Name = "Euforma",
                            Star = 3
                        },
                        new
                        {
                            Id = 9,
                            Name = "Świat Mebli",
                            Star = 1
                        });
                });

            modelBuilder.Entity("MielczarekFurniture.RestApi.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("ProducerId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProducerId");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Minimalistyczny, prosty narożnik Neto jest idealną propozycją do kawalerki lub pokoju młodzieżowego, gdzie każdy metr powierzchni jest na wagę złota.",
                            ImageURL = "/Images/naroznik-neto.png",
                            Name = "Narożnik Neto",
                            Price = 1679m,
                            ProducerId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Narożnik z funkcją spania Risten- piękny i wygodny mebel.",
                            ImageURL = "/Images/naroznik-risten.png",
                            Name = "Narożnik Risten",
                            Price = 3149m,
                            ProducerId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "Nowoczesny, lekki wizualnie i stylowy - taki właśnie jest narożnik Feliz, który dopełni wystrój Twojego salonu.",
                            ImageURL = "/Images/naroznik-feliz.png",
                            Name = "Narożnik Feliz",
                            Price = 2559m,
                            ProducerId = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "Rozkładany stół kuchenny o długości 116 cm, będzie idealnym rozwiązaniem w Twoim domu.",
                            ImageURL = "/Images/rozkladany-stol-kuchenny-bialy.png",
                            Name = "Rozkładany stół kuchenny 116 cm (biały)",
                            Price = 469m,
                            ProducerId = 2
                        },
                        new
                        {
                            Id = 5,
                            Description = "Okrągły stół o średnicy 110 cm, będzie idealnym rozwiązaniem w Twoim domu.",
                            ImageURL = "/Images/rozkladany-okragly-stol-dab-bialy.png",
                            Name = "Stół okrągły rozkładany (dąb Soma ciemny/biały)",
                            Price = 715m,
                            ProducerId = 2
                        },
                        new
                        {
                            Id = 6,
                            Description = "Nowoczesny i bardzo oryginalny stół okrągły Goldimos z blatem wykonanym ze szkła hartowanego i stelażem w kolorze złotym. Idealnie będzie pasował do kuchni oraz jadalni.",
                            ImageURL = "/Images/stol-okragly-szklany-goldimos.png",
                            Name = "Stół okrągły szklany GOLDIMOS",
                            Price = 900m,
                            ProducerId = 2
                        },
                        new
                        {
                            Id = 7,
                            Description = "Nowoczesny regał możesz postawić w salonie, jadalni, domowym biurze czy pokoju młodzieżowym.",
                            ImageURL = "/Images/regal-scalar-bialy.png",
                            Name = "Regał SCALAR biały",
                            Price = 399m,
                            ProducerId = 3
                        },
                        new
                        {
                            Id = 8,
                            Description = "Regał świetnie sprawdzi się jako forma domowej biblioteczki lub miejsce na uporządkowanie dokumentów w domowym biurze. Lekka konstrukcja pozwala na wiele możliwości wykorzystania bryły.",
                            ImageURL = "/Images/regal-universum-dab-artisan-czarny.png",
                            Name = "Regał UNIWERSUM dąb artisan/czarny",
                            Price = 259m,
                            ProducerId = 3
                        },
                        new
                        {
                            Id = 9,
                            Description = "Regał z szufladami Norton charakteryzuje się prostą minimalistyczną formą, która sprawia, że mebel pasuje do nowoczesnych wnętrz.",
                            ImageURL = "/Images/regal-norton.png",
                            Name = "Regał NORTON",
                            Price = 669m,
                            ProducerId = 3
                        },
                        new
                        {
                            Id = 10,
                            Description = "Biurko Max stworzone zostało z myślą o nauce i pracy, jest bowiem idealne do pokoju młodzieżowego, domowego gabinetu czy do biura.",
                            ImageURL = "/Images/biurko-kartell-max.png",
                            Name = "Biurko Kartell Max",
                            Price = 5790m,
                            ProducerId = 4
                        },
                        new
                        {
                            Id = 11,
                            Description = "Biurko Soft to kwintesencja skandynawskiej prostoty i minimalizmu.",
                            ImageURL = "/Images/biurko-trebord-soft.png",
                            Name = "Biurko Trebord Soft",
                            Price = 4025m,
                            ProducerId = 4
                        },
                        new
                        {
                            Id = 12,
                            Description = "Zac to eleganckie i nowoczesne biurko. Wspaniały mebel o absolutnym designie, który pięknie komponuje się z każdym otoczeniem.",
                            ImageURL = "/Images/biurko-bontempi-zac.png",
                            Name = "Biurko Bontempi Zac",
                            Price = 9255m,
                            ProducerId = 4
                        },
                        new
                        {
                            Id = 13,
                            Description = "roste wzornictwo, równie piękne z każdej strony - łózko może stać w pokoju wolnostojąco lub z wezgłowiem przy ścianie.",
                            ImageURL = "/Images/lozko-malm.png",
                            Name = "Łóżko Malm",
                            Price = 999m,
                            ProducerId = 5
                        },
                        new
                        {
                            Id = 14,
                            Description = "Tapicerowane miękką tkaniną, która wnosi przytulną atmosferę do sypialni.",
                            ImageURL = "/Images/lozko-slattum.png",
                            Name = "Łóżko Slattum",
                            Price = 699m,
                            ProducerId = 5
                        },
                        new
                        {
                            Id = 15,
                            Description = "Rama łóżka TARVA to nowoczesny przykład skandynawskiej tradycji meblarskiej - proste wzornictwo i surowe drewno.",
                            ImageURL = "/Images/lozko-tarva.png",
                            Name = "Łóżko Tarva",
                            Price = 919m,
                            ProducerId = 5
                        },
                        new
                        {
                            Id = 16,
                            Description = "Aby podkreślić nowoczesny charakter wnętrza wybierz meble utrzymane w stonowanej kolorystyce i o prostej formie.",
                            ImageURL = "/Images/witryna-wysoka-vigo.png",
                            Name = "Witryna Wysoka Vigo",
                            Price = 959m,
                            ProducerId = 6
                        },
                        new
                        {
                            Id = 17,
                            Description = "Jest utrzymana w nowoczesnym stylu. Łączy w sobie dwa kolory – biały i naturalnego drewna. Należy do systemu meblowego Davin.",
                            ImageURL = "/Images/witryna-wysoka-davin.png",
                            Name = "Witryna Wysoka Davin",
                            Price = 799m,
                            ProducerId = 6
                        },
                        new
                        {
                            Id = 18,
                            Description = "WITRYNA WYSOKA KALMAR to wąska propozycja systemu meblowego Kalmar, która łączy wysoki walor estetyczny z funkcjonalnością.",
                            ImageURL = "/Images/witryna-wysoka-kalmar.png",
                            Name = "Witryna Wysoka Kalmar",
                            Price = 899m,
                            ProducerId = 6
                        },
                        new
                        {
                            Id = 19,
                            Description = "Stylowe i proste w formie rozkładane sofy i wersalki to idealne rozwiązanie do małego mieszkania.",
                            ImageURL = "/Images/wersalka-zenit-primo.png",
                            Name = "Wersalka Zenit Primo",
                            Price = 1349m,
                            ProducerId = 7
                        },
                        new
                        {
                            Id = 20,
                            Description = "Kanapa Tango w kolorze brązowym to praktyczna i funkcjonalna kanapa zaprojektowana w nowoczesnym stylu.",
                            ImageURL = "/Images/kanapa-tango-zetta.png",
                            Name = "Kanapa Tango Zetta",
                            Price = 1599m,
                            ProducerId = 7
                        },
                        new
                        {
                            Id = 21,
                            Description = "Stylowe i proste w formie rozkładane sofy i wersalki to idealne rozwiązanie do małego mieszkania, czy też w salonie, sypialni.",
                            ImageURL = "/Images/sofa-sally-monolith.png",
                            Name = "Sofa Sally Monolith",
                            Price = 2209m,
                            ProducerId = 7
                        },
                        new
                        {
                            Id = 22,
                            Description = "XOXO to rodzina szafek Hug&Kiss. Kolekcja powstała z miłości do prostoty i otwartości na personalizację użytkowania.",
                            ImageURL = "/Images/komoda-xoxo-kiss.png",
                            Name = "Komoda xoxo Kiss",
                            Price = 7990m,
                            ProducerId = 8
                        },
                        new
                        {
                            Id = 23,
                            Description = "XOXO to rodzina szafek Hug&Kiss. Kolekcja powstała z miłości do prostoty i otwartości na personalizację użytkowania. W zależności od sposobu wykończenia mebla, nabiera on zupełnie nowego charakteru.",
                            ImageURL = "/Images/komoda-xoxo-hug.png",
                            Name = "Komoda xoxo Hug",
                            Price = 7990m,
                            ProducerId = 8
                        },
                        new
                        {
                            Id = 24,
                            Description = "Komoda Ren to niezwykle reprezentacyjny, elegancki i ekskluzywny mebel. Piękna i praktyczna komoda pomieści wszystkie niezbędne przedmioty.",
                            ImageURL = "/Images/komoda-ren.png",
                            Name = "Komoda Ren",
                            Price = 6207m,
                            ProducerId = 8
                        },
                        new
                        {
                            Id = 25,
                            Description = "Krzesła z kolekcji KASHMIR to idealny wybór do nowoczesnej jadalni.",
                            ImageURL = "/Images/krzeslo-kashmir.png",
                            Name = "Krzesło Kashmir",
                            Price = 369m,
                            ProducerId = 9
                        },
                        new
                        {
                            Id = 26,
                            Description = "Prosta i minimalistyczna, konstrukcja krzesła z kolekcji MYRTOS, sprawdzi się w nowocześnie urządzonej jadalni lub pokoju dziennym.",
                            ImageURL = "/Images/krzeslo-myrtos.png",
                            Name = "Krzesło Myrtos",
                            Price = 399m,
                            ProducerId = 9
                        },
                        new
                        {
                            Id = 27,
                            Description = "Krzesło z kolekcji YADGIR łączy w sobie nowoczesność i funkcjonalność.",
                            ImageURL = "/Images/krzeslo-metal-yadgir.png",
                            Name = "Krzesło Metal Yadgir",
                            Price = 439m,
                            ProducerId = 9
                        });
                });

            modelBuilder.Entity("MielczarekFurniture.RestApi.Entities.Product", b =>
                {
                    b.HasOne("MielczarekFurniture.RestApi.Entities.Producer", "Producer")
                        .WithMany("Products")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("MielczarekFurniture.RestApi.Entities.Producer", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}