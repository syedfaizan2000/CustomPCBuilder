namespace CustomPCBuilder
{
    public interface ISSD
    {
        public string ModelName { get; set; }
        public int TDP { get; set; }
        public bool Mandatory { get; set; }
        public double Price { get; set; }
    }
}