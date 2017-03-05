using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;

namespace Risiko_Core.Test
{
    public class ColorListTest
    {
        [Test]
        public void ColorListShouldExist()
        {
            var sut = new ColorList();
            sut.Should().NotBeNull();
        }

        [Test]
        public void ColorListShouldContainAllColors()
        {
            var sut = new ColorList();
            sut.colorList.Count.Should().Be(6);
        }

        [TestCase(0, "black")]
        [TestCase(1, "green")]
        [TestCase(2, "purple")]
        [TestCase(3, "cyan")]
        [TestCase(4, "yellow")]
        [TestCase(5, "red")]
        public void IDsShouldMatchColors(int id, string color)
        {
            var sut = new ColorList();
            sut.colorList[id].Should().Be(color);
        }
    }
}
