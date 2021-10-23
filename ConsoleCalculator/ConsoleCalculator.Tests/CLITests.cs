using ConsoleCalculator.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleCalculator.Tests
{
    [TestClass]
    public class CLITests
    {
        public string _left = "2";
        public string _right = "2";

        [TestMethod]
        public void ShouldAdd()
        {
            var args = new string[] { "-op","+","-l","45","-r", "96" };
            ConsoleCalculator.CLI.Program.Main(args);
        }

        [TestMethod]
        public void ShouldSubstract()
        {
            var args = new string[] { "-op", "-", "-l", "45", "-r", "96" };
            ConsoleCalculator.CLI.Program.Main(args);
        }

        [TestMethod]
        public void ShouldMultiply()
        {
            var args = new string[] { "-op", "*", "-l", "45", "-r", "96" };
            ConsoleCalculator.CLI.Program.Main(args);
        }

        [TestMethod]
        public void ShouldDivide()
        {
            var args = new string[] { "-op", "/", "-l", "45", "-r", "96" };
            ConsoleCalculator.CLI.Program.Main(args);
        }
    }
}
