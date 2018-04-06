using CarManufacturer;
using NUnit.Framework;

namespace CarManufacturerTests
{
    [TestFixture]
    public class BuilderTests
    {
        [Test]
        public void ConstructVehicle_CarBuilder_CarIsBuilt()
        {
            // Arrange
            var mancufacturer = new Mancufacturer();
            VehicleBuilder vehicleBuilder = new CarBuilder();

            // Act
            mancufacturer.Construct(vehicleBuilder);

            // Assert
            Assert.That(vehicleBuilder.Vehicle.Type, Is.EqualTo("Car"));
        }
    }
}