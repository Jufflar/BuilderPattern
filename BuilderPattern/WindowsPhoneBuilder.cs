using MobilePhoneManufacturer.enums;

namespace MobilePhoneManufacturer
{
    public class WindowsPhoneBuilder : IPhoneBuilder
    {
        public WindowsPhoneBuilder()
        {
            Phone = new MobilePhone("Windows Phone");
            Phone.Screen = ScreenType.ScreenType_TOUCH_RESISTIVE;
            Phone.Battery = Battery.MAH_1000;
            Phone.OS = OperatingSystem.WINDOWS_PHONE;
            Phone.Stylus = Stylus.YES;
        }

        public MobilePhone Phone { get; }

        public void BuildScreen()
        {
        }

        public void BuildBattery()
        {
        }

        public void BuildOpperatingSystem()
        {
        }

        public void BuildStylus()
        {
        }
    }
}