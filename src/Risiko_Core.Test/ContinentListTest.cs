using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using Risiko_Core.Classes;

namespace Risiko_Core.Test
{
    class ContinentListTest
    {
        [Test]
        public void ContinentListShouldExist()
        {
            var sut = new ContinentList();
            sut.Should().NotBeNull();
        }

        [Test]
        public void ContinentListShouldContainAllColors()
        {
            var sut = new ContinentList();
            sut.Count.Should().Be(6);
        }

        [TestCase(0, "North America")]
        [TestCase(1, "South America")]
        [TestCase(2, "Africa")]
        [TestCase(3, "Europe")]
        [TestCase(4, "Asia")]
        [TestCase(5, "Oceania")]
        public void IdShouldMatchContinent(int id, string continentName)
        {
            var sut = new ContinentList();
            sut.GetContinent(id).Should().Be(continentName);
        }
    }
}
