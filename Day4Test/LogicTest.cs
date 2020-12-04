using System;
using Day4;
using Xunit;

namespace Day4Test
{
    public class LogicTest
    {
        [Theory]
        [InlineData("ecl:gry pid:860033327 eyr:2020 hcl:#fffffd\nbyr:1937 iyr:2017 cid:147 hgt:183cm")]
        [InlineData("hcl:#ae17e1 iyr:2013\neyr:2024\necl:brn pid:760753108 byr:1931\nhgt:179cm")]
            public void PassportIsValid(string passport)
        {
            Assert.True(Passport.IsValid(passport));
        }
        
        [Theory]
        [InlineData("iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884\nhcl:#cfa07d byr:1929")]
        [InlineData("hcl:#cfa07d eyr:2025 pid:166559648\niyr:2011 ecl:brn hgt:59in")]
        public void PassportIsInValid(string passport)
        {
            Assert.False(Passport.IsValid(passport));
        }
    }
}