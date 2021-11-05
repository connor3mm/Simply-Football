using System;

namespace Simply_Football
{
    class Program
    {
        static void Main(string[] args)
        {
            //unitTestMembers();
            //unitTestAddPerson();
            //unitTestGetPlayers();
            //unitTestAddProfiles();
            //unitTestDeleteProfiles();
            //DummyPrinter();
        }

        static void unitTestMembers()
        {
            //tesing add player
            Player player1 = new Player(1, "connor", "coatbridge", "yestown", "ml55pz", 1997, "012599432", "098474873", "conzo@gmail.com", "striker", "doctor martin", "Sister", "0987654");
            Player player2 = new Player();
            Console.WriteLine("testing player ToString method");
            Console.WriteLine("Expected Output: 1 Connor, Coatbridge, yestown, 1997, 012599432, 098474873, conzo@gmail.com, striker, doctor martin, Sister, 0987654");
            Console.WriteLine("Actual output: " + player1);
            Console.WriteLine("Expected Output: \n0\nNo name \n0 \nno number\nno number\n no Email\n unknown\nunknown\nunknown\nno number\nunknown\nunknown\nunknown\n");
            Console.WriteLine("Actual output: " + player2);

            //testing add youth
            Youth youth1 = new Youth(1, "steve", "airdrie", "yestown", "ml6ieg", 1997, "012599432", "098474873", "tester@gmail.com", "goalkeeper", "doctor martin", "john", "father", "0987654");
            Console.WriteLine("testing player ToString method");
            Console.WriteLine("Expected Output: 1 steve, airdrie, yestown, ml6ieg, 1997, 012599432, 098474873, tester@gmail.com, goalkeeper, doctor martin, john, father, 0987654\n");
            Console.WriteLine("Actual output: " + youth1);
        }


        static void unitTestAddPerson()
        {
            //testing add player and youth through the "addplayer/addyouth" methods
            Football football = new Football();
            football.addPlayer("Connor", "springhill", "coatbridge", "ml55pz", 1997, "01236602345", "098474873", "conzo@gmail.com", "striker", "Martha", "mother", "01234565432");
            football.addPlayer("Robert", "Tophill", "Airdrie", "ml56ei", 1995, "01236602345", "098474873", "Robert@gmail.com", "goalkeeper", "john", "Father", "0456432");
            football.addYouth("Wiliam", "Bottomhill", "Motherwell", "ml2ogj", 2003, "01236602345", "098474873", "William@gmail.com", "striker", "Sam", "Joanne", "mother", "098336475");
            football.addYouth("Ross", "Bottomhill", "Motherwell", "ml2ogj", 2005, "01236602345", "098474873", "Ross@gmail.com", "midfield", "Sam", "Joanne", "mother", "098336475");
            Console.WriteLine("testing getMembers - should have 4 members \n Connor \n Robert \n Willaim \n Ross");
            Console.WriteLine(football.getMembers());
            Console.Read();
        }


        static void unitTestGetPlayers()
        {
            //testing get players from persons list
            Football football = new Football();
            football.addPlayer("Connor", "springhill", "coatbridge", "ml55pz", 1997, "01236602345", "098474873", "conzo@gmail.com", "striker", "joanne", "mother", "01234565432");
            football.addPlayer("Robert", "Tophill", "Airdrie", "ml56ei", 1995, "01236602345", "098474873", "Robert@gmail.com", "goalkeeper", "samantha", "mother", "0456432");
            football.addPlayer("steve", "airdrie", "yestown", "ml6ieg", 1997, "012599432", "098474873", "tester@gmail.com", "goalkeeper", "john", "father", "0987654");
            Console.WriteLine("testing getPlayers - should have 3 players \n Connor \n Robert \n Steve");
            Console.WriteLine(football.getPlayers());

            //testing get youth from persons list
            football.addYouth("Wiliam", "Bottomhill", "Motherwell", "ml2ogj", 2003, "012367654", "098474873", "William@gmail.com", "striker", "Sam", "Joanne", "mother", "098336475");
            football.addYouth("Ross", "Bottomhill", "Motherwell", "ml2ogj", 2005, "012364321", "098474873", "Ross@gmail.com", "midfield", "Sam", "Joanne", "mother", "-98336475");
            Console.WriteLine("testing getYouth - should have 2 youth players \nWillaim \n Ross");
            Console.WriteLine(football.getYouth());
        }


        static void unitTestAddProfiles()
        {
            // testing add profile
            Football football = new Football();
            Player player1 = new Player(1, "Connor", "coatbridge", "yestown", "ml55pz", 1997, "012599432", "098474873", "conzo@gmail.com", "striker", "doc conzo", "mother", "0987654");
            Console.WriteLine(football.addProfile(1, 5, 2, 1, 4, "decent", player1, 2));
            Console.WriteLine(football.addProfile(4, 3, 1, 5, 2, "decent", player1, 3));
            Console.WriteLine(football.addProfile(1, 2, 3, 4, 2, "decent", player1, 4));
            Console.WriteLine("Expected output: Should be 3 profiles for CONNOR season 2,3 and 4 with different skill levels with each profile");
            Console.WriteLine(football.getProfile());

            //testing profile already existing
            Console.WriteLine(football.addProfile(1, 2, 3, 4, 2, "decent", player1, 4));
            Console.WriteLine("Expected output: Error Message: This player already has a profile sheet for this season. ");
            Console.WriteLine(football.getProfile());
        }


        /// <summary>
        /// testing to delete profiles
        /// </summary>
        static void unitTestDeleteProfiles()
        {
            Football football = new Football();
            Player player1 = new Player(1, "Connor", "coatbridge", "yestown", "ml55pz", 1997, "01236602345", "098474873", "conzo@gmail.com", "striker", "doc conzo", "mother", "0987654");
            Console.WriteLine("Expected output:Profile Added --- Profile Removed --- No profiles with this name and season --- 1 profile left");
            Console.WriteLine(football.addProfile(1, 2, 3, 4, 2, "decent", player1, 2));
            Console.WriteLine(football.addProfile(3, 4, 2, 4, 1, "decent", player1, 3));
            Console.WriteLine(football.deleteProfile(player1, 2));
            Console.WriteLine(football.getProfile());
        }


        /// <summary>
        /// testing printer
        /// </summary>
        static void DummyPrinter()
        {
            //testing empty
            Football football = new Football();
            football.printProfile();

            //testing with profiles in
            Player player1 = new Player(1, "Connor", "coatbridge", "yestown", "ml55pz", 1997, "01236602345", "098474873", "conzo@gmail.com", "striker", "doc conzo", "mother", "0987654");
            Console.WriteLine(football.addProfile(1, 2, 3, 4, 2, "decent", player1, 2));
            football.printProfile();
        }
    }
}
