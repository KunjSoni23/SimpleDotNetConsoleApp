/*
Name: Soni Kunj Mayurkumar
Student ID: 991591881
Date of Submission: 17 February 2021
Topic: Assignment 1
Guided by: Gursharan Singh Tatla
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace A1KunjSoni
{
    class Program
    {
        //initialization of List
        static  List<Player> myList = new List<Player>();

        //input method for Homepage menu
        public static void Input()
        {
            //inbuilt method to apply color to text in console.
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n\n\t\tASSIGNMENT-1 by KUNJ SONI\n\n\n");
            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n\n");
            Console.WriteLine("\t\t1 - Add Player");
            Console.WriteLine("\t\t2 - Edit Player");
            Console.WriteLine("\t\t3 - Delete Player");
            Console.WriteLine("\t\t4 - View Players");
            Console.WriteLine("\t\t5 - Search Player");
            Console.WriteLine("\t\t6 - Exit\n\n");

            bool condition = true;

            while (condition)
            {
                Console.Write("Enter your choice: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        AddingPlayer();
                        condition = false;
                        break;
                    case "2":
                        EditingPlayer();
                        condition = false;
                        break;
                    case "3":
                        DeletingPlayers();
                        condition = false;
                        break;
                    case "4":
                        ViewPlayers();
                        condition = false;
                        break;
                    case "5":
                        SearchingPlayers();
                        condition = false;
                        break;
                    case "6":
                        condition = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input.Please Try again\n");
                        condition = true;
                        break;
                }

            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////    ADDING METHODS ///////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //AddingPlayer method
        public static void AddingPlayer()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nAdd New Player: \n");
            Console.WriteLine("\t\t1 - Add Hockey Player");
            Console.WriteLine("\t\t2 - Add Basketball Player");
            Console.WriteLine("\t\t3 - Add Baseball Player");
            Console.WriteLine("\t\t4 - Back to Main Menu\n");

            bool condition = true;

            while (condition)
            {
                Console.Write("Enter your choice: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        AddingHockeyPlayer();
                        condition = false;
                        break;
                    case "2":
                        AddingBasketBallPlayer();
                        condition = false;
                        break;
                    case "3":
                        AddingBaseballPlayer();
                        condition = false;
                        break;
                    case "4":
                        Input();
                        condition = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input.Please Try again\n");
                        condition = true;
                        break;
                }

            }

        }

        //AddingHockeyPlayer method
        public static void AddingHockeyPlayer()
        {
            Console.WriteLine("\nAdding Hockey Player\n");
            Console.Write("Enter Player name: ");
            string hockeyPlayer = Console.ReadLine();

            while(string.IsNullOrWhiteSpace(hockeyPlayer)){
                Console.WriteLine("Invalid Input.Please Try again\n");
                Console.Write("Enter Player name: ");
                hockeyPlayer = Console.ReadLine();
            }

            Console.Write("Enter Team name: ");
            string hockeyTeamName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(hockeyTeamName))
            {
                Console.WriteLine("Invalid Input.Please Try again\n");
                Console.Write("Enter Team name: ");
                hockeyTeamName = Console.ReadLine();
            }

            Console.Write("Enter Games Played: ");
            int hockeyGamePlayed;

            bool gamePlayedIsNumeric = Int32.TryParse(Console.ReadLine(),out hockeyGamePlayed);

            while (!gamePlayedIsNumeric)
            {
                Console.WriteLine("Invalid Input.Please Try again\n");
                Console.Write("Enter Games Played: ");
                gamePlayedIsNumeric = Int32.TryParse(Console.ReadLine(), out hockeyGamePlayed);
            }

            Console.Write("Enter Assists: ");
            int hockeyAssists;

            bool assistsIsNumeric = Int32.TryParse(Console.ReadLine(), out hockeyAssists);

            while (!assistsIsNumeric)
            {
                Console.WriteLine("Invalid Input.Please Try again\n");
                Console.Write("Enter Assists: ");
                assistsIsNumeric = Int32.TryParse(Console.ReadLine(), out hockeyAssists);
            }

            Console.Write("Enter Goals: ");
            int hockeyGoals;

            bool goalsIsNumeric = Int32.TryParse(Console.ReadLine(), out hockeyGoals);

            while (!goalsIsNumeric)
            {
                Console.WriteLine("Invalid Input.Please Try again\n");
                Console.Write("Enter Goals: ");
                goalsIsNumeric = Int32.TryParse(Console.ReadLine(), out hockeyGoals);
            }

            Player newHockePlayer = new HockeyPlayer(PlayerType.HockeyPlayer, myList.Count+1, hockeyPlayer, hockeyTeamName, hockeyGamePlayed, hockeyAssists, hockeyGoals);
            myList.Add(newHockePlayer);

            Console.WriteLine("\nNew Player Added.\n\nView All HockeyPlayers: \n\n");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine($"{"Player Type", -20} {"Player Id",10} {"Player Name",-20} {"Team name",-20} {"Games Played",20} {"Assists",20} {"Goals",20} {"Points",20}\n");

            foreach (var i in myList)
            {
                if (i.PlayerType == PlayerType.HockeyPlayer)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;

            AddingPlayer();
        }
        
        //AddingBasketBallPlayer method
        public static void AddingBasketBallPlayer()
        {
            Console.WriteLine("\nAdding Basketball Player\n");
            Console.Write("Enter Player name: ");
            string basketballPlayer = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(basketballPlayer))
            {
                Console.WriteLine("Invalid Input.Please Try again\n");
                Console.Write("Enter Player name: ");
                basketballPlayer = Console.ReadLine();
            }

            Console.Write("Enter Team name: ");
            string basketballTeamName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(basketballTeamName))
            {
                Console.WriteLine("Invalid Input.Please Try again\n");
                Console.Write("Enter Team name: ");
                basketballTeamName = Console.ReadLine();
            }

            Console.Write("Enter Games Played: ");
            int basketballGamesPlayed;

            bool gamePlayedIsNumeric = Int32.TryParse(Console.ReadLine(),out basketballGamesPlayed);
            while (!gamePlayedIsNumeric)
            {
                Console.WriteLine("Invalid Input.Please Try again\n");
                Console.Write("Enter Games Played: ");
                gamePlayedIsNumeric = Int32.TryParse(Console.ReadLine(), out basketballGamesPlayed);
            }

            Console.Write("Enter Field Goals: ");
            int basketballFieldGoals;

            bool fieldGoalsIsNumeric = Int32.TryParse(Console.ReadLine(),out basketballFieldGoals);

            while (!fieldGoalsIsNumeric)
            {
                Console.WriteLine("Invalid Input.Please Try again\n");
                Console.Write("Enter Field Goals: ");
                fieldGoalsIsNumeric = Int32.TryParse(Console.ReadLine(), out basketballFieldGoals);
            }

            Console.Write("Enter 3-Pointers: ");
            int basketballThreePointers;

            bool threePointersIsNumeric = Int32.TryParse(Console.ReadLine(),out basketballThreePointers);

            while (!threePointersIsNumeric)
            {
                Console.WriteLine("Invalid Input.Please Try again\n");
                Console.Write("Enter 3-Pointers: ");
                threePointersIsNumeric = Int32.TryParse(Console.ReadLine(), out basketballThreePointers);
            }

            Player newBasketBallPlayer = new BasketballPlayer(PlayerType.BasketballPlayer, myList.Count + 1, basketballPlayer, basketballTeamName, basketballGamesPlayed, basketballFieldGoals, basketballThreePointers);
            myList.Add(newBasketBallPlayer);

            Console.WriteLine("\nNew Player Added.\n\nView All BasketBallPlayer: \n\n");

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"{"Player Type",-20} {"Player ID",10} {"Player Name",-20} {"Team Name",-20} {"Games Played",20} {"Field Goals",20} {"3-Pointers",20} {"Points",20}\n");

            foreach (var i in myList)
            {
                if (i.PlayerType == PlayerType.BasketballPlayer)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;

            AddingPlayer();
            
        }

        //AddingBaseballPlayer method
        public static void AddingBaseballPlayer()
        {
            Console.WriteLine("\nAdding Baseball Player\n");
            Console.Write("Enter Player Name: ");
            string baseballPlayer = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(baseballPlayer))
            {
                Console.WriteLine("Invalid Input.Please Try again\n");
                Console.Write("Enter Player Name: ");
                baseballPlayer = Console.ReadLine();
            }

            Console.Write("Enter Team name: ");
            string baseballTeamName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(baseballTeamName))
            {
                Console.WriteLine("Invalid Input.Please Try again\n");
                Console.Write("Enter Team name: ");
                baseballTeamName = Console.ReadLine();
            }

            Console.Write("Enter Games Played: ");
            int baseballGamesPlayed;

            bool gamePlayedIsNumeric = Int32.TryParse(Console.ReadLine(), out baseballGamesPlayed);
            while (!gamePlayedIsNumeric)
            {
                Console.WriteLine("Invalid Input.Please Try again\n");
                Console.Write("Enter Games Played: ");
                gamePlayedIsNumeric = Int32.TryParse(Console.ReadLine(), out baseballGamesPlayed);
            }


            Console.Write("Enter Runs: ");
            int baseballRuns;

            bool runsIsNumeric = Int32.TryParse(Console.ReadLine(), out baseballRuns);

            while (!runsIsNumeric)
            {
                Console.WriteLine("Invalid Input.Please Try again\n");
                Console.Write("Enter Runs: ");
                runsIsNumeric = Int32.TryParse(Console.ReadLine(), out baseballRuns);
            }

            Console.Write("Enter Home Runs: ");
            int baseballHomeRuns;

            bool homeRunsIsNumeric = Int32.TryParse(Console.ReadLine(), out baseballHomeRuns);

            while (!homeRunsIsNumeric)
            {
                Console.WriteLine("Invalid Input.Please Try again\n");
                Console.Write("Enter Home Runs: ");
                homeRunsIsNumeric = Int32.TryParse(Console.ReadLine(), out baseballHomeRuns);

            }

            Player newBaseballPlayer = new BaseballPlayer(PlayerType.BaseballPlayer, myList.Count + 1, baseballPlayer, baseballTeamName, baseballGamesPlayed, baseballRuns, baseballHomeRuns);
            myList.Add(newBaseballPlayer);

            Console.WriteLine("\nNew Player Added.\n\nView All Baseball Player: \n\n");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"{"Player Type",-20} {"Player ID",10} {"Player Name",-20} {"Team Name",-20} {"Games Played",20} {"Runs",20} {"Home Runs",20} {"Points",20}\n");

            foreach (var i in myList)
            {

                if (i.PlayerType == PlayerType.BaseballPlayer)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;

            AddingPlayer();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////    EDITING METHODS //////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //EditingPlayer method
        public static void EditingPlayer()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nEdit Player: \n");
            Console.WriteLine("\t\t1 - Edit Hockey Player");
            Console.WriteLine("\t\t2 - Edit Basketball Player");
            Console.WriteLine("\t\t3 - Edit Baseball Player");
            Console.WriteLine("\t\t4 - Back to Main Menu\n");

            bool condition = true;

            while (condition)
            {

                Console.Write("Enter your choice: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        EditingHockeyPlayer();
                        condition = false;
                        break;
                    case "2":
                        EditingBasketBallPlayer();
                        condition = false;
                        break;
                    case "3":
                        EditingBaseballPlayer();
                        condition = false;
                        break;
                    case "4":
                        Input();
                        condition = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input.Please Try again\n");
                        condition = true;
                        break;
                }

            }

        }

        //EditingHockeyPlayer method
        public static void EditingHockeyPlayer()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine($"{"Player Type",-20} {"Player Id",10} {"Player Name",-20} {"Team name",-20} {"Games Played",20} {"Assists",20} {"Goals",20} {"Points",20}\n");

            foreach (var i in myList)
            {
                if (i.PlayerType == PlayerType.HockeyPlayer)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nEditing Hockey Player\n");
            Console.WriteLine("Enter ID of player you want to edit: ");
            int id;
            bool idIsNumeric = Int32.TryParse(Console.ReadLine(),out id);

            while (!idIsNumeric)
            {
                Console.WriteLine("Invalid Input.Please Try again\n");
                Console.WriteLine("Enter ID of player you want to edit: ");
                idIsNumeric = Int32.TryParse(Console.ReadLine(), out id);
            }

            if (id <= myList.Count && myList[id - 1].PlayerType == PlayerType.HockeyPlayer)

            {
                Console.Write("Enter Player's new name: ");
                string hockeyPlayer = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(hockeyPlayer))
                {
                    Console.WriteLine("Invalid Input.Please Try again\n");
                    Console.Write("Enter Player's new name: ");
                    hockeyPlayer = Console.ReadLine();
                }

                Console.Write("Enter new Team name: ");
                string hockeyTeamname = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(hockeyTeamname))
                {
                    Console.WriteLine("Invalid Input.Please Try again\n");
                    Console.Write("Enter new Team name: ");
                    hockeyTeamname = Console.ReadLine();
                }

                Console.Write("Enter Games Played: ");
                int hockeyGamePlayed;

                bool gamePlayedIsNumeric = Int32.TryParse(Console.ReadLine(), out hockeyGamePlayed);

                while (!gamePlayedIsNumeric)
                {
                    Console.WriteLine("Invalid Input.Please Try again\n");
                    Console.Write("Enter Games Played: ");
                    gamePlayedIsNumeric = Int32.TryParse(Console.ReadLine(), out hockeyGamePlayed);
                }

                Console.Write("Enter Assists: ");
                int hockeyAssists;

                bool assistsIsNumeric = Int32.TryParse(Console.ReadLine(), out hockeyAssists);

                while (!assistsIsNumeric)
                {
                    Console.WriteLine("Invalid Input.Please Try again\n");
                    Console.Write("Enter Assists: ");
                    assistsIsNumeric = Int32.TryParse(Console.ReadLine(), out hockeyAssists);
                }

                Console.Write("Enter Goals: ");
                int hockeyGoals;

                bool goalsIsNumeric = Int32.TryParse(Console.ReadLine(), out hockeyGoals);

                while (!goalsIsNumeric)
                {
                    Console.WriteLine("Invalid Input.Please Try again\n");
                    Console.Write("Enter Goals: ");
                    goalsIsNumeric = Int32.TryParse(Console.ReadLine(), out hockeyGoals);
                }

                myList[id - 1] = new HockeyPlayer(PlayerType.HockeyPlayer, id, hockeyPlayer, hockeyTeamname, hockeyGamePlayed, hockeyAssists, hockeyGoals);

                Console.WriteLine("\nPlayer with ID = " + id + " updated\n");

                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($"{"Player Type",-20} {"Player Id",10} {"Player Name",-20} {"Team name",-20} {"Games Played",20} {"Assists",20} {"Goals",20} {"Points",20}\n");


                foreach (var i in myList)
                {
                    if (i.PlayerType == PlayerType.HockeyPlayer)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else {
                Console.WriteLine("Invalid Input! We dont have that id in Hockey Players Table");
                EditingHockeyPlayer();
            }
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;

            EditingPlayer();
            
        }

        //EditingBasketballPlayer Method
        public static void EditingBasketBallPlayer()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"{"Player Type",-20} {"Player ID",10} {"Player Name",-20} {"Team Name",-20} {"Games Played",20} {"Field Goals",20} {"3-Pointers",20} {"Points",20}\n");

            foreach (var i in myList)
            {
                if (i.PlayerType == PlayerType.BasketballPlayer)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nEditing Basketball Player\n");
            
            Console.WriteLine("Enter ID of player you want to edit: ");
            int id;

            bool idIsNumeric = Int32.TryParse(Console.ReadLine(), out id);

            while (!idIsNumeric)
            {
                Console.WriteLine("Invalid Input.Please Try again\n");
                Console.WriteLine("Enter ID of player you want to edit: ");
                idIsNumeric = Int32.TryParse(Console.ReadLine(), out id);
            }

            if (id <= myList.Count && myList[id - 1].PlayerType == PlayerType.BasketballPlayer)
            {
                Console.Write("Enter Player's new name: ");
                string basketballPlayer = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(basketballPlayer))
                {
                    Console.WriteLine("Invalid Input.Please Try again\n");
                    Console.Write("Enter Player's new name: ");
                    basketballPlayer = Console.ReadLine();
                }

                Console.Write("Enter New Team name: ");
                string basketballTeamName = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(basketballTeamName))
                {
                    Console.WriteLine("Invalid Input.Please Try again\n");
                    Console.Write("Enter New Team name: ");
                    basketballTeamName = Console.ReadLine();
                }

                Console.Write("Enter Games Played: ");
                int basketballGamesPlayed;

                bool gamePlayedIsNumeric = Int32.TryParse(Console.ReadLine(), out basketballGamesPlayed);
                while (!gamePlayedIsNumeric)
                {
                    Console.WriteLine("Invalid Input.Please Try again\n");
                    Console.Write("Enter Games Played: ");
                    gamePlayedIsNumeric = Int32.TryParse(Console.ReadLine(), out basketballGamesPlayed);
                }

                Console.Write("Enter Field Goals: ");
                int basketballFieldGoals;

                bool fieldGoalsIsNumeric = Int32.TryParse(Console.ReadLine(), out basketballFieldGoals);

                while (!fieldGoalsIsNumeric)
                {
                    Console.WriteLine("Invalid Input.Please Try again\n");
                    Console.Write("Enter Field Goals: ");
                    fieldGoalsIsNumeric = Int32.TryParse(Console.ReadLine(), out basketballFieldGoals);
                }

                Console.Write("Enter 3-Pointers: ");
                int basketballThreePointers;

                bool threePointersIsNumeric = Int32.TryParse(Console.ReadLine(), out basketballThreePointers);

                while (!threePointersIsNumeric)
                {
                    Console.WriteLine("Invalid Input.Please Try again\n");
                    Console.Write("Enter 3-Pointers: ");
                    threePointersIsNumeric = Int32.TryParse(Console.ReadLine(), out basketballThreePointers);
                }

                myList[id - 1] = new BasketballPlayer(PlayerType.BasketballPlayer, id, basketballPlayer, basketballTeamName, basketballGamesPlayed, basketballFieldGoals, basketballThreePointers);

                Console.WriteLine("\nPlayer with ID = " + id + " updated\n");
                Console.ForegroundColor = ConsoleColor.Red;


                Console.WriteLine($"{"Player Type",-20} {"Player ID",10} {"Player Name",-20} {"Team Name",-20} {"Games Played",20} {"Field Goals",20} {"3-Pointers",20} {"Points",20}\n");

                foreach (var i in myList)
                {
                    if (i.PlayerType == PlayerType.BasketballPlayer)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Input! We dont have that id in Basketball Players Table");
                EditingBasketBallPlayer();
            }
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;

            EditingPlayer();
        }

        //EditingBaseballPlayer method
        public static void EditingBaseballPlayer()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"{"Player Type",-20} {"Player ID",10} {"Player Name",-20} {"Team Name",-20} {"Games Played",20} {"Runs",20} {"Home Runs",20} {"Points",20}\n");

            foreach (var i in myList)
            {

                if (i.PlayerType == PlayerType.BaseballPlayer)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nEditing Baseball Player\n");
            Console.WriteLine("Enter ID of player you want to edit: ");
            int id;

            bool idIsNumeric = Int32.TryParse(Console.ReadLine(), out id);

            while (!idIsNumeric)
            {
                Console.WriteLine("Invalid Input.Please Try again\n");
                Console.WriteLine("Enter ID of player you want to edit: ");
                idIsNumeric = Int32.TryParse(Console.ReadLine(), out id);
            }

            if (id <= myList.Count && myList[id - 1].PlayerType == PlayerType.BaseballPlayer)

            {
                Console.Write("Enter Player's new name: ");
                string baseballPlayer = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(baseballPlayer))
                {
                    Console.WriteLine("Invalid Input.Please Try again\n");
                    Console.Write("Enter Player's new name: ");
                    baseballPlayer = Console.ReadLine();
                }

                Console.Write("Enter Team name: ");
                string baseballTeamName = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(baseballTeamName))
                {
                    Console.WriteLine("Invalid Input.Please Try again\n");
                    Console.Write("Enter new Team name: ");
                    baseballTeamName = Console.ReadLine();
                }

                Console.Write("Enter Games Played: ");
                int baseballGamesPlayed;

                bool gamePlayedIsNumeric = Int32.TryParse(Console.ReadLine(), out baseballGamesPlayed);
                while (!gamePlayedIsNumeric)
                {
                    Console.WriteLine("Invalid Input.Please Try again\n");
                    Console.Write("Enter Games Played: ");
                    gamePlayedIsNumeric = Int32.TryParse(Console.ReadLine(), out baseballGamesPlayed);
                }


                Console.Write("Enter Runs: ");
                int baseballRuns;

                bool runsIsNumeric = Int32.TryParse(Console.ReadLine(), out baseballRuns);

                while (!runsIsNumeric)
                {
                    Console.WriteLine("Invalid Input.Please Try again\n");
                    Console.Write("Enter Runs: ");
                    runsIsNumeric = Int32.TryParse(Console.ReadLine(), out baseballRuns);
                }



                Console.Write("Enter HomeRuns: ");
                int baseballHomeRuns;

                bool homeRunsIsNumeric = Int32.TryParse(Console.ReadLine(), out baseballHomeRuns);

                while (!homeRunsIsNumeric)
                {
                    Console.WriteLine("Invalid Input.Please Try again\n");
                    Console.Write("Enter Home Runs: ");
                    homeRunsIsNumeric = Int32.TryParse(Console.ReadLine(), out baseballHomeRuns);

                }


                myList[id - 1] = new BaseballPlayer(PlayerType.BaseballPlayer, id, baseballPlayer, baseballTeamName, baseballGamesPlayed, baseballRuns, baseballHomeRuns);


                Console.WriteLine("\nPlayer with ID = " + id + " updated\n");

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine($"{"Player Type",-20} {"Player ID",10} {"Player Name",-20} {"Team Name",-20} {"Games Played",20} {"Runs",20} {"Home Runs",20} {"Points",20}\n");

                foreach (var i in myList)
                {

                    if (i.PlayerType == PlayerType.BaseballPlayer)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Input! We dont have that id in Baseball Players Table");
                EditingBaseballPlayer();
            }
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;

            EditingPlayer();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////// DELETE METHOD ////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //DeletingPlayer method
        public static void DeletingPlayers()
        {
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("\nDelete Player: \n");
            Console.WriteLine("\t\t1 - Delete Hockey Player");
            Console.WriteLine("\t\t2 - Delete Basketball Player");
            Console.WriteLine("\t\t3 - Delete Baseball Player");
            Console.WriteLine("\t\t4 - Back to Main Menu\n");

            bool condition = true;

            while (condition)
            {

                Console.Write("Enter your choice: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        DeletingHockeyPlayer();
                        condition = false;
                        break;
                    case "2":
                        DeletingBasketBallPlayer();
                        condition = false;
                        break;
                    case "3":
                        DeletingBaseballPlayer();
                        condition = false;
                        break;
                    case "4":
                        Input();
                        condition = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input.Please Try again\n");
                        condition = true;
                        break;
                }

            }

        }

        //DeletingHockeyPlayer method
        public static void DeletingHockeyPlayer()
        {
            Console.WriteLine("View All HockeyPlayers: \n");

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine($"{"Player Type",-20} {"Player Id",10} {"Player Name",-20} {"Team name",-20} {"Games Played",20} {"Assists",20} {"Goals",20} {"Points",20}\n");

            foreach (var i in myList)
            {
                if (i.PlayerType == PlayerType.HockeyPlayer)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nDeleting Hockey Player\n");
            Console.WriteLine("Enter ID of player you want to delete: (-1 to exit) ");
            int id;

            bool idIsNumeric = Int32.TryParse(Console.ReadLine(), out id);

            while (!idIsNumeric)
            {
                Console.WriteLine("Invalid Input.Please Try again\n");
                Console.WriteLine("Enter ID of player you want to edit: ");
                idIsNumeric = Int32.TryParse(Console.ReadLine(), out id);
            }

            int m = myList.FindIndex(i => i.PlayerId == id);

            if(m != -1 && myList[m].PlayerType == PlayerType.HockeyPlayer)
            {
                myList.RemoveAt(m);                

                Console.WriteLine("\nPlayer with ID = " + id + " deleted\n");

                Console.WriteLine("View All HockeyPlayers: \n");

                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($"{"Player Type",-20} {"Player Id",10} {"Player Name",-20} {"Team name",-20} {"Games Played",20} {"Assists",20} {"Goals",20} {"Points",20}\n");


                foreach (var i in myList)
                {
                    if (i.PlayerType == PlayerType.HockeyPlayer)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            //if there will be no data and by mistake user enter into list then they can press -1 to exit
            else if (id == -1)
            {
                DeletingPlayers();
            }
            else
            {
                Console.WriteLine("Invalid Input! We dont have that id in Hockey Players Table");
                DeletingHockeyPlayer();
            }
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;

            DeletingPlayers();

        }

        //DeletingBasketballPlayer method
        public static void DeletingBasketBallPlayer()
        {
            Console.WriteLine("View All HockeyPlayers: \n");

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"{"Player Type",-20} {"Player ID",10} {"Player Name",-20} {"Team Name",-20} {"Games Played",20} {"Field Goals",20} {"3-Pointers",20} {"Points",20}\n");

            foreach (var i in myList)
            {
                if (i.PlayerType == PlayerType.BasketballPlayer)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nDeleting Basketball Player\n");

            Console.WriteLine("Enter ID of player you want to delete: (-1 to exit) ");
            int id;

            bool idIsNumeric = Int32.TryParse(Console.ReadLine(), out id);

            while (!idIsNumeric)
            {
                Console.WriteLine("Invalid Input.Please Try again\n");
                Console.WriteLine("Enter ID of player you want to edit: ");
                idIsNumeric = Int32.TryParse(Console.ReadLine(), out id);
            }

            int m = myList.FindIndex(i => i.PlayerId == id);

            if (m != -1 && myList[m].PlayerType == PlayerType.BasketballPlayer)
            {
                myList.RemoveAt(m);

                Console.WriteLine("\nPlayer with ID = " + id + " deleted\n");

                Console.WriteLine("View All BasketballPlayer: \n");
                Console.ForegroundColor = ConsoleColor.Red;


                Console.WriteLine($"{"Player Type",-20} {"Player ID",10} {"Player Name",-20} {"Team Name",-20} {"Games Played",20} {"Field Goals",20} {"3-Pointers",20} {"Points",20}\n");

                foreach (var i in myList)
                {
                    if (i.PlayerType == PlayerType.BasketballPlayer)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            //if there will be no data and by mistake user enter into list then they can press -1 to exit
            else if (id == -1)
            {
                DeletingPlayers();
            }
            else
            {
                Console.WriteLine("Invalid Input! We dont have that id in Basketball Players Table");
                DeletingBasketBallPlayer();
            }
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;

            DeletingPlayers();
        }

        //DeletingBaseballPlayer method
        public static void DeletingBaseballPlayer()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"{"Player Type",-20} {"Player ID",10} {"Player Name",-20} {"Team Name",-20} {"Games Played",20} {"Runs",20} {"Home Runs",20} {"Points",20}\n");

            foreach (var i in myList)
            {

                if (i.PlayerType == PlayerType.BaseballPlayer)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nDeleting Baseball Player\n");
            Console.WriteLine("Enter ID of player you want to delete: (-1 to exit) ");
            int id;

            bool idIsNumeric = Int32.TryParse(Console.ReadLine(), out id);

            while (!idIsNumeric)
            {
                Console.WriteLine("Invalid Input.Please Try again\n");
                Console.WriteLine("Enter ID of player you want to edit: ");
                idIsNumeric = Int32.TryParse(Console.ReadLine(), out id);
            }

            int m = myList.FindIndex(i => i.PlayerId == id);

            if (m != -1 && myList[m].PlayerType == PlayerType.BaseballPlayer)
            {
                myList.RemoveAt(m);

                Console.WriteLine("\nPlayer with ID = " + id + " deleted\n");

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine($"{"Player Type",-20} {"Player ID",10} {"Player Name",-20} {"Team Name",-20} {"Games Played",20} {"Runs",20} {"Home Runs",20} {"Points",20}\n");

                foreach (var i in myList)
                {

                    if (i.PlayerType == PlayerType.BaseballPlayer)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            //if there will be no data and by mistake user enter into list then they can press -1 to exit
            else if (id == -1)
            {
                DeletingPlayers();
            }
            else
            {
                Console.WriteLine("Invalid Input! We dont have that id in Baseball Players Table");
                DeletingBaseballPlayer();
            }
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;

            DeletingPlayers();
        }



        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////    VIEW METHOD //////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //Viewplayer method
        public static void ViewPlayers()
        {

            Console.WriteLine("\nView All Players: \n\n");

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Hockey Players: \n");
            Console.WriteLine($"{"Player Type",-20} {"Player Id",10} {"Player Name",-20} {"Team name",-20} {"Games Played",20} {"Assists",20} {"Goals",20} {"Points",20}\n");

            foreach (var i in myList)
            {

                if (i.PlayerType == PlayerType.HockeyPlayer)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\n\nBasketball Players: \n");
            Console.WriteLine($"{"Player Type",-20} {"Player ID",10} {"Player Name",-20} {"Team Name",-20} {"Games Played",20} {"Field Goals",20} {"3-Pointers",20} {"Points",20}\n");

            foreach (var i in myList)
            {

                if (i.PlayerType == PlayerType.BasketballPlayer)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\n\nBaseball Players: \n");
            Console.WriteLine($"{"Player Type",-20} {"Player ID",10} {"Player Name",-20} {"Team Name",-20} {"Games Played",20} {"Runs",20} {"Home Runs",20} {"Points",20}\n");

            foreach (var i in myList)
            {

                if (i.PlayerType == PlayerType.BaseballPlayer)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;

            Input();

        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////// SEARCH METHOD ////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        //SearchingPlayer method
        public static void SearchingPlayers()
        {
            Console.WriteLine("\nSearch Players by Name. Partial matches can fetch results. \n");

            Console.Write("Enter player name to search: ");
            string searchedName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(searchedName))
            {
                Console.WriteLine("Invalid Input.Please Try again\n");
                Console.Write("Enter player name to search: ");
                searchedName = Console.ReadLine();
            }

            Console.WriteLine("\nView All Players: \n");


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nHockey Player: \n");
            Console.WriteLine($"{"Player Type",-20} {"Player Id",10} {"Player Name",-20} {"Team name",-20} {"Games Played",20} {"Assists",20} {"Goals",20} {"Points",20}\n");


            foreach (var i in myList)
            {
                if (i.PlayerName.Contains(searchedName))
                {
                    if (i.PlayerType == PlayerType.HockeyPlayer)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\n\n\nBasketball Player: \n");
            Console.WriteLine($"{"Player Type",-20} {"Player ID",10} {"Player Name",-20} {"Team Name",-20} {"Games Played",20} {"Field Goals",20} {"3-Pointers",20} {"Points",20}\n");


            foreach (var i in myList)
            {
                if (i.PlayerName.Contains(searchedName))
                {
                    if (i.PlayerType == PlayerType.BasketballPlayer)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\n\n\nBaseball Player: \n");
            Console.WriteLine($"{"Player Type",-20} {"Player ID",10} {"Player Name",-20} {"Team Name",-20} {"Games Played",20} {"Runs",20} {"Home Runs",20} {"Points",20}\n");

            foreach (var i in myList)
            {
                if (i.PlayerName.Contains(searchedName))
                {
                    if (i.PlayerType == PlayerType.BaseballPlayer)
                    {

                        Console.WriteLine(i);
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Input();

        }

        //main method
        static void Main(string[] args)
        {
            //Addition of hockey player
            Player hp1 = new HockeyPlayer(PlayerType.HockeyPlayer, myList.Count + 1, "Mitchell Marner", "Maple Leafs", 9, 5, 8);
            myList.Add(hp1);
            Player hp2 = new HockeyPlayer(PlayerType.HockeyPlayer, myList.Count + 1, "Conner McDavid", "Edmonton Oilers", 9, 5, 9);
            myList.Add(hp2);

            //Addition of Basketball Player
            Player b1 = new HockeyPlayer(PlayerType.BasketballPlayer, myList.Count + 1, "Kyle Lowry", "Raptors", 15, 18, 4);
            myList.Add(b1);
            Player b2 = new HockeyPlayer(PlayerType.BasketballPlayer, myList.Count + 1, "Avery Bradley", "Heat", 8, 16, 2);
            myList.Add(b2);


            //Addition of Baseball Player
            Player ba1 = new HockeyPlayer(PlayerType.BaseballPlayer, myList.Count + 1, "Alejandro Kirk", "Blue Jays", 9, 4, 1);
            myList.Add(ba1);
            Player ba2 = new HockeyPlayer(PlayerType.BaseballPlayer, myList.Count + 1, "Kyle Higashioka", "Yankees", 16, 7, 4);
            myList.Add(ba2);

            //calling of Input method for HomePage of assignment
            Input();
        }

    }
}
