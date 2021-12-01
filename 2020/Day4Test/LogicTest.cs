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
            Assert.True(Passport.IsValidPart1(passport));
        }
        
        [Theory]
        [InlineData("iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884\nhcl:#cfa07d byr:1929")]
        [InlineData("hcl:#cfa07d eyr:2025 pid:166559648\niyr:2011 ecl:brn hgt:59in")]
        public void PassportIsInValid(string passport)
        {
            Assert.False(Passport.IsValidPart1(passport));
        }
        
        [Theory]
        [InlineData("eyr:1972 cid:100\nhcl:#18171d ecl:amb hgt:170 pid:186cm iyr:2018 byr:1926")]
        [InlineData("iyr:2019\nhcl:#602927 eyr:1967 hgt:170cm\necl:grn pid:012533040 byr:1946")]
        [InlineData("hcl:dab227 iyr:2012\necl:brn hgt:182cm pid:021572410 eyr:2020 byr:1992 cid:277")]
        [InlineData("hgt:59cm ecl:zzz\neyr:2038 hcl:74454a iyr:2023\npid:3556412378 byr:2007")]
        public void PassportIsInValidPart2(string input)
        {
            Passport passport = Passport.Parse(input);
            Assert.False(passport.IsValid());
        }
        
        [Theory]
        [InlineData("pid:087499704 hgt:74in ecl:grn iyr:2012 eyr:2030 byr:1980\nhcl:#623a2f")]
        [InlineData("eyr:2029 ecl:blu cid:129 byr:1989\niyr:2014 pid:896056539 hcl:#a97842 hgt:165cm")]
        [InlineData("hcl:#888785\nhgt:164cm byr:2001 iyr:2015 cid:88\npid:545766238 ecl:hzl\neyr:2022")]
        [InlineData("iyr:2010 hgt:158cm hcl:#b6652a ecl:blu byr:1944 eyr:2021 pid:093154719")]
        public void PassportIsValidPart2(string input)
        {
            Passport passport = Passport.Parse(input);
            Assert.True(passport.IsValid());
        }

        [Theory]
        [InlineData(2002)]
        [InlineData(1920)]
        public void ByrValid(int input)
        {
            Assert.True(Passport.IsByrValid(input));
        }
        
        [Theory]
        [InlineData(2003)]
        [InlineData(1919)]
        public void ByrInValid(int input)
        {
            Assert.False(Passport.IsByrValid(input));
        }
        
        [Theory]
        [InlineData(2020)]
        [InlineData(2010)]
        public void IyrValid(int input)
        {
            Assert.True(Passport.IsIyrValid(input));
        }
        
        [Theory]
        [InlineData(2021)]
        [InlineData(2009)]
        public void IyrInValid(int input)
        {
            Assert.False(Passport.IsIyrValid(input));
        }
        
        [Theory]
        [InlineData(2020)]
        [InlineData(2030)]
        public void EyrValid(int input)
        {
            Assert.True(Passport.IsEyrValid(input));
        }
        
        [Theory]
        [InlineData(2019)]
        [InlineData(2031)]
        public void EyrInValid(int input)
        {
            Assert.False(Passport.IsEyrValid(input));
        }
        
        [Theory]
        [InlineData("60in")]
        [InlineData("190cm")]
        public void HgtValid(string input)
        {
            Assert.True(Passport.IsHeightValid(input));
        }
        
        [Theory]
        [InlineData("190in")]
        [InlineData("190")]
        public void HgtInValid(string input)
        {
            Assert.False(Passport.IsHeightValid(input));
        }
        
        [Theory]
        [InlineData("#123abc")]
        public void HclValid(string input)
        {
            Assert.True(Passport.IsHclValid(input));
        }
        
        [Theory]
        [InlineData("#123abz")]
        [InlineData("123abc")]
        public void HclInValid(string input)
        {
            Assert.False(Passport.IsHclValid(input));
        }
        
        [Theory]
        [InlineData("brn")]
        public void EclValid(string input)
        {
            Assert.True(Passport.IsEclValid(input));
        }
        
        [Theory]
        [InlineData("wat")]
        public void EclInValid(string input)
        {
            Assert.False(Passport.IsEclValid(input));
        }
        
        [Theory]
        [InlineData("000000001")]
        public void PidValid(string input)
        {
            Assert.True(Passport.IsPidValid(input));
        }
        
        [Theory]
        [InlineData("0123456789")]
        public void PidInValid(string input)
        {
            Assert.False(Passport.IsPidValid(input));
        }
        
    }
}