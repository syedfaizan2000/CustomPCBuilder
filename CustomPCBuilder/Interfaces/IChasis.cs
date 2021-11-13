namespace CustomPCBuilder
{
    public interface IChasis 
    {
        public string ModelName { get; set; }
        public bool Mandatory { get; set; }
        public double Price { get; set; }
    }
}