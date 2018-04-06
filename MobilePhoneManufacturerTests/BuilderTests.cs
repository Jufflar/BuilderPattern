using MobilePhoneManufacturer;
using MobilePhoneManufacturer.enums;
using NUnit.Framework;

namespace MobilePhoneManufacturerTests
{
    [TestFixture]
    public class BuilderTests
    {
        [Test]
        public void ConstructPhone_AndroidPhoneBuilder_AndroidPhoneIsBuilt()
        {
            // Arrange
            var newMancufacturer = new Mancufacturer();
            IPhoneBuilder phoneBuilder = new AndroidPhoneBuilder();

            // Act
            newMancufacturer.Construct(phoneBuilder);

            // Assert
            Assert.That(phoneBuilder.Phone.Name, Is.EqualTo("Android Phone"));
            Assert.That(phoneBuilder.Phone.OS, Is.EqualTo(OperatingSystem.ANDROID));
        }

        [Test]
        public void ConstructPhone_WindowsPhoneBuilder_WindowsPhoneIsBuilt()
        {
            // Arrange
            var newMancufacturer = new Mancufacturer();
            IPhoneBuilder phoneBuilder = new WindowsPhoneBuilder();

            // Act
            newMancufacturer.Construct(phoneBuilder);

            // Assert
            Assert.That(phoneBuilder.Phone.Name, Is.EqualTo("Windows Phone"));
            Assert.That(phoneBuilder.Phone.OS, Is.EqualTo(OperatingSystem.WINDOWS_PHONE));
        }
    }
}