namespace MobilePhoneManufacturer
{
    public interface IPhoneBuilder
    {
        MobilePhone Phone { get; }
        void BuildScreen();
        void BuildBattery();
        void BuildOpperatingSystem();
        void BuildStylus();
    }
}