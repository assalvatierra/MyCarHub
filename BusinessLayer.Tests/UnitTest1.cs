using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using Domain.BLLInterfaces;
using Domain.Entities;
using BusinessLayer;
using DataLayer;


namespace BusinessLayer.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int carid = 1;
            IVehicleBLL bll01 = new BLLVehicles(null, new MyCarRepo() );

            Domain.Entities.MyCar mycar = bll01.getMyCar(carid);
            Assert.True(mycar.Id == carid);

        }

        [Fact]
        public void test2()
        {
            IVehicleBLL bll01 = new BLLVehicles(null, new MyCarRepo());

            List<MyCar> mycars = (List<MyCar>) bll01.getMyCarList();
            Assert.True(mycars.Count == 3);

        }

    }
}
