namespace AdapterDesignPatternPOC
{
    public class Client
    {
        public static void TestClassAdapter()
        {
            Console.WriteLine("Default Power : " + Socket.GetVolt().GetVolts() + " Volts");

            ISocketAdapter sockAdapter = new SocketAdapterObjImplementation();
            //ISocketAdapter sockAdapter = new SocketAdapter();
            
            // Detects from the socket

            Volt laptopChargerAdapter = GetVolt(sockAdapter, 120);
            Console.WriteLine("Laptop Charges in " + laptopChargerAdapter.GetVolts() + " Volts \n");

            Console.WriteLine("Plugging in Mobile Adapter to charge Mobile . . .");
            
            Volt mobileChargerAdapter = GetVolt(sockAdapter, 3);
            Console.WriteLine("Mobile Charges in " + mobileChargerAdapter.GetVolts() + " Volts \n");
            
            Console.WriteLine("Plugging in Tablet Adapter to charge Tablet . . .");
            
            Volt tabletChargerAdapter = GetVolt(sockAdapter, 12);
            Console.WriteLine("Tablet Charges in " + tabletChargerAdapter.GetVolts() + " Volts");
            
        }

        private static Volt GetVolt(ISocketAdapter sockAdapter, int i)
        {
            return i switch
            {
                3 => sockAdapter.Get3Volt(),
                12 => sockAdapter.Get12Volt(),
                120 => sockAdapter.Get120Volt(),
                _ => sockAdapter.Get120Volt(),
            };
        }
    }
}
