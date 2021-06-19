using System;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;


namespace DataLayer
{
    public partial class MyCarDBContext : DbContext
    {
       public MyCarDBContext( DbContextOptions<MyCarDBContext> options) : base(options)
        {

        }
    
    
        public virtual DbSet<MyCar> MyCars { get; set; }
        public virtual DbSet<MyCarModel> MyCarModels { get; set; }
        public virtual DbSet<MyCarMake> MyCarMakes { get; set; }
        public virtual DbSet<MyCarType> MyCarTypes { get; set; }
        public virtual DbSet<MyCarFuel> MyCarFuels { get; set; }
        public virtual DbSet<MyCarTransmission> MyCarTransmissions { get; set; }
        public virtual DbSet<MyCarDrivetrain> MyCarDrivetrains { get; set; }
        public virtual DbSet<MyGarage> MyGarages { get; set; }
        public virtual DbSet<MyDriver> MyDrivers { get; set; }
        public virtual DbSet<MyCarTrx> MyCarTrxes { get; set; }
        public virtual DbSet<MyCarTrxGarage> MyCarTrxGarages { get; set; }
        public virtual DbSet<MyCarTrxDriver> MyCarTrxDrivers { get; set; }
        public virtual DbSet<MyCarTrxFuel> MyCarTrxFuels { get; set; }
        public virtual DbSet<MyCarTrxService> MyCarTrxServices { get; set; }
        public virtual DbSet<MyCarServiceType> MyCarServiceTypes { get; set; }
        public virtual DbSet<MyCarTrxExpense> MyCarTrxExpenses { get; set; }
        public virtual DbSet<MyCarExpenseType> MyCarExpenseTypes { get; set; }
        public virtual DbSet<MyCarReminder> MyCarReminders { get; set; }
        public virtual DbSet<MyReminderType> MyReminderTypes { get; set; }
        public virtual DbSet<MyAccount> MyAccounts { get; set; }
        public virtual DbSet<MySupportLogin> MySupportLogins { get; set; }
        public virtual DbSet<MyGarageLogin> MyGarageLogins { get; set; }
        public virtual DbSet<MyDriverLogin> MyDriverLogins { get; set; }
    }
}
