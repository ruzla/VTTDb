using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VaultexDataApi.Models
{
    public class VaultexDbContext : DbContext
    {
        public VaultexDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<EmployeeModel> Employees { get; set; }
        public DbSet<OrganisationModel> Organisations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeModel>().HasData(
            new EmployeeModel
            {
                Id = 1,
                OrganisationNumber = "09740322",
                FirstName = "Janet",
                LastName = "Smith"
            },

            new EmployeeModel
            {
                Id = 2,
                OrganisationNumber = "09740322",
                FirstName = "Frank",
                LastName = "Bloswick"
            },

            new EmployeeModel
            {
                Id = 3,
                OrganisationNumber = "09740322",
                FirstName = "Tonya",
                LastName = "Bazinaw"
            },

            new EmployeeModel
            {
                Id = 4,
                OrganisationNumber = "09740322",
                FirstName = "Mike",
                LastName = "St. Onge"
            },

            new EmployeeModel
            {
                Id = 5,
                OrganisationNumber = "09740322",
                FirstName = "Jackie",
                LastName = "Jones"
            },

            new EmployeeModel
            {
                Id = 6,
                OrganisationNumber = "09740322",
                FirstName = "Darren",
                LastName = "Tillbrooke"
            },

            new EmployeeModel
            {
                Id = 7,
                OrganisationNumber = "09740322",
                FirstName = "Stephanie",
                LastName = "Holsinger"
            },

            new EmployeeModel
            {
                Id = 8,
                OrganisationNumber = "09740322",
                FirstName = "Rene",
                LastName = "Hughey"
            },

            new EmployeeModel
            {
                Id = 9,
                OrganisationNumber = "09740322",
                FirstName = "Robert",
                LastName = "Rogers"
            },

            new EmployeeModel
            {
                Id = 10,
                OrganisationNumber = "09740322",
                FirstName = "Richard",
                LastName = "LaPine"
            },

            new EmployeeModel
            {
                Id = 11,
                OrganisationNumber = "09740322",
                FirstName = "Kathy",
                LastName = "Summerfield"
            },

            new EmployeeModel
            {
                Id = 12,
                OrganisationNumber = "09740322",
                FirstName = "Kathy",
                LastName = "Bodwin"
            },

            new EmployeeModel
            {
                Id = 13,
                OrganisationNumber = "00002065",
                FirstName = "Mitch",
                LastName = "Krause"
            },

            new EmployeeModel
            {
                Id = 14,
                OrganisationNumber = "00002065",
                FirstName = "George",
                LastName = "Dow"
            },

            new EmployeeModel
            {
                Id = 15,
                OrganisationNumber = "00002065",
                FirstName = "Jack",
                LastName = "Malone"
            },

            new EmployeeModel
            {
                Id = 16,
                OrganisationNumber = "00002065",
                FirstName = "Bill",
                LastName = "Schweiz"
            },

            new EmployeeModel
            {
                Id = 17,
                OrganisationNumber = "00002065",
                FirstName = "Mark",
                LastName = "Gunter"
            },

            new EmployeeModel
            {
                Id = 18,
                OrganisationNumber = "00002065",
                FirstName = "Bob",
                LastName = "Anderson"
            },

            new EmployeeModel
            {
                Id = 19,
                OrganisationNumber = "00002065",
                FirstName = "Scott",
                LastName = "Simpson"
            },

            new EmployeeModel
            {
                Id = 20,
                OrganisationNumber = "00002065",
                FirstName = "Phil",
                LastName = "Dingman"
            },

            new EmployeeModel
            {
                Id = 21,
                OrganisationNumber = "00002065",
                FirstName = "Chad",
                LastName = "Leiker"
            },

            new EmployeeModel
            {
                Id = 22,
                OrganisationNumber = "00002065",
                FirstName = "Ian",
                LastName = "Benson"
            },

            new EmployeeModel
            {
                Id = 23,
                OrganisationNumber = "00002065",
                FirstName = "Nicole",
                LastName = "Lane"
            },

            new EmployeeModel
            {
                Id = 24,
                OrganisationNumber = "00002065",
                FirstName = "Steve",
                LastName = "Lundeen"
            },

            new EmployeeModel
            {
                Id = 25,
                OrganisationNumber = "00002065",
                FirstName = "Erica",
                LastName = "Black"
            },

            new EmployeeModel
            {
                Id = 26,
                OrganisationNumber = "00002065",
                FirstName = "Xenos",
                LastName = "Mathis"
            },

            new EmployeeModel
            {
                Id = 27,
                OrganisationNumber = "00002065",
                FirstName = "Kyle",
                LastName = "Good"
            },

            new EmployeeModel
            {
                Id = 28,
                OrganisationNumber = "00002065",
                FirstName = "Raja",
                LastName = "Dejesus"
            },

            new EmployeeModel
            {
                Id = 29,
                OrganisationNumber = "00002065",
                FirstName = "Timothy",
                LastName = "Frazier"
            },

            new EmployeeModel
            {
                Id = 30,
                OrganisationNumber = "00002065",
                FirstName = "Francine",
                LastName = "Morrison"
            },

            new EmployeeModel
            {
                Id = 31,
                OrganisationNumber = "SC095237",
                FirstName = "Avram",
                LastName = "Pate"
            },

            new EmployeeModel
            {
                Id = 32,
                OrganisationNumber = "SC095237",
                FirstName = "Hammett",
                LastName = "Coffey"
            },

            new EmployeeModel
            {
                Id = 33,
                OrganisationNumber = "SC095237",
                FirstName = "Hasad",
                LastName = "Wise"
            },

            new EmployeeModel
            {
                Id = 34,
                OrganisationNumber = "SC095237",
                FirstName = "Cullen",
                LastName = "Riddle"
            },

            new EmployeeModel
            {
                Id = 35,
                OrganisationNumber = "SC095237",
                FirstName = "Kato",
                LastName = "Delgado"
            },

            new EmployeeModel
            {
                Id = 36,
                OrganisationNumber = "SC095237",
                FirstName = "Todd",
                LastName = "Wright"
            },

            new EmployeeModel
            {
                Id = 37,
                OrganisationNumber = "SC095237",
                FirstName = "Troy",
                LastName = "Mccoy"
            },

            new EmployeeModel
            {
                Id = 38,
                OrganisationNumber = "SC095237",
                FirstName = "Gil",
                LastName = "Duncan"
            },

            new EmployeeModel
            {
                Id = 39,
                OrganisationNumber = "SC095237",
                FirstName = "Lionel",
                LastName = "Espinoza"
            },

            new EmployeeModel
            {
                Id = 40,
                OrganisationNumber = "SC095237",
                FirstName = "Victor",
                LastName = "Merrill"
            },

            new EmployeeModel
            {
                Id = 41,
                OrganisationNumber = "SC095237",
                FirstName = "Gennifer",
                LastName = "Vance"
            },

            new EmployeeModel
            {
                Id = 42,
                OrganisationNumber = "SC095237",
                FirstName = "Chancellor",
                LastName = "Warner"
            },

            new EmployeeModel
            {
                Id = 43,
                OrganisationNumber = "SC095237",
                FirstName = "Davis",
                LastName = "Wolf"
            },

            new EmployeeModel
            {
                Id = 44,
                OrganisationNumber = "00966425",
                FirstName = "Carlos",
                LastName = "Clarke"
            },

            new EmployeeModel
            {
                Id = 45,
                OrganisationNumber = "00966425",
                FirstName = "Dolan",
                LastName = "Mercado"
            },

            new EmployeeModel
            {
                Id = 46,
                OrganisationNumber = "00966425",
                FirstName = "Helen",
                LastName = "Guthrie"
            },

            new EmployeeModel
            {
                Id = 47,
                OrganisationNumber = "00966425",
                FirstName = "Elmo",
                LastName = "Douglas"
            },

            new EmployeeModel
            {
                Id = 48,
                OrganisationNumber = "00966425",
                FirstName = "Kane",
                LastName = "Rice"
            },

            new EmployeeModel
            {
                Id = 49,
                OrganisationNumber = "00966425",
                FirstName = "Colt",
                LastName = "Rowland"
            },

            new EmployeeModel
            {
                Id = 50,
                OrganisationNumber = "00966425",
                FirstName = "John",
                LastName = "Rose"
            },

            new EmployeeModel
            {
                Id = 51,
                OrganisationNumber = "00966425",
                FirstName = "Alfonso",
                LastName = "Hopkins"
            },

            new EmployeeModel
            {
                Id = 52,
                OrganisationNumber = "00966425",
                FirstName = "Ida",
                LastName = "Watts"
            },

            new EmployeeModel
            {
                Id = 53,
                OrganisationNumber = "00966425",
                FirstName = "Jennifer",
                LastName = "Coleman"
            },

            new EmployeeModel
            {
                Id = 54,
                OrganisationNumber = "00966425",
                FirstName = "Ciaran",
                LastName = "Newton"
            },

            new EmployeeModel
            {
                Id = 55,
                OrganisationNumber = "00966425",
                FirstName = "Hiram",
                LastName = "Carrillo"
            },

            new EmployeeModel
            {
                Id = 56,
                OrganisationNumber = "00966425",
                FirstName = "Devin",
                LastName = "Russell"
            },
            new EmployeeModel
            {
                Id = 57,
                OrganisationNumber = "00966425",
                FirstName = "Arsenio",
                LastName = "Jensen"
            },

            new EmployeeModel
            {
                Id = 58,
                OrganisationNumber = "00966425",
                FirstName = "Otto",
                LastName = "Gibbs"
            },

            new EmployeeModel
            {
                Id = 59,
                OrganisationNumber = "00966425",
                FirstName = "Hiram",
                LastName = "Vega"
            },

            new EmployeeModel
            {
                Id = 60,
                OrganisationNumber = "SC327000",
                FirstName = "Jarrod",
                LastName = "Randolph"
            },

            new EmployeeModel
            {
                Id = 61,
                OrganisationNumber = "SC327000",
                FirstName = "Josiah",
                LastName = "Gates"
            },

            new EmployeeModel
            {
                Id = 62,
                OrganisationNumber = "SC327000",
                FirstName = "Brandon",
                LastName = "Stanley"
            },

            new EmployeeModel
            {
                Id = 63,
                OrganisationNumber = "SC327000",
                FirstName = "Kennedy",
                LastName = "Nunez"
            },

            new EmployeeModel
            {
                Id = 64,
                OrganisationNumber = "SC327000",
                FirstName = "Lewis",
                LastName = "Sanchez"
            },

            new EmployeeModel
            {
                Id = 65,
                OrganisationNumber = "SC327000",
                FirstName = "Kassie",
                LastName = "Chaney"
            },

            new EmployeeModel
            {
                Id = 66,
                OrganisationNumber = "SC327000",
                FirstName = "Lance",
                LastName = "Knox"
            },

            new EmployeeModel
            {
                Id = 67,
                OrganisationNumber = "SC327000",
                FirstName = "Lamar",
                LastName = "Harrison"
            },

            new EmployeeModel
            {
                Id = 68,
                OrganisationNumber = "SC327000",
                FirstName = "Honorato",
                LastName = "Montgomery"
            },

            new EmployeeModel
            {
                Id = 69,
                OrganisationNumber = "00014259",
                FirstName = "Lisa",
                LastName = "Nielsen"
            },

            new EmployeeModel
            {
                Id = 70,
                OrganisationNumber = "00014259",
                FirstName = "Layla",
                LastName = "Barr"
            },

            new EmployeeModel
            {
                Id = 71,
                OrganisationNumber = "00014259",
                FirstName = "Nancy",
                LastName = "Mcclain"
            },

            new EmployeeModel
            {
                Id = 72,
                OrganisationNumber = "00014259",
                FirstName = "Kato",
                LastName = "Delgado"
            },

            new EmployeeModel
            {
                Id = 73,
                OrganisationNumber = "00014259",
                FirstName = "Todd",
                LastName = "Wright"
            },

            new EmployeeModel
            {
                Id = 74,
                OrganisationNumber = "00014259",
                FirstName = "Troy",
                LastName = "Mccoy"
            },

            new EmployeeModel
            {
                Id = 75,
                OrganisationNumber = "00014259",
                FirstName = "Gil",
                LastName = "Duncan"
            },

            new EmployeeModel
            {
                Id = 76,
                OrganisationNumber = "00014259",
                FirstName = "Lionel",
                LastName = "Espinoza"
            });

            modelBuilder.Entity<OrganisationModel>().HasData(
            new OrganisationModel
            {
                Id = 1,
                OrganisationName = "Barclays UK PLC",
                OrganisationNumber = "09740322",
                AddressLine1 = "1 Churchill Place",
                AddressLine2 = "",
                AddressLine3 = "",
                AddressLine4 = "",
                Town = "London",
                Postcode = "E14 5HP"
            },

            new OrganisationModel
            {
                Id = 2,
                OrganisationName = "HSBC BANK PLC",
                OrganisationNumber = "00014259",
                AddressLine1 = "8 Canada Square",
                AddressLine2 = "",
                AddressLine3 = "",
                AddressLine4 = "",
                Town = "London",
                Postcode = "E14 5HQ"
            },


            new OrganisationModel
            {
                Id = 3,
                OrganisationName = "LLOYDS BANK PLC",
                OrganisationNumber = "00002065",
                AddressLine1 = "25 Gresham Street",
                AddressLine2 = "",
                AddressLine3 = "",
                AddressLine4 = "",
                Town = "London",
                Postcode = "EC2V 7HN"
            },


            new OrganisationModel
            {
                Id = 4,
                OrganisationName = "TSB BANK PLC",
                OrganisationNumber = "SC095237",
                AddressLine1 = "Henry Duncan House",
                AddressLine2 = "120 George Street",
                AddressLine3 = "",
                AddressLine4 = "",
                Town = "Edinburgh",
                Postcode = "EH2 4LH"
            },


            new OrganisationModel
            {
                Id = 5,
                OrganisationName = "CLYDESDALE BANK PLC",
                OrganisationNumber = "SC001111",
                AddressLine1 = "30 St Vincent Place",
                AddressLine2 = "",
                AddressLine3 = "",
                AddressLine4 = "",
                Town = "Glasgow",
                Postcode = "G1 2HL"
            },


            new OrganisationModel
            {
                Id = 6,
                OrganisationName = "STANDARD CHARTERED PLC",
                OrganisationNumber = "00966425",
                AddressLine1 = "1 Basinghall Avenue",
                AddressLine2 = "",
                AddressLine3 = "",
                AddressLine4 = "",
                Town = "London",
                Postcode = "EC2V 5DD"
            },


            new OrganisationModel
            {
                Id = 7,
                OrganisationName = "BANK OF SCOTLAND PLC",
                OrganisationNumber = "SC327000",
                AddressLine1 = "The Mound",
                AddressLine2 = "",
                AddressLine3 = "",
                AddressLine4 = "",
                Town = "Edinburgh",
                Postcode = "EH1 1YZ"
            });
        }

    }
}

