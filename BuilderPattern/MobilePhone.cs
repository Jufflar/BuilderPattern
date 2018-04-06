using MobilePhoneManufacturer.enums;

namespace MobilePhoneManufacturer
{
    public class MobilePhone
    {
        public MobilePhone(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public ScreenType Screen { get; set; }
        public OperatingSystem OS { get; set; }
        public Stylus Stylus { get; set; }
        public Battery Battery { get; set; }
    }
}