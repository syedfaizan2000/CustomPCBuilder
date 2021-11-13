namespace CustomPCBuilder
{
    public interface IMotherboard
    {
        public string ModelName { get; set; }
        public string Socket { get; set; }
        public string RamType { get; set; }
        public bool Mandatory { get; set; }
        public double Price { get; set; }
        public string Size { get; set; }
    }
}