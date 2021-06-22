using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using Domain.BLLInterfaces;
using Domain.Entities;
using BusinessLayer;
using Mock.DataLayer;


namespace BusinessLayer.Tests
{
    public class BLLVehiclesGetData
    {
        [Fact]
        public void GetCarByID()
        {
            int carid = 1;
            IVehicleBLL bll01 = new BLLVehicles(null, new myCarRepository() );

            Domain.Entities.MyCar mycar = bll01.getMyCar(carid);
            Assert.True(mycar.Id == carid);

            int carid2 = 2;
            Domain.Entities.MyCar mycar2 = bll01.getMyCar(carid2);
            Assert.True(mycar2.Id == carid2);

        }

        [Fact]
        public void GetListOfCars()
        {
            IVehicleBLL bll01 = new BLLVehicles(null, new myCarRepository());

            List<MyCar> mycars = (List<MyCar>) bll01.getMyCarList();
            Assert.True(mycars.Count == 3);

        }

    }
}
