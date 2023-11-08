namespace AdapterDesignPatternPOC
{
    public class Socket
    {
        public static Volt GetVolt()
        {
            return new Volt(120);
        }
    }
}
