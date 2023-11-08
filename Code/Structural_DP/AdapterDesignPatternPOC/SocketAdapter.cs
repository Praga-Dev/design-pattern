namespace AdapterDesignPatternPOC
{
    // Class Implementation for Adapter
    public class SocketAdapter : Socket, ISocketAdapter
    {
        // Default Volt
        public Volt Get120Volt()
        {
            return GetVolt();
        }

        public Volt Get12Volt()
        {
            Volt v = GetVolt();
            return ConvertVolts(v, 10);
        }

        public Volt Get3Volt()
        {
            Volt v = GetVolt();
            return ConvertVolts(v, 40);
        }

        public static Volt ConvertVolts(Volt volts, int conversionValue) => new(volts.GetVolts() / conversionValue);

    }
}
