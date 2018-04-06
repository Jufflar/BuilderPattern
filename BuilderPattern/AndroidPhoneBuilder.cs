using MobilePhoneManufacturer.enums;

namespace MobilePhoneManufacturer
{
    public class AndroidPhoneBuilder : IPhoneBuilder
    {
        public AndroidPhoneBuilder()
        {
            Phone = new MobilePhone("Android Phone");
        }

        public void BuildScreen()
        {
            Phone.Screen = ScreenType.ScreenType_TOUCH_RESISTIVE;
        }

        public void BuildBattery()
        {
            Phone.Battery = Battery.MAH_1000;
        }

        public void BuildOpperatingSystem()
        {
            Phone.OS = OperatingSystem.ANDROID;
        }

        public void BuildStylus()
        {
            Phone.Stylus = Stylus.YES;
        }

        public MobilePhone Phone { get; set; }
    }
}