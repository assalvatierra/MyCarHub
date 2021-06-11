
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/11/2021 15:38:02
-- Generated from EDMX file: C:\Abel\GitHub\MyCarHub\DBSchema\DBSchema\Models\MyCarDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyCarDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'MyCars'
CREATE TABLE [dbo].[MyCars] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Year] nvarchar(max)  NOT NULL,
    [Variant] nvarchar(max)  NOT NULL,
    [MyCarModelId] int  NOT NULL,
    [MyCarFuelId] int  NOT NULL,
    [MyCarTransmissionId] int  NOT NULL,
    [MyCarDrivetrainId] int  NOT NULL,
    [PlateNo] nvarchar(max)  NOT NULL,
    [Conduction] nvarchar(max)  NOT NULL,
    [Vin] nvarchar(max)  NOT NULL,
    [MyAccountId] int  NOT NULL
);
GO

-- Creating table 'MyCarModels'
CREATE TABLE [dbo].[MyCarModels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Model] nvarchar(max)  NOT NULL,
    [MyCarMakeId] int  NOT NULL,
    [MyCarTypeId] int  NOT NULL
);
GO

-- Creating table 'MyCarMakes'
CREATE TABLE [dbo].[MyCarMakes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Make] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MyCarTypes'
CREATE TABLE [dbo].[MyCarTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MyCarFuels'
CREATE TABLE [dbo].[MyCarFuels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Fuel] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MyCarTransmissions'
CREATE TABLE [dbo].[MyCarTransmissions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Transmission] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MyCarDrivetrains'
CREATE TABLE [dbo].[MyCarDrivetrains] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Drivetrain] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MyGarages'
CREATE TABLE [dbo].[MyGarages] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [Remarks] nvarchar(max)  NOT NULL,
    [MyAccountId] int  NOT NULL
);
GO

-- Creating table 'MyDrivers'
CREATE TABLE [dbo].[MyDrivers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [LicNo] nvarchar(max)  NOT NULL,
    [Remarks] nvarchar(max)  NOT NULL,
    [MyAccountId] int  NOT NULL
);
GO

-- Creating table 'MyCarTrxes'
CREATE TABLE [dbo].[MyCarTrxes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MyCarTrxTypeId] int  NOT NULL,
    [MyCarId] int  NOT NULL,
    [TrxDate] nvarchar(max)  NOT NULL,
    [TrxTime] nvarchar(max)  NOT NULL,
    [TrxMileage] nvarchar(max)  NOT NULL,
    [EnteredBy] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MyCarTrxGarages'
CREATE TABLE [dbo].[MyCarTrxGarages] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MyCarTrxId] int  NOT NULL,
    [MyGarageId] int  NOT NULL,
    [InFlag] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MyCarTrxDrivers'
CREATE TABLE [dbo].[MyCarTrxDrivers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MyCarTrxId] int  NOT NULL,
    [MyDriverId] int  NOT NULL
);
GO

-- Creating table 'MyCarTrxFuels'
CREATE TABLE [dbo].[MyCarTrxFuels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Value] nvarchar(max)  NOT NULL,
    [MyCarTrxId] int  NOT NULL
);
GO

-- Creating table 'MyCarTrxServices'
CREATE TABLE [dbo].[MyCarTrxServices] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Amount] nvarchar(max)  NOT NULL,
    [Remarks] nvarchar(max)  NOT NULL,
    [MyCarTrxId] int  NOT NULL,
    [MyCarServiceTypeId] int  NOT NULL
);
GO

-- Creating table 'MyCarServiceTypes'
CREATE TABLE [dbo].[MyCarServiceTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MyCarTrxExpenses'
CREATE TABLE [dbo].[MyCarTrxExpenses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Amount] nvarchar(max)  NOT NULL,
    [Remarks] nvarchar(max)  NOT NULL,
    [MyCarTrxId] int  NOT NULL,
    [MyCarExpenseTypeId] int  NOT NULL
);
GO

-- Creating table 'MyCarExpenseTypes'
CREATE TABLE [dbo].[MyCarExpenseTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MyCarReminders'
CREATE TABLE [dbo].[MyCarReminders] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MyCarId] int  NOT NULL,
    [DtEntered] nvarchar(max)  NOT NULL,
    [Message] nvarchar(max)  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [DtRemind] nvarchar(max)  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [MyReminderTypeId] int  NOT NULL,
    [SendNotification] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MyReminderTypes'
