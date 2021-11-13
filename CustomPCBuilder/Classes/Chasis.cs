namespace CustomPCBuilder
{
    internal class Chasis : IChasis
    {
        public string ModelName { get  ; set  ; }
        public string Socket { get  ; set  ; }
        public int Cores { get  ; set  ; }
        public int Threads { get  ; set  ; }
        public int TDP { get  ; set  ; }
        public bool Mandatory { get  ; set  ; }
        public double Price { get  ; set  ; }
    }
}