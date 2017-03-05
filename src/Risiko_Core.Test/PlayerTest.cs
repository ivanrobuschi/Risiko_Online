using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;
using Risiko_Core;

namespace Risiko_Core.Test
{
    class PlayerTest
    {
        [Test]
        public void PlayerShouldExist()
        {
            var sut = new Player(0, "pippo", 0, 0);
            sut.Should().NotBeNull();
        }

        [Test]
        public void PlayerIDShouldMatchGivenID()
        {
            var sut = new Player(0, "pippo", 1, 1);
            sut.ID.Should().Be(0);
        }

        [Test]
        public void PlayerNameShouldMatchGivenName()
        {
            var sut = new Player(0, "pippo", 0, 0);
            sut.name.Should().Be("pippo");
        }

        [Test]
        public void PlayerColorIDShouldMatchGivenColorID()
        {
            var sut = new Player(1, "pippo", 0, 1);
            sut.colorID.Should().Be(0);
        }

        [Test]
        public void PlayerTargetIDShouldMatchGivenTargetID()
        {
            var sut = new Player(1, "pippo", 1, 0);
            sut.targetID.Should().Be(0);
        }


    }
}