CREATE TABLE [dbo].[MyReminderTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MyAccounts'
CREATE TABLE [dbo].[MyAccounts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [LoginId] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MySupportLogins'
CREATE TABLE [dbo].[MySupportLogins] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [MyAccountId] int  NOT NULL,
    [LoginId] nvarchar(max)  NOT NULL,
    [Remarks] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MyGarageLogins'
CREATE TABLE [dbo].[MyGarageLogins] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MyGarageId] int  NOT NULL,
    [MySupportLoginId] int  NOT NULL
);
GO

-- Creating table 'MyDriverLogins'
CREATE TABLE [dbo].[MyDriverLogins] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MyDriverId] int  NOT NULL,
    [MySupportLoginId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'MyCars'
ALTER TABLE [dbo].[MyCars]
ADD CONSTRAINT [PK_MyCars]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MyCarModels'
ALTER TABLE [dbo].[MyCarModels]
ADD CONSTRAINT [PK_MyCarModels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MyCarMakes'
ALTER TABLE [dbo].[MyCarMakes]
ADD CONSTRAINT [PK_MyCarMakes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MyCarTypes'
ALTER TABLE [dbo].[MyCarTypes]
ADD CONSTRAINT [PK_MyCarTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MyCarFuels'
ALTER TABLE [dbo].[MyCarFuels]
ADD CONSTRAINT [PK_MyCarFuels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MyCarTransmissions'
ALTER TABLE [dbo].[MyCarTransmissions]
ADD CONSTRAINT [PK_MyCarTransmissions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MyCarDrivetrains'
ALTER TABLE [dbo].[MyCarDrivetrains]
ADD CONSTRAINT [PK_MyCarDrivetrains]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MyGarages'
ALTER TABLE [dbo].[MyGarages]
ADD CONSTRAINT [PK_MyGarages]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MyDrivers'
ALTER TABLE [dbo].[MyDrivers]
ADD CONSTRAINT [PK_MyDrivers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MyCarTrxes'
ALTER TABLE [dbo].[MyCarTrxes]
ADD CONSTRAINT [PK_MyCarTrxes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MyCarTrxGarages'
ALTER TABLE [dbo].[MyCarTrxGarages]
ADD CONSTRAINT [PK_MyCarTrxGarages]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MyCarTrxDrivers'
ALTER TABLE [dbo].[MyCarTrxDrivers]
ADD CONSTRAINT [PK_MyCarTrxDrivers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MyCarTrxFuels'
ALTER TABLE [dbo].[MyCarTrxFuels]
ADD CONSTRAINT [PK_MyCarTrxFuels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MyCarTrxServices'
ALTER TABLE [dbo].[MyCarTrxServices]
ADD CONSTRAINT [PK_MyCarTrxServices]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MyCarServiceTypes'
ALTER TABLE [dbo].[MyCarServiceTypes]
ADD CONSTRAINT [PK_MyCarServiceTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MyCarTrxExpenses'
ALTER TABLE [dbo].[MyCarTrxExpenses]
ADD CONSTRAINT [PK_MyCarTrxExpenses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MyCarExpenseTypes'
ALTER TABLE [dbo].[MyCarExpenseTypes]
ADD CONSTRAINT [PK_MyCarExpenseTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MyCarReminders'
ALTER TABLE [dbo].[MyCarReminders]
ADD CONSTRAINT [PK_MyCarReminders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MyReminderTypes'
ALTER TABLE [dbo].[MyReminderTypes]
ADD CONSTRAINT [PK_MyReminderTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MyAccounts'
ALTER TABLE [dbo].[MyAccounts]
ADD CONSTRAINT [PK_MyAccounts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MySupportLogins'
ALTER TABLE [dbo].[MySupportLogins]
ADD CONSTRAINT [PK_MySupportLogins]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MyGarageLogins'
ALTER TABLE [dbo].[MyGarageLogins]
ADD CONSTRAINT [PK_MyGarageLogins]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MyDriverLogins'
ALTER TABLE [dbo].[MyDriverLogins]
ADD CONSTRAINT [PK_MyDriverLogins]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MyCarMakeId] in table 'MyCarModels'
ALTER TABLE [dbo].[MyCarModels]
ADD CONSTRAINT [FK_MyCarMakeMyCarModel]
    FOREIGN KEY ([MyCarMakeId])
    REFERENCES [dbo].[MyCarMakes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyCarMakeMyCarModel'
CREATE INDEX [IX_FK_MyCarMakeMyCarModel]
ON [dbo].[MyCarModels]
    ([MyCarMakeId]);
GO

-- Creating foreign key on [MyCarTypeId] in table 'MyCarModels'
ALTER TABLE [dbo].[MyCarModels]
ADD CONSTRAINT [FK_MyCarTypeMyCarModel]
    FOREIGN KEY ([MyCarTypeId])
    REFERENCES [dbo].[MyCarTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyCarTypeMyCarModel'
CREATE INDEX [IX_FK_MyCarTypeMyCarModel]
ON [dbo].[MyCarModels]
    ([MyCarTypeId]);
GO

-- Creating foreign key on [MyCarModelId] in table 'MyCars'
ALTER TABLE [dbo].[MyCars]
ADD CONSTRAINT [FK_MyCarModelMyCar]
    FOREIGN KEY ([MyCarModelId])
    REFERENCES [dbo].[MyCarModels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyCarModelMyCar'
CREATE INDEX [IX_FK_MyCarModelMyCar]
ON [dbo].[MyCars]
    ([MyCarModelId]);
GO

-- Creating foreign key on [MyCarFuelId] in table 'MyCars'
ALTER TABLE [dbo].[MyCars]
ADD CONSTRAINT [FK_MyCarFuelMyCar]
    FOREIGN KEY ([MyCarFuelId])
    REFERENCES [dbo].[MyCarFuels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyCarFuelMyCar'
CREATE INDEX [IX_FK_MyCarFuelMyCar]
ON [dbo].[MyCars]
    ([MyCarFuelId]);
GO

-- Creating foreign key on [MyCarTransmissionId] in table 'MyCars'
ALTER TABLE [dbo].[MyCars]
ADD CONSTRAINT [FK_MyCarTransmissionMyCar]
    FOREIGN KEY ([MyCarTransmissionId])
    REFERENCES [dbo].[MyCarTransmissions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyCarTransmissionMyCar'
CREATE INDEX [IX_FK_MyCarTransmissionMyCar]
ON [dbo].[MyCars]
    ([MyCarTransmissionId]);
GO

-- Creating foreign key on [MyCarDrivetrainId] in table 'MyCars'
ALTER TABLE [dbo].[MyCars]
ADD CONSTRAINT [FK_MyCarDrivetrainMyCar]
    FOREIGN KEY ([MyCarDrivetrainId])
    REFERENCES [dbo].[MyCarDrivetrains]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyCarDrivetrainMyCar'
CREATE INDEX [IX_FK_MyCarDrivetrainMyCar]
ON [dbo].[MyCars]
    ([MyCarDrivetrainId]);
GO

-- Creating foreign key on [MyCarId] in table 'MyCarTrxes'
ALTER TABLE [dbo].[MyCarTrxes]
ADD CONSTRAINT [FK_MyCarMyCarTrx]
    FOREIGN KEY ([MyCarId])
    REFERENCES [dbo].[MyCars]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyCarMyCarTrx'
CREATE INDEX [IX_FK_MyCarMyCarTrx]
ON [dbo].[MyCarTrxes]
    ([MyCarId]);
GO

-- Creating foreign key on [MyCarTrxId] in table 'MyCarTrxGarages'
ALTER TABLE [dbo].[MyCarTrxGarages]
ADD CONSTRAINT [FK_MyCarTrxMyCarGarageTrx]
    FOREIGN KEY ([MyCarTrxId])
    REFERENCES [dbo].[MyCarTrxes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyCarTrxMyCarGarageTrx'
CREATE INDEX [IX_FK_MyCarTrxMyCarGarageTrx]
ON [dbo].[MyCarTrxGarages]
    ([MyCarTrxId]);
GO

-- Creating foreign key on [MyGarageId] in table 'MyCarTrxGarages'
ALTER TABLE [dbo].[MyCarTrxGarages]
ADD CONSTRAINT [FK_MyGarageMyCarGarageTrx]
    FOREIGN KEY ([MyGarageId])
    REFERENCES [dbo].[MyGarages]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyGarageMyCarGarageTrx'
CREATE INDEX [IX_FK_MyGarageMyCarGarageTrx]
ON [dbo].[MyCarTrxGarages]
    ([MyGarageId]);
GO

-- Creating foreign key on [MyCarTrxId] in table 'MyCarTrxDrivers'
ALTER TABLE [dbo].[MyCarTrxDrivers]
ADD CONSTRAINT [FK_MyCarTrxMyCarTrxDriver]
    FOREIGN KEY ([MyCarTrxId])
    REFERENCES [dbo].[MyCarTrxes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyCarTrxMyCarTrxDriver'
CREATE INDEX [IX_FK_MyCarTrxMyCarTrxDriver]
ON [dbo].[MyCarTrxDrivers]
    ([MyCarTrxId]);
GO

-- Creating foreign key on [MyDriverId] in table 'MyCarTrxDrivers'
ALTER TABLE [dbo].[MyCarTrxDrivers]
ADD CONSTRAINT [FK_MyDriverMyCarTrxDriver]
    FOREIGN KEY ([MyDriverId])
    REFERENCES [dbo].[MyDrivers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyDriverMyCarTrxDriver'
CREATE INDEX [IX_FK_MyDriverMyCarTrxDriver]
ON [dbo].[MyCarTrxDrivers]
    ([MyDriverId]);
GO

-- Creating foreign key on [MyCarTrxId] in table 'MyCarTrxFuels'
ALTER TABLE [dbo].[MyCarTrxFuels]
ADD CONSTRAINT [FK_MyCarTrxMyCarTrxFuel]
    FOREIGN KEY ([MyCarTrxId])
    REFERENCES [dbo].[MyCarTrxes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyCarTrxMyCarTrxFuel'
CREATE INDEX [IX_FK_MyCarTrxMyCarTrxFuel]
ON [dbo].[MyCarTrxFuels]
    ([MyCarTrxId]);
GO

-- Creating foreign key on [MyCarTrxId] in table 'MyCarTrxServices'
ALTER TABLE [dbo].[MyCarTrxServices]
ADD CONSTRAINT [FK_MyCarTrxMyCarService]
    FOREIGN KEY ([MyCarTrxId])
    REFERENCES [dbo].[MyCarTrxes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyCarTrxMyCarService'
CREATE INDEX [IX_FK_MyCarTrxMyCarService]
ON [dbo].[MyCarTrxServices]
    ([MyCarTrxId]);
GO

-- Creating foreign key on [MyCarServiceTypeId] in table 'MyCarTrxServices'
ALTER TABLE [dbo].[MyCarTrxServices]
ADD CONSTRAINT [FK_MyCarServiceTypeMyCarTrxService]
    FOREIGN KEY ([MyCarServiceTypeId])
    REFERENCES [dbo].[MyCarServiceTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyCarServiceTypeMyCarTrxService'
CREATE INDEX [IX_FK_MyCarServiceTypeMyCarTrxService]
ON [dbo].[MyCarTrxServices]
    ([MyCarServiceTypeId]);
GO

-- Creating foreign key on [MyCarTrxId] in table 'MyCarTrxExpenses'
ALTER TABLE [dbo].[MyCarTrxExpenses]
ADD CONSTRAINT [FK_MyCarTrxMyCarTrxExpense]
    FOREIGN KEY ([MyCarTrxId])
    REFERENCES [dbo].[MyCarTrxes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyCarTrxMyCarTrxExpense'
CREATE INDEX [IX_FK_MyCarTrxMyCarTrxExpense]
ON [dbo].[MyCarTrxExpenses]
    ([MyCarTrxId]);
GO

-- Creating foreign key on [MyCarExpenseTypeId] in table 'MyCarTrxExpenses'
ALTER TABLE [dbo].[MyCarTrxExpenses]
ADD CONSTRAINT [FK_MyCarExpenseTypeMyCarTrxExpense]
    FOREIGN KEY ([MyCarExpenseTypeId])
    REFERENCES [dbo].[MyCarExpenseTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyCarExpenseTypeMyCarTrxExpense'
CREATE INDEX [IX_FK_MyCarExpenseTypeMyCarTrxExpense]
ON [dbo].[MyCarTrxExpenses]
    ([MyCarExpenseTypeId]);
GO

-- Creating foreign key on [MyCarId] in table 'MyCarReminders'
ALTER TABLE [dbo].[MyCarReminders]
ADD CONSTRAINT [FK_MyCarMyCarReminder]
    FOREIGN KEY ([MyCarId])
    REFERENCES [dbo].[MyCars]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyCarMyCarReminder'
CREATE INDEX [IX_FK_MyCarMyCarReminder]
ON [dbo].[MyCarReminders]
    ([MyCarId]);
GO

-- Creating foreign key on [MyReminderTypeId] in table 'MyCarReminders'
ALTER TABLE [dbo].[MyCarReminders]
ADD CONSTRAINT [FK_MyReminderTypeMyCarReminder]
    FOREIGN KEY ([MyReminderTypeId])
    REFERENCES [dbo].[MyReminderTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyReminderTypeMyCarReminder'
CREATE INDEX [IX_FK_MyReminderTypeMyCarReminder]
ON [dbo].[MyCarReminders]
    ([MyReminderTypeId]);
GO

-- Creating foreign key on [MyAccountId] in table 'MySupportLogins'
ALTER TABLE [dbo].[MySupportLogins]
ADD CONSTRAINT [FK_MyAccountMySupportLogin]
    FOREIGN KEY ([MyAccountId])
    REFERENCES [dbo].[MyAccounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyAccountMySupportLogin'
CREATE INDEX [IX_FK_MyAccountMySupportLogin]
ON [dbo].[MySupportLogins]
    ([MyAccountId]);
GO

-- Creating foreign key on [MyAccountId] in table 'MyCars'
ALTER TABLE [dbo].[MyCars]
ADD CONSTRAINT [FK_MyAccountMyCar]
    FOREIGN KEY ([MyAccountId])
    REFERENCES [dbo].[MyAccounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyAccountMyCar'
CREATE INDEX [IX_FK_MyAccountMyCar]
ON [dbo].[MyCars]
    ([MyAccountId]);
GO

-- Creating foreign key on [MyGarageId] in table 'MyGarageLogins'
ALTER TABLE [dbo].[MyGarageLogins]
ADD CONSTRAINT [FK_MyGarageMyGarageAdmin]
    FOREIGN KEY ([MyGarageId])
    REFERENCES [dbo].[MyGarages]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyGarageMyGarageAdmin'
CREATE INDEX [IX_FK_MyGarageMyGarageAdmin]
ON [dbo].[MyGarageLogins]
    ([MyGarageId]);
GO

-- Creating foreign key on [MySupportLoginId] in table 'MyGarageLogins'
ALTER TABLE [dbo].[MyGarageLogins]
ADD CONSTRAINT [FK_MySupportLoginMyGarageLogin]
    FOREIGN KEY ([MySupportLoginId])
    REFERENCES [dbo].[MySupportLogins]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MySupportLoginMyGarageLogin'
CREATE INDEX [IX_FK_MySupportLoginMyGarageLogin]
ON [dbo].[MyGarageLogins]
    ([MySupportLoginId]);
GO

-- Creating foreign key on [MyDriverId] in table 'MyDriverLogins'
ALTER TABLE [dbo].[MyDriverLogins]
ADD CONSTRAINT [FK_MyDriverMyDriverLogin]
    FOREIGN KEY ([MyDriverId])
    REFERENCES [dbo].[MyDrivers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyDriverMyDriverLogin'
CREATE INDEX [IX_FK_MyDriverMyDriverLogin]
ON [dbo].[MyDriverLogins]
    ([MyDriverId]);
GO

-- Creating foreign key on [MySupportLoginId] in table 'MyDriverLogins'
ALTER TABLE [dbo].[MyDriverLogins]
ADD CONSTRAINT [FK_MySupportLoginMyDriverLogin]
    FOREIGN KEY ([MySupportLoginId])
    REFERENCES [dbo].[MySupportLogins]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MySupportLoginMyDriverLogin'
CREATE INDEX [IX_FK_MySupportLoginMyDriverLogin]
ON [dbo].[MyDriverLogins]
    ([MySupportLoginId]);
GO

-- Creating foreign key on [MyAccountId] in table 'MyDrivers'
ALTER TABLE [dbo].[MyDrivers]
ADD CONSTRAINT [FK_MyAccountMyDriver]
    FOREIGN KEY ([MyAccountId])
    REFERENCES [dbo].[MyAccounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyAccountMyDriver'
CREATE INDEX [IX_FK_MyAccountMyDriver]
ON [dbo].[MyDrivers]
    ([MyAccountId]);
GO

-- Creating foreign key on [MyAccountId] in table 'MyGarages'
ALTER TABLE [dbo].[MyGarages]
ADD CONSTRAINT [FK_MyAccountMyGarage]
    FOREIGN KEY ([MyAccountId])
    REFERENCES [dbo].[MyAccounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MyAccountMyGarage'
CREATE INDEX [IX_FK_MyAccountMyGarage]
ON [dbo].[MyGarages]
    ([MyAccountId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------