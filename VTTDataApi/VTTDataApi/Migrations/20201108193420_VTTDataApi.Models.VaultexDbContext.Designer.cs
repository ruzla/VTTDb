﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VaultexDataApi.Models;

namespace VTTDataApi.Migrations
{
    [DbContext(typeof(VaultexDbContext))]
    [Migration("20201108193420_VTTDataApi.Models.VaultexDbContext")]
    partial class VTTDataApiModelsVaultexDbContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VaultexDataApi.Models.EmployeeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganisationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Janet",
                            LastName = "Smith",
                            OrganisationNumber = "09740322"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Frank",
                            LastName = "Bloswick",
                            OrganisationNumber = "09740322"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Tonya",
                            LastName = "Bazinaw",
                            OrganisationNumber = "09740322"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Mike",
                            LastName = "St. Onge",
                            OrganisationNumber = "09740322"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Jackie",
                            LastName = "Jones",
                            OrganisationNumber = "09740322"
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Darren",
                            LastName = "Tillbrooke",
                            OrganisationNumber = "09740322"
                        },
                        new
                        {
                            Id = 7,
                            FirstName = "Stephanie",
                            LastName = "Holsinger",
                            OrganisationNumber = "09740322"
                        },
                        new
                        {
                            Id = 8,
                            FirstName = "Rene",
                            LastName = "Hughey",
                            OrganisationNumber = "09740322"
                        },
                        new
                        {
                            Id = 9,
                            FirstName = "Robert",
                            LastName = "Rogers",
                            OrganisationNumber = "09740322"
                        },
                        new
                        {
                            Id = 10,
                            FirstName = "Richard",
                            LastName = "LaPine",
                            OrganisationNumber = "09740322"
                        },
                        new
                        {
                            Id = 11,
                            FirstName = "Kathy",
                            LastName = "Summerfield",
                            OrganisationNumber = "09740322"
                        },
                        new
                        {
                            Id = 12,
                            FirstName = "Kathy",
                            LastName = "Bodwin",
                            OrganisationNumber = "09740322"
                        },
                        new
                        {
                            Id = 13,
                            FirstName = "Mitch",
                            LastName = "Krause",
                            OrganisationNumber = "00002065"
                        },
                        new
                        {
                            Id = 14,
                            FirstName = "George",
                            LastName = "Dow",
                            OrganisationNumber = "00002065"
                        },
                        new
                        {
                            Id = 15,
                            FirstName = "Jack",
                            LastName = "Malone",
                            OrganisationNumber = "00002065"
                        },
                        new
                        {
                            Id = 16,
                            FirstName = "Bill",
                            LastName = "Schweiz",
                            OrganisationNumber = "00002065"
                        },
                        new
                        {
                            Id = 17,
                            FirstName = "Mark",
                            LastName = "Gunter",
                            OrganisationNumber = "00002065"
                        },
                        new
                        {
                            Id = 18,
                            FirstName = "Bob",
                            LastName = "Anderson",
                            OrganisationNumber = "00002065"
                        },
                        new
                        {
                            Id = 19,
                            FirstName = "Scott",
                            LastName = "Simpson",
                            OrganisationNumber = "00002065"
                        },
                        new
                        {
                            Id = 20,
                            FirstName = "Phil",
                            LastName = "Dingman",
                            OrganisationNumber = "00002065"
                        },
                        new
                        {
                            Id = 21,
                            FirstName = "Chad",
                            LastName = "Leiker",
                            OrganisationNumber = "00002065"
                        },
                        new
                        {
                            Id = 22,
                            FirstName = "Ian",
                            LastName = "Benson",
                            OrganisationNumber = "00002065"
                        },
                        new
                        {
                            Id = 23,
                            FirstName = "Nicole",
                            LastName = "Lane",
                            OrganisationNumber = "00002065"
                        },
                        new
                        {
                            Id = 24,
                            FirstName = "Steve",
                            LastName = "Lundeen",
                            OrganisationNumber = "00002065"
                        },
                        new
                        {
                            Id = 25,
                            FirstName = "Erica",
                            LastName = "Black",
                            OrganisationNumber = "00002065"
                        },
                        new
                        {
                            Id = 26,
                            FirstName = "Xenos",
                            LastName = "Mathis",
                            OrganisationNumber = "00002065"
                        },
                        new
                        {
                            Id = 27,
                            FirstName = "Kyle",
                            LastName = "Good",
                            OrganisationNumber = "00002065"
                        },
                        new
                        {
                            Id = 28,
                            FirstName = "Raja",
                            LastName = "Dejesus",
                            OrganisationNumber = "00002065"
                        },
                        new
                        {
                            Id = 29,
                            FirstName = "Timothy",
                            LastName = "Frazier",
                            OrganisationNumber = "00002065"
                        },
                        new
                        {
                            Id = 30,
                            FirstName = "Francine",
                            LastName = "Morrison",
                            OrganisationNumber = "00002065"
                        },
                        new
                        {
                            Id = 31,
                            FirstName = "Avram",
                            LastName = "Pate",
                            OrganisationNumber = "SC095237"
                        },
                        new
                        {
                            Id = 32,
                            FirstName = "Hammett",
                            LastName = "Coffey",
                            OrganisationNumber = "SC095237"
                        },
                        new
                        {
                            Id = 33,
                            FirstName = "Hasad",
                            LastName = "Wise",
                            OrganisationNumber = "SC095237"
                        },
                        new
                        {
                            Id = 34,
                            FirstName = "Cullen",
                            LastName = "Riddle",
                            OrganisationNumber = "SC095237"
                        },
                        new
                        {
                            Id = 35,
                            FirstName = "Kato",
                            LastName = "Delgado",
                            OrganisationNumber = "SC095237"
                        },
                        new
                        {
                            Id = 36,
                            FirstName = "Todd",
                            LastName = "Wright",
                            OrganisationNumber = "SC095237"
                        },
                        new
                        {
                            Id = 37,
                            FirstName = "Troy",
                            LastName = "Mccoy",
                            OrganisationNumber = "SC095237"
                        },
                        new
                        {
                            Id = 38,
                            FirstName = "Gil",
                            LastName = "Duncan",
                            OrganisationNumber = "SC095237"
                        },
                        new
                        {
                            Id = 39,
                            FirstName = "Lionel",
                            LastName = "Espinoza",
                            OrganisationNumber = "SC095237"
                        },
                        new
                        {
                            Id = 40,
                            FirstName = "Victor",
                            LastName = "Merrill",
                            OrganisationNumber = "SC095237"
                        },
                        new
                        {
                            Id = 41,
                            FirstName = "Gennifer",
                            LastName = "Vance",
                            OrganisationNumber = "SC095237"
                        },
                        new
                        {
                            Id = 42,
                            FirstName = "Chancellor",
                            LastName = "Warner",
                            OrganisationNumber = "SC095237"
                        },
                        new
                        {
                            Id = 43,
                            FirstName = "Davis",
                            LastName = "Wolf",
                            OrganisationNumber = "SC095237"
                        },
                        new
                        {
                            Id = 44,
                            FirstName = "Carlos",
                            LastName = "Clarke",
                            OrganisationNumber = "00966425"
                        },
                        new
                        {
                            Id = 45,
                            FirstName = "Dolan",
                            LastName = "Mercado",
                            OrganisationNumber = "00966425"
                        },
                        new
                        {
                            Id = 46,
                            FirstName = "Helen",
                            LastName = "Guthrie",
                            OrganisationNumber = "00966425"
                        },
                        new
                        {
                            Id = 47,
                            FirstName = "Elmo",
                            LastName = "Douglas",
                            OrganisationNumber = "00966425"
                        },
                        new
                        {
                            Id = 48,
                            FirstName = "Kane",
                            LastName = "Rice",
                            OrganisationNumber = "00966425"
                        },
                        new
                        {
                            Id = 49,
                            FirstName = "Colt",
                            LastName = "Rowland",
                            OrganisationNumber = "00966425"
                        },
                        new
                        {
                            Id = 50,
                            FirstName = "John",
                            LastName = "Rose",
                            OrganisationNumber = "00966425"
                        },
                        new
                        {
                            Id = 51,
                            FirstName = "Alfonso",
                            LastName = "Hopkins",
                            OrganisationNumber = "00966425"
                        },
                        new
                        {
                            Id = 52,
                            FirstName = "Ida",
                            LastName = "Watts",
                            OrganisationNumber = "00966425"
                        },
                        new
                        {
                            Id = 53,
                            FirstName = "Jennifer",
                            LastName = "Coleman",
                            OrganisationNumber = "00966425"
                        },
                        new
                        {
                            Id = 54,
                            FirstName = "Ciaran",
                            LastName = "Newton",
                            OrganisationNumber = "00966425"
                        },
                        new
                        {
                            Id = 55,
                            FirstName = "Hiram",
                            LastName = "Carrillo",
                            OrganisationNumber = "00966425"
                        },
                        new
                        {
                            Id = 56,
                            FirstName = "Devin",
                            LastName = "Russell",
                            OrganisationNumber = "00966425"
                        },
                        new
                        {
                            Id = 57,
                            FirstName = "Arsenio",
                            LastName = "Jensen",
                            OrganisationNumber = "00966425"
                        },
                        new
                        {
                            Id = 58,
                            FirstName = "Otto",
                            LastName = "Gibbs",
                            OrganisationNumber = "00966425"
                        },
                        new
                        {
                            Id = 59,
                            FirstName = "Hiram",
                            LastName = "Vega",
                            OrganisationNumber = "00966425"
                        },
                        new
                        {
                            Id = 60,
                            FirstName = "Jarrod",
                            LastName = "Randolph",
                            OrganisationNumber = "SC327000"
                        },
                        new
                        {
                            Id = 61,
                            FirstName = "Josiah",
                            LastName = "Gates",
                            OrganisationNumber = "SC327000"
                        },
                        new
                        {
                            Id = 62,
                            FirstName = "Brandon",
                            LastName = "Stanley",
                            OrganisationNumber = "SC327000"
                        },
                        new
                        {
                            Id = 63,
                            FirstName = "Kennedy",
                            LastName = "Nunez",
                            OrganisationNumber = "SC327000"
                        },
                        new
                        {
                            Id = 64,
                            FirstName = "Lewis",
                            LastName = "Sanchez",
                            OrganisationNumber = "SC327000"
                        },
                        new
                        {
                            Id = 65,
                            FirstName = "Kassie",
                            LastName = "Chaney",
                            OrganisationNumber = "SC327000"
                        },
                        new
                        {
                            Id = 66,
                            FirstName = "Lance",
                            LastName = "Knox",
                            OrganisationNumber = "SC327000"
                        },
                        new
                        {
                            Id = 67,
                            FirstName = "Lamar",
                            LastName = "Harrison",
                            OrganisationNumber = "SC327000"
                        },
                        new
                        {
                            Id = 68,
                            FirstName = "Honorato",
                            LastName = "Montgomery",
                            OrganisationNumber = "SC327000"
                        },
                        new
                        {
                            Id = 69,
                            FirstName = "Lisa",
                            LastName = "Nielsen",
                            OrganisationNumber = "00014259"
                        },
                        new
                        {
                            Id = 70,
                            FirstName = "Layla",
                            LastName = "Barr",
                            OrganisationNumber = "00014259"
                        },
                        new
                        {
                            Id = 71,
                            FirstName = "Nancy",
                            LastName = "Mcclain",
                            OrganisationNumber = "00014259"
                        },
                        new
                        {
                            Id = 72,
                            FirstName = "Kato",
                            LastName = "Delgado",
                            OrganisationNumber = "00014259"
                        },
                        new
                        {
                            Id = 73,
                            FirstName = "Todd",
                            LastName = "Wright",
                            OrganisationNumber = "00014259"
                        },
                        new
                        {
                            Id = 74,
                            FirstName = "Troy",
                            LastName = "Mccoy",
                            OrganisationNumber = "00014259"
                        },
                        new
                        {
                            Id = 75,
                            FirstName = "Gil",
                            LastName = "Duncan",
                            OrganisationNumber = "00014259"
                        },
                        new
                        {
                            Id = 76,
                            FirstName = "Lionel",
                            LastName = "Espinoza",
                            OrganisationNumber = "00014259"
                        });
                });

            modelBuilder.Entity("VaultexDataApi.Models.OrganisationModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganisationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganisationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Organisations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressLine1 = "1 Churchill Place",
                            AddressLine2 = "",
                            AddressLine3 = "",
                            AddressLine4 = "",
                            OrganisationName = "Barclays UK PLC",
                            OrganisationNumber = "09740322",
                            Postcode = "E14 5HP",
                            Town = "London"
                        },
                        new
                        {
                            Id = 2,
                            AddressLine1 = "8 Canada Square",
                            AddressLine2 = "",
                            AddressLine3 = "",
                            AddressLine4 = "",
                            OrganisationName = "HSBC BANK PLC",
                            OrganisationNumber = "00014259",
                            Postcode = "E14 5HQ",
                            Town = "London"
                        },
                        new
                        {
                            Id = 3,
                            AddressLine1 = "25 Gresham Street",
                            AddressLine2 = "",
                            AddressLine3 = "",
                            AddressLine4 = "",
                            OrganisationName = "LLOYDS BANK PLC",
                            OrganisationNumber = "00002065",
                            Postcode = "EC2V 7HN",
                            Town = "London"
                        },
                        new
                        {
                            Id = 4,
                            AddressLine1 = "Henry Duncan House",
                            AddressLine2 = "120 George Street",
                            AddressLine3 = "",
                            AddressLine4 = "",
                            OrganisationName = "TSB BANK PLC",
                            OrganisationNumber = "SC095237",
                            Postcode = "EH2 4LH",
                            Town = "Edinburgh"
                        },
                        new
                        {
                            Id = 5,
                            AddressLine1 = "30 St Vincent Place",
                            AddressLine2 = "",
                            AddressLine3 = "",
                            AddressLine4 = "",
                            OrganisationName = "CLYDESDALE BANK PLC",
                            OrganisationNumber = "SC001111",
                            Postcode = "G1 2HL",
                            Town = "Glasgow"
                        },
                        new
                        {
                            Id = 6,
                            AddressLine1 = "1 Basinghall Avenue",
                            AddressLine2 = "",
                            AddressLine3 = "",
                            AddressLine4 = "",
                            OrganisationName = "STANDARD CHARTERED PLC",
                            OrganisationNumber = "00966425",
                            Postcode = "EC2V 5DD",
                            Town = "London"
                        },
                        new
                        {
                            Id = 7,
                            AddressLine1 = "The Mound",
                            AddressLine2 = "",
                            AddressLine3 = "",
                            AddressLine4 = "",
                            OrganisationName = "BANK OF SCOTLAND PLC",
                            OrganisationNumber = "SC327000",
                            Postcode = "EH1 1YZ",
                            Town = "Edinburgh"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
