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
            var sut = new Player();
            sut.Should().NotBeNull();
        }

    }
}
