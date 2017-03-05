using NUnit.Framework;
using FluentAssertions;
using Risiko_Core.Classes;

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
            sut.Count.Should().Be(6);
        }

        [TestCase(0, "black")]
        [TestCase(1, "green")]
        [TestCase(2, "purple")]
        [TestCase(3, "cyan")]
        [TestCase(4, "yellow")]
        [TestCase(5, "red")]
        public void IdsShouldMatchColors(int id, string color)
        {
            var sut = new ColorList();
            sut.GetColor(id).Should().Be(color);
        }
    }
}
