using System;
using Day5;
using Xunit;

namespace Day5Test
{
    public class LogicTest
    {
        [Theory]
        [InlineData("FBFBBFF", 44)]
        [InlineData("BFFFBBF", 70)]
        [InlineData("FFFBBBF", 14)]
        [InlineData("BBFFBBF", 102)]
        public void RowCalculation(string input, int result)
        {
            Assert.Equal(result, BoardingPass.CalculateRow(input));
        }
        
        [Theory]
        [InlineData("RLR", 5)]
        [InlineData("RRR", 7)]
        [InlineData("RLL", 4)]
        public void SeatCalculation(string input, int result)
        {
            Assert.Equal(result, BoardingPass.CalculateSeat(input));
        }

        [Theory]
        [InlineData("BFFFBBFRRR", 70, 7, 567)]
        [InlineData("FFFBBBFRRR", 14, 7, 119)]
        [InlineData("BBFFBBFRLL", 102, 4, 820)]
        public void BoardingPassParseCheck(string input, int row, int seat, int seatId)
        {
            BoardingPass pass = BoardingPass.Parse(input);
            
            Assert.Equal(row, pass.Row);
            Assert.Equal(seat, pass.Seat);
            Assert.Equal(seatId, pass.SeatId);
        }

    }
}