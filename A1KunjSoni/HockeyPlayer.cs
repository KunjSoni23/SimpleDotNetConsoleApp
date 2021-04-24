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
    //Class HockeyPlayer is innheriting from Player class
    class HockeyPlayer : Player
    {
        //fields and getter & setter using property
        private int _assists;

        public int Assists
        {
            get { return _assists; }
            set { _assists = value; }
        }

        private int _goals;

        public int Goals
        {
            get { return _goals; }
            set { _goals = value; }
        }

        //parametrized constructor
        public HockeyPlayer(PlayerType playerType, int playerId, string playerName, string teamName, int gamesPlayed, int assists, int goals) : base(playerType, playerId,  playerName,  teamName,  gamesPlayed)
        {
            Assists = assists;
            Goals = goals;
        }

        //Points method
        public override int Points()
        {
            return Assists + (2 * Goals);
        }
        
        //ToString method
        public override string ToString()
        {
            return base.ToString() + $"{Assists, 20} {Goals, 20} {Points(),20}";
        }

    }
}
