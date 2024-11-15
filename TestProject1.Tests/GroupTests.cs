using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.InMemory;
using WebApplication1.Models;

namespace TestProject1.Tests
{
    public class GroupTests
    {
        [Fact]
        public void IsValidGroupName_44_True()
        {
            // arrange
            var testGroup = new Group
            {
                GroupName = "44"
            };

            //act
            var result = testGroup.IsValidGroupName();

            //assert
            Assert.True(result);
        }
    }
}
