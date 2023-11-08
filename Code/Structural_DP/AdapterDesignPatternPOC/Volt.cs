namespace AdapterDesignPatternPOC
{
    public class Volt
    {
        private int Volts { get; set; }

        public Volt(int volts)
        {
            Volts = volts;
        }

        public int GetVolts() => Volts;
        public void SetVolts(int volts) => Volts = volts;
    }    
}
