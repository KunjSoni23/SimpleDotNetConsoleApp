/*
Name: Soni Kunj Mayurkumar
Student ID: 991591881
Date of Submission: 17 February 2021
Topic: Assignment 1
Guided by: Gursharan Singh Tatla
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace A1KunjSoni
{
    //class BaseballPlayer is inheriting from Player class
    class BaseballPlayer : Player
    {
        //fields and getter & setter using property
        private int _runs;

        public int Runs
        {
            get { return _runs; }
            set { _runs = value; }
        }

        private int _homeRuns;

        public int HomeRuns
        {
            get { return _homeRuns; }
            set { _homeRuns = value; }
        }

        //parametrized constructor
        public BaseballPlayer(PlayerType playerType, int playerId, string playerName, string teamName, int gamesPlayed, int runs, int homeRuns) : base(playerType, playerId, playerName, teamName, gamesPlayed)
        {
            Runs = runs;
            HomeRuns = homeRuns;
        }

        //Points method
        public override int Points()
        {
            return (Runs - HomeRuns) + (2 * HomeRuns);
        }

        //ToString method
        public override string ToString()
        {
            return base.ToString() + $"{Runs,20} {HomeRuns,20} {Points(),20}";
        }

    }
}
