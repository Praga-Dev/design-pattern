namespace AdapterDesignPatternPOC
{
    public class SocketAdapterObjImplementation : ISocketAdapter
    {
        public Socket Socket { get; set; }

        public SocketAdapterObjImplementation()
        {
            Socket = new Socket();
        }

        // Default Volt
        public Volt Get120Volt()
        {
            return Socket.GetVolt();
        }

        public Volt Get12Volt()
        {
            Volt v = Socket.GetVolt();
            return ConvertVolts(v, 10);
        }

        public Volt Get3Volt()
        {
            Volt v = Socket.GetVolt();
            return ConvertVolts(v, 40);
        }

        private static Volt ConvertVolts(Volt volts, int conversionValue) => new(volts.GetVolts() / conversionValue);
    }
}
