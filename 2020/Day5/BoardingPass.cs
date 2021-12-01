using System;
using System.Collections.Generic;

namespace Day5
{
    public class BoardingPass
    {
        public int Row    { get; set; }
        public int Seat   { get; set; }

        public int SeatId => (Row * 8) + Seat;

        private static readonly int MaxRow = 127;
        private static readonly int MinRow = 0;
        private static readonly int MaxSeat = 7;
        private static readonly int MinSeat = 0;


        public static BoardingPass Parse(string input)
        {
            if (input.Length != 10)
                throw new ArgumentException("10 Characters expected");

            string rowInput = input.Substring(0, 7);
            string seatInput = input.Substring(7, 3);
            
            BoardingPass pass = new BoardingPass();
            pass.Seat = CalculateSeat(seatInput);
            pass.Row = CalculateRow(rowInput);
            return pass;
        }

        public static int CalculateRow(string input)
        {
            int min = MinRow;
            int max = MaxRow;
            foreach (char letter in input)
            {
                double temp = (max + (double)min) / 2;
                switch (letter)
                {
                    case 'F':
                        max = Convert.ToInt32(Math.Floor(temp));
                        break;
                    case 'B':
                        min = Convert.ToInt32(Math.Ceiling(temp));
                        break;
                }
            }

            return max;
        }
        

        public static int CalculateSeat(string input)
        {
            int min = MinSeat;
            int max = MaxSeat;
            foreach (char letter in input)
            {
                double temp = (max + (double)min) / 2;
                switch (letter)
                {
                    case 'L':
                        max = Convert.ToInt32(Math.Floor(temp));
                        break;
                    case 'R':
                        min = Convert.ToInt32(Math.Ceiling(temp));
                        break;
                }
            }

            if (max!=min)
                throw new Exception("Error in calculation");
            return max;
        }
    }
}