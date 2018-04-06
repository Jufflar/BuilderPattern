namespace MobilePhoneManufacturer
{
    public class Mancufacturer
    {
        public void Construct(IPhoneBuilder phoneBuilder)
        {
            phoneBuilder.BuildBattery();
            phoneBuilder.BuildOpperatingSystem();
            phoneBuilder.BuildScreen();
            phoneBuilder.BuildStylus();
        }
    }
}