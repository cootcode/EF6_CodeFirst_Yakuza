using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF6_CodeFirst_Yakuza.Models
{
    public class YakuzaDbInitializer : DropCreateDatabaseAlways<YakuzaDbContext>
    {

        protected override void Seed(YakuzaDbContext context)
        {
            base.Seed(context);

            //create members
            Member member1 = new Member()
            {
                FamilyName = "Green",
                PersonalName = "Litzy",
                DateJoinedClan = new DateTime(2013, 06, 10),
                DateOfBirth = new DateTime(1995, 05, 03),
                DateDeceased = new DateTime(2019, 05, 25),
                Skill = Skill.Bodyguard,

            };
            Member member2 = new Member()
            {
                FamilyName = "Johnson",
                PersonalName = "Emerson",
                DateJoinedClan = new DateTime(1991, 01, 01),
                DateOfBirth = new DateTime(1973, 03, 03),
                DateDeceased = new DateTime(1999, 12, 31),
                Skill = Skill.Singer,
            };
            Member member3 = new Member()
            {
                FamilyName = "Schowalter",
                PersonalName = "Kelvin",
                DateJoinedClan = new DateTime(1950, 01, 09),
                DateOfBirth = new DateTime(1935, 07, 12),
                DateDeceased = new DateTime(1962, 08, 01),
                Skill = Skill.Meditator,
            };

            Member member4 = new Member()
            {
                FamilyName = "Wilkinson",
                PersonalName = "Maegan",
                DateJoinedClan = new DateTime(1972, 11, 25),
                DateOfBirth = new DateTime(1955, 10, 10),
                DateDeceased = new DateTime(1982, 03, 14),
                Skill = Skill.Driver,

            };

            Member member5 = new Member()
            {
                FamilyName = "Wilkinson",
                PersonalName = "Lonnie",
                DateJoinedClan = new DateTime(1995, 02, 08),
                DateOfBirth = new DateTime(1982, 09, 01),
                Skill = Skill.Chef,

            };

            Member member6 = new Member()
            {
                FamilyName = "Neo",
                PersonalName = "Alan",
                DateJoinedClan = new DateTime(2000, 05, 05),
                DateOfBirth = new DateTime(1985, 01, 01),
                DateDeceased = new DateTime(2002, 06, 30),
                Skill = Skill.Bodyguard,

            };


            Member member7 = new Member
            {
                FamilyName = "Kiryu",
                PersonalName = "Kazuma",
                DateJoinedClan = new DateTime(2000, 05, 05),
                DateOfBirth = new DateTime(1985, 01, 01),
                Skill = Skill.Bodyguard,
            };
            Member member8 = new Member
            {
                FamilyName = "evw",
                PersonalName = "juhyy",
                DateJoinedClan = new DateTime(2000, 05, 05),
                DateOfBirth = new DateTime(1985, 01, 01),
                Skill = Skill.Trainer,
            };
            Member member9 = new Member
            {
                FamilyName = "Smith",
                PersonalName = "Small",
                DateJoinedClan = new DateTime(2000, 05, 05),
                DateOfBirth = new DateTime(1985, 01, 01),
                Skill = Skill.Karate,
            };

            List<Member> members1 = new List<Member>();

            members1.Add(member1);
            members1.Add(member2);
            members1.Add(member3);
            members1.Add(member4);


            List<Member> members2 = new List<Member>();

            members2.Add(member5);
            members2.Add(member6);
            members2.Add(member7);
            members2.Add(member8);
            members2.Add(member9);


            Principal_Clan clan1 = new Principal_Clan
            {
                ClanName = "Yamaguchi-gumi",
                FoundingLocation = "Tokyo",
                YearFounded = "01/01/1948",
                Territory = "Harujuku",
                Ethnicity = "Japanese",
                CriminalActivities = "Laundering"
            };

            Principal_Clan clan2 = new Principal_Clan
            {
                ClanName = "Sumiyoshi-kai",
                FoundingLocation = "Tokyo",
                YearFounded = "01/01/1948",
                Territory = "Roppongi",
                Ethnicity = "Japanese",
                CriminalActivities = "Smuggling"
            };

            Principal_Clan clan3 = new Principal_Clan
            {
                ClanName = "Inagawa-kai",
                FoundingLocation = "Kyoto",
                YearFounded = "01/01/1948",
                Territory = "Somewhere",
                Ethnicity = "Japanese",
                CriminalActivities = "Restaurants"
            };

            Principal_Clan clan4 = new Principal_Clan
            {
                ClanName = "Yamaguchi-gumi",
                FoundingLocation = "Kobe, Japan",
                YearFounded = "01/01/1948",
                Territory = "Kobe, Nagoya,Tokyo and Hawaii, United States",
                Ethnicity = "Burakumin",
                CriminalActivities = "Commerce",

            };

            Principal_Clan clan5 = new Principal_Clan
            {
                ClanName = "Sumiyoshi-kai",
                FoundingLocation = "Toyko, Japan",
                YearFounded = "01/01/1958",
                Territory = "Kabukichō and Ginza, Tokyo",
                Ethnicity = "Mixed",
                CriminalActivities = "Cyber Security",

            };
            Principal_Clan clan6 = new Principal_Clan()
            {
                ClanName = "Inagawa-kai",
                FoundingLocation = "Shizuoka, Japan",
                YearFounded = "01/01/1949",
                Territory = "Kantō, Yokohama, Tokyo",
                Ethnicity = "Korean, Japanese",
                CriminalActivities = "Stock Market",

            };

            clan1.Members = members1;//navigational property
            clan2.Members = members2;//navigational property


            List<Principal_Clan> clans = new List<Principal_Clan>();
            clans.Add(clan1);
            clans.Add(clan2);
            clans.Add(clan3);
            clans.Add(clan4);
            clans.Add(clan5);
            clans.Add(clan6);

            Yakuza_Hierarchy tier1 = new Yakuza_Hierarchy
            {
                LevelNumber = 1,
                EnglishEntryName = "Family Boss",
                JapaneseEntryName = "Oyabun"
            };


            Yakuza_Hierarchy tier2 = new Yakuza_Hierarchy
            {
                LevelNumber = 2,
                EnglishEntryName = "Admin",
                JapaneseEntryName = "Saiko-Kommen"
            };

            Yakuza_Hierarchy tier3 = new Yakuza_Hierarchy
            {
                LevelNumber = 3,
                EnglishEntryName = "First Lieutenant",
                JapaneseEntryName = "Wagashira"
            };

            Yakuza_Hierarchy tier4 = new Yakuza_Hierarchy
            {
                LevelNumber = 4,
                EnglishEntryName = "Second Lieutenant",
                JapaneseEntryName = "Shakeshira"
            };

            Yakuza_Hierarchy tier5 = new Yakuza_Hierarchy
            {
                LevelNumber = 5,
                EnglishEntryName = "Law Advisor",
                JapaneseEntryName = "Shirogin"
            };
            Yakuza_Hierarchy tier6 = new Yakuza_Hierarchy
            {
                LevelNumber = 6,
                EnglishEntryName = "Big Brothers",
                JapaneseEntryName = "Kyodai"
            };

            Yakuza_Hierarchy tier7 = new Yakuza_Hierarchy
            {
                LevelNumber = 7,
                EnglishEntryName = "Accountants",
                JapaneseEntryName = "Kaikai"
            };

            Yakuza_Hierarchy tier8 = new Yakuza_Hierarchy
            {
                LevelNumber = 8,
                EnglishEntryName = "Little brothers",
                JapaneseEntryName = "Shatei"
            };

            //recursive
            tier3.Parent_Yakuza_Hierarchy = tier2;
            tier4.Parent_Yakuza_Hierarchy = tier2;
            tier5.Parent_Yakuza_Hierarchy = tier3;
            tier6.Parent_Yakuza_Hierarchy = tier3;
            tier7.Parent_Yakuza_Hierarchy = tier4;
            tier8.Parent_Yakuza_Hierarchy = tier4;

            List<Yakuza_Hierarchy> tiers = new List<Yakuza_Hierarchy>();
            tiers.Add(tier1);
            tiers.Add(tier2);
            tiers.Add(tier3);
            tiers.Add(tier4);
            tiers.Add(tier5);
            tiers.Add(tier6);
            tiers.Add(tier7);
            tiers.Add(tier8);

            //create a yakuza
            Yakuza yakuza = new Yakuza
            {
                Origin = "The Kabuki-mono",
                Creation = "17th Century",
                Activities = "Criminal Activities"
            };

            yakuza.Principal_Clans = clans;//navigational property
            yakuza.Yakuza_Hierarchies = tiers;//navigational property

            //SEED THE YAKUZAS TABLE
            context.Yakuzas.Add(yakuza);
            context.SaveChanges();//sve the changes in the database


        }
    }
}
