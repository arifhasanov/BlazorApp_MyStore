using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Server.Migrations
{
    /// <inheritdoc />
    public partial class DotNetSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "MyPrice", "Title" },
                values: new object[,]
                {
                    { 1, "In May 1997, the world watched as Garry Kasparov, the greatest chess player in the world, was defeated for the first time by the IBM supercomputer Deep Blue. It was a watershed moment in the history of technology: machine intelligence had arrived at the point where it could best human intellect.\r\nIt wasn't a coincidence that Kasparov became the symbol of man's fight against the machines. Chess has long been the fulcrum in development of machine intelligence; the hoax automaton 'The Turk' in the 18th century and Alan Turing's first chess program in 1952 were two early examples of the quest for machines to think like humans -- a talent we measured by their ability to beat their creators at chess. As the pre-eminent chessmaster of the 80s and 90s, it was Kasparov's blessing and his curse to play against each generation's strongest computer champions, contributing to their development and advancing the field.", "https://m.media-amazon.com/images/I/41VSOxkShBL.jpg", 9.99m, "Deep Thinking: Where Machine Intelligence Ends and Human Creativity Begins" },
                    { 2, "Why are some nations more prosperous than others? Why Nations Fail sets out to answer this question, with a compelling and elegantly argued new theory: that it is not down to climate, geography or culture, but because of institutions. Drawing on an extraordinary range of contemporary and historical examples, from ancient Rome through the Tudors to modern-day China, leading academics Daron Acemoglu and James A. Robinson show that to invest and prosper, people need to know that if they work hard, they can make money and actually keep it - and this means sound institutions that allow virtuous circles of innovation, expansion and peace.", "https://m.media-amazon.com/images/I/51n3+4Yu02L.jpg", 7.99m, "Why Nations Fail: The Origins of Power, Prosperity and Poverty" },
                    { 3, "It's the Japanese word for 'a reason to live' or 'a reason to jump out of bed in the morning'.\r\n\r\nIt's the place where your needs, desires, ambitions, and satisfaction meet. A place of balance. Small wonder that finding your ikigai is closely linked to living longer.\r\n\r\nFinding your ikigai is easier than you might think. This book will help you work out what your own ikigai really is, and equip you to change your life. You have a purpose in this world: your skills, your interests, your desires and your history have made you the perfect candidate for something. All you have to do is find it.", "https://m.media-amazon.com/images/I/51xwGSNX-EL.jpg", 6.99m, "Ikigai: The Japanese secret to a long and happy life" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
