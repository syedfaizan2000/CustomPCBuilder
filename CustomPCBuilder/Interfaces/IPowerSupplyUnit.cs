namespace CustomPCBuilder
{
    public interface IPowerSupplyUnit
    {
        public string ModelName { get; set; }
        public int TDP { get; set; }
        public bool Mandatory { get; set; }
        public double Price { get; set; }
    }
}