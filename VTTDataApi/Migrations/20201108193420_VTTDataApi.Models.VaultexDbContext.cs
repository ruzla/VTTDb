using Microsoft.EntityFrameworkCore.Migrations;

namespace VTTDataApi.Migrations
{
    public partial class VTTDataApiModelsVaultexDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganisationNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organisations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganisationName = table.Column<string>(nullable: true),
                    OrganisationNumber = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    AddressLine3 = table.Column<string>(nullable: true),
                    AddressLine4 = table.Column<string>(nullable: true),
                    Town = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "LastName", "OrganisationNumber" },
                values: new object[,]
                {
                    { 1, "Janet", "Smith", "09740322" },
                    { 56, "Devin", "Russell", "00966425" },
                    { 55, "Hiram", "Carrillo", "00966425" },
                    { 54, "Ciaran", "Newton", "00966425" },
                    { 53, "Jennifer", "Coleman", "00966425" },
                    { 52, "Ida", "Watts", "00966425" },
                    { 51, "Alfonso", "Hopkins", "00966425" },
                    { 50, "John", "Rose", "00966425" },
                    { 49, "Colt", "Rowland", "00966425" },
                    { 48, "Kane", "Rice", "00966425" },
                    { 47, "Elmo", "Douglas", "00966425" },
                    { 46, "Helen", "Guthrie", "00966425" },
                    { 45, "Dolan", "Mercado", "00966425" },
                    { 44, "Carlos", "Clarke", "00966425" },
                    { 43, "Davis", "Wolf", "SC095237" },
                    { 41, "Gennifer", "Vance", "SC095237" },
                    { 57, "Arsenio", "Jensen", "00966425" },
                    { 58, "Otto", "Gibbs", "00966425" },
                    { 59, "Hiram", "Vega", "00966425" },
                    { 60, "Jarrod", "Randolph", "SC327000" },
                    { 76, "Lionel", "Espinoza", "00014259" },
                    { 75, "Gil", "Duncan", "00014259" },
                    { 74, "Troy", "Mccoy", "00014259" },
                    { 73, "Todd", "Wright", "00014259" },
                    { 72, "Kato", "Delgado", "00014259" },
                    { 71, "Nancy", "Mcclain", "00014259" },
                    { 70, "Layla", "Barr", "00014259" },
                    { 40, "Victor", "Merrill", "SC095237" },
                    { 69, "Lisa", "Nielsen", "00014259" },
                    { 67, "Lamar", "Harrison", "SC327000" },
                    { 66, "Lance", "Knox", "SC327000" },
                    { 65, "Kassie", "Chaney", "SC327000" },
                    { 64, "Lewis", "Sanchez", "SC327000" },
                    { 63, "Kennedy", "Nunez", "SC327000" },
                    { 62, "Brandon", "Stanley", "SC327000" },
                    { 61, "Josiah", "Gates", "SC327000" },
                    { 68, "Honorato", "Montgomery", "SC327000" },
                    { 39, "Lionel", "Espinoza", "SC095237" },
                    { 42, "Chancellor", "Warner", "SC095237" },
                    { 37, "Troy", "Mccoy", "SC095237" },
                    { 38, "Gil", "Duncan", "SC095237" },
                    { 16, "Bill", "Schweiz", "00002065" },
                    { 15, "Jack", "Malone", "00002065" },
                    { 14, "George", "Dow", "00002065" },
                    { 13, "Mitch", "Krause", "00002065" },
                    { 12, "Kathy", "Bodwin", "09740322" },
                    { 11, "Kathy", "Summerfield", "09740322" },
                    { 18, "Bob", "Anderson", "00002065" },
                    { 10, "Richard", "LaPine", "09740322" },
                    { 8, "Rene", "Hughey", "09740322" },
                    { 7, "Stephanie", "Holsinger", "09740322" },
                    { 6, "Darren", "Tillbrooke", "09740322" },
                    { 5, "Jackie", "Jones", "09740322" },
                    { 4, "Mike", "St. Onge", "09740322" },
                    { 3, "Tonya", "Bazinaw", "09740322" },
                    { 2, "Frank", "Bloswick", "09740322" },
                    { 9, "Robert", "Rogers", "09740322" },
                    { 19, "Scott", "Simpson", "00002065" },
                    { 17, "Mark", "Gunter", "00002065" },
                    { 21, "Chad", "Leiker", "00002065" },
                    { 36, "Todd", "Wright", "SC095237" },
                    { 35, "Kato", "Delgado", "SC095237" },
                    { 34, "Cullen", "Riddle", "SC095237" },
                    { 33, "Hasad", "Wise", "SC095237" },
                    { 20, "Phil", "Dingman", "00002065" },
                    { 31, "Avram", "Pate", "SC095237" },
                    { 30, "Francine", "Morrison", "00002065" },
                    { 32, "Hammett", "Coffey", "SC095237" },
                    { 28, "Raja", "Dejesus", "00002065" },
                    { 27, "Kyle", "Good", "00002065" },
                    { 26, "Xenos", "Mathis", "00002065" },
                    { 25, "Erica", "Black", "00002065" },
                    { 24, "Steve", "Lundeen", "00002065" },
                    { 23, "Nicole", "Lane", "00002065" },
                    { 22, "Ian", "Benson", "00002065" },
                    { 29, "Timothy", "Frazier", "00002065" }
                });

            migrationBuilder.InsertData(
                table: "Organisations",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "AddressLine3", "AddressLine4", "OrganisationName", "OrganisationNumber", "Postcode", "Town" },
                values: new object[,]
                {
                    { 6, "1 Basinghall Avenue", "", "", "", "STANDARD CHARTERED PLC", "00966425", "EC2V 5DD", "London" },
                    { 1, "1 Churchill Place", "", "", "", "Barclays UK PLC", "09740322", "E14 5HP", "London" },
                    { 2, "8 Canada Square", "", "", "", "HSBC BANK PLC", "00014259", "E14 5HQ", "London" },
                    { 3, "25 Gresham Street", "", "", "", "LLOYDS BANK PLC", "00002065", "EC2V 7HN", "London" },
                    { 4, "Henry Duncan House", "120 George Street", "", "", "TSB BANK PLC", "SC095237", "EH2 4LH", "Edinburgh" },
                    { 5, "30 St Vincent Place", "", "", "", "CLYDESDALE BANK PLC", "SC001111", "G1 2HL", "Glasgow" },
                    { 7, "The Mound", "", "", "", "BANK OF SCOTLAND PLC", "SC327000", "EH1 1YZ", "Edinburgh" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Organisations");
        }
    }
}
