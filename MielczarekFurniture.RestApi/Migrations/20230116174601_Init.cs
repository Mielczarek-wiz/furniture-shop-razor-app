using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MielczarekFurniture.RestApi.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "producers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Star = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    ImageURL = table.Column<string>(type: "text", nullable: false),
                    ProducerId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_producers_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "producers",
                columns: new[] { "Id", "Name", "Star" },
                values: new object[,]
                {
                    { 1, "Black Red White", 0 },
                    { 2, "Bodzio", 2 },
                    { 3, "Agata Meble", 3 },
                    { 4, "Kler", 4 },
                    { 5, "Ikea", 5 },
                    { 6, "Komfort", 0 },
                    { 7, "Abra", 4 },
                    { 8, "Euforma", 3 },
                    { 9, "Świat Mebli", 1 }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "Description", "ImageURL", "Name", "Price", "ProducerId" },
                values: new object[,]
                {
                    { 1, "Minimalistyczny, prosty narożnik Neto jest idealną propozycją do kawalerki lub pokoju młodzieżowego, gdzie każdy metr powierzchni jest na wagę złota.", "/Images/naroznik-neto.png", "Narożnik Neto", 1679m, 1 },
                    { 2, "Narożnik z funkcją spania Risten- piękny i wygodny mebel.", "/Images/naroznik-risten.png", "Narożnik Risten", 3149m, 1 },
                    { 3, "Nowoczesny, lekki wizualnie i stylowy - taki właśnie jest narożnik Feliz, który dopełni wystrój Twojego salonu.", "/Images/naroznik-feliz.png", "Narożnik Feliz", 2559m, 1 },
                    { 4, "Rozkładany stół kuchenny o długości 116 cm, będzie idealnym rozwiązaniem w Twoim domu.", "/Images/rozkladany-stol-kuchenny-bialy.png", "Rozkładany stół kuchenny 116 cm (biały)", 469m, 2 },
                    { 5, "Okrągły stół o średnicy 110 cm, będzie idealnym rozwiązaniem w Twoim domu.", "/Images/rozkladany-okragly-stol-dab-bialy.png", "Stół okrągły rozkładany (dąb Soma ciemny/biały)", 715m, 2 },
                    { 6, "Nowoczesny i bardzo oryginalny stół okrągły Goldimos z blatem wykonanym ze szkła hartowanego i stelażem w kolorze złotym. Idealnie będzie pasował do kuchni oraz jadalni.", "/Images/stol-okragly-szklany-goldimos.png", "Stół okrągły szklany GOLDIMOS", 900m, 2 },
                    { 7, "Nowoczesny regał możesz postawić w salonie, jadalni, domowym biurze czy pokoju młodzieżowym.", "/Images/regal-scalar-bialy.png", "Regał SCALAR biały", 399m, 3 },
                    { 8, "Regał świetnie sprawdzi się jako forma domowej biblioteczki lub miejsce na uporządkowanie dokumentów w domowym biurze. Lekka konstrukcja pozwala na wiele możliwości wykorzystania bryły.", "/Images/regal-universum-dab-artisan-czarny.png", "Regał UNIWERSUM dąb artisan/czarny", 259m, 3 },
                    { 9, "Regał z szufladami Norton charakteryzuje się prostą minimalistyczną formą, która sprawia, że mebel pasuje do nowoczesnych wnętrz.", "/Images/regal-norton.png", "Regał NORTON", 669m, 3 },
                    { 10, "Biurko Max stworzone zostało z myślą o nauce i pracy, jest bowiem idealne do pokoju młodzieżowego, domowego gabinetu czy do biura.", "/Images/biurko-kartell-max.png", "Biurko Kartell Max", 5790m, 4 },
                    { 11, "Biurko Soft to kwintesencja skandynawskiej prostoty i minimalizmu.", "/Images/biurko-trebord-soft.png", "Biurko Trebord Soft", 4025m, 4 },
                    { 12, "Zac to eleganckie i nowoczesne biurko. Wspaniały mebel o absolutnym designie, który pięknie komponuje się z każdym otoczeniem.", "/Images/biurko-bontempi-zac.png", "Biurko Bontempi Zac", 9255m, 4 },
                    { 13, "roste wzornictwo, równie piękne z każdej strony - łózko może stać w pokoju wolnostojąco lub z wezgłowiem przy ścianie.", "/Images/lozko-malm.png", "Łóżko Malm", 999m, 5 },
                    { 14, "Tapicerowane miękką tkaniną, która wnosi przytulną atmosferę do sypialni.", "/Images/lozko-slattum.png", "Łóżko Slattum", 699m, 5 },
                    { 15, "Rama łóżka TARVA to nowoczesny przykład skandynawskiej tradycji meblarskiej - proste wzornictwo i surowe drewno.", "/Images/lozko-tarva.png", "Łóżko Tarva", 919m, 5 },
                    { 16, "Aby podkreślić nowoczesny charakter wnętrza wybierz meble utrzymane w stonowanej kolorystyce i o prostej formie.", "/Images/witryna-wysoka-vigo.png", "Witryna Wysoka Vigo", 959m, 6 },
                    { 17, "Jest utrzymana w nowoczesnym stylu. Łączy w sobie dwa kolory – biały i naturalnego drewna. Należy do systemu meblowego Davin.", "/Images/witryna-wysoka-davin.png", "Witryna Wysoka Davin", 799m, 6 },
                    { 18, "WITRYNA WYSOKA KALMAR to wąska propozycja systemu meblowego Kalmar, która łączy wysoki walor estetyczny z funkcjonalnością.", "/Images/witryna-wysoka-kalmar.png", "Witryna Wysoka Kalmar", 899m, 6 },
                    { 19, "Stylowe i proste w formie rozkładane sofy i wersalki to idealne rozwiązanie do małego mieszkania.", "/Images/wersalka-zenit-primo.png", "Wersalka Zenit Primo", 1349m, 7 },
                    { 20, "Kanapa Tango w kolorze brązowym to praktyczna i funkcjonalna kanapa zaprojektowana w nowoczesnym stylu.", "/Images/kanapa-tango-zetta.png", "Kanapa Tango Zetta", 1599m, 7 },
                    { 21, "Stylowe i proste w formie rozkładane sofy i wersalki to idealne rozwiązanie do małego mieszkania, czy też w salonie, sypialni.", "/Images/sofa-sally-monolith.png", "Sofa Sally Monolith", 2209m, 7 },
                    { 22, "XOXO to rodzina szafek Hug&Kiss. Kolekcja powstała z miłości do prostoty i otwartości na personalizację użytkowania.", "/Images/komoda-xoxo-kiss.png", "Komoda xoxo Kiss", 7990m, 8 },
                    { 23, "XOXO to rodzina szafek Hug&Kiss. Kolekcja powstała z miłości do prostoty i otwartości na personalizację użytkowania. W zależności od sposobu wykończenia mebla, nabiera on zupełnie nowego charakteru.", "/Images/komoda-xoxo-hug.png", "Komoda xoxo Hug", 7990m, 8 },
                    { 24, "Komoda Ren to niezwykle reprezentacyjny, elegancki i ekskluzywny mebel. Piękna i praktyczna komoda pomieści wszystkie niezbędne przedmioty.", "/Images/komoda-ren.png", "Komoda Ren", 6207m, 8 },
                    { 25, "Krzesła z kolekcji KASHMIR to idealny wybór do nowoczesnej jadalni.", "/Images/krzeslo-kashmir.png", "Krzesło Kashmir", 369m, 9 },
                    { 26, "Prosta i minimalistyczna, konstrukcja krzesła z kolekcji MYRTOS, sprawdzi się w nowocześnie urządzonej jadalni lub pokoju dziennym.", "/Images/krzeslo-myrtos.png", "Krzesło Myrtos", 399m, 9 },
                    { 27, "Krzesło z kolekcji YADGIR łączy w sobie nowoczesność i funkcjonalność.", "/Images/krzeslo-metal-yadgir.png", "Krzesło Metal Yadgir", 439m, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_ProducerId",
                table: "products",
                column: "ProducerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "producers");
        }
    }
}
