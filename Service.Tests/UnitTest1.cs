using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Xunit;
using Service.Controllers;
using Domain.Entities;

namespace Service.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            MyCarsApiController controller = new MyCarsApiController(new MockBLLVehicles(null, new MockCarRepository() ));
            List<MyCar> mycars = (List<MyCar>) controller.GetMyCar();

            Assert.True(mycars.Count== 3);
        }
    }
}
