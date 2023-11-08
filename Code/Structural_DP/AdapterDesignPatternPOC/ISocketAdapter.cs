namespace AdapterDesignPatternPOC
{
    public interface ISocketAdapter
    {
        public Volt Get12Volt();
        public Volt Get120Volt();
        public Volt Get3Volt();
    }
}
