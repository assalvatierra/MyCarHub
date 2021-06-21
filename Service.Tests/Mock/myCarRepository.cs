using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;

namespace Service.Tests
{
    public class MockCarRepository : IMyCarRepository
    {
        private List<MyCar> mycars;

        public MockCarRepository()
        {
            this.mycars = new List<MyCar>();
            this.mycars.Add(new MyCar { Id = 1, Conduction = "T101", MyAccountId = 0, MyCarDrivetrainId = 1, MyCarFuelId = 1, MyCarModelId = 1, MyCarTransmissionId = 1, PlateNo = "LDP2264", Variant = "AMB", Vin = "123-456", Year = "2016" });
            this.mycars.Add(new MyCar { Id = 2, Conduction = "T102", MyAccountId = 0, MyCarDrivetrainId = 1, MyCarFuelId = 1, MyCarModelId = 1, MyCarTransmissionId = 1, PlateNo = "LDP2264", Variant = "AMB", Vin = "123-456", Year = "2016" });
            this.mycars.Add(new MyCar { Id = 3, Conduction = "T103", MyAccountId = 0, MyCarDrivetrainId = 1, MyCarFuelId = 1, MyCarModelId = 1, MyCarTransmissionId = 1, PlateNo = "LDP2264", Variant = "AMB", Vin = "123-456", Year = "2016" });

        }

                
        public void Add(MyCar entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<MyCar> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MyCar> GetAll()
        {
            return this.mycars;
        }

        public MyCar GetById(int id)
        {
            return this.mycars.Find(x => x.Id == id);
        }

        public void Remove(MyCar entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<MyCar> entities)
        {
            throw new NotImplementedException();
        }
    }
}
