using System;
using System.Collections.Generic;
using System.Linq;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");

            List<BoardingPass> allCombinations = new List<BoardingPass>();
            for (int i = 0; i < 128; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    allCombinations.Add(new BoardingPass()
                    {
                        Row = i,
                        Seat = j
                    }); 
                }
            }
            int highestSeatId = 0;
            List<BoardingPass> passes = new List<BoardingPass>();
            foreach (string line in lines)
            {
                BoardingPass temp = BoardingPass.Parse(line);
                if (temp.SeatId > highestSeatId)
                {
                    highestSeatId = temp.SeatId;
                }

                passes.Add(temp);
                allCombinations.RemoveAll(x => x.Row == temp.Row && x.Seat == temp.Seat);
            }
            Console.WriteLine("Highest SeatId : " + highestSeatId);
            foreach (BoardingPass pass in allCombinations)
            {
                if(passes.Any(x => x.SeatId == pass.SeatId - 1) && passes.Any(x => x.SeatId == pass.SeatId + 1))
                    Console.WriteLine($"Row {pass.Row}, Seat {pass.Seat}, SeatId {pass.SeatId}");
            }
        }
    }
}