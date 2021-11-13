﻿namespace CustomPCBuilder
{
    public interface IGpu
    {
        public string ModelName { get; set; }
        public string Type { get; set; }
        public int TDP { get; set; }
        public bool Mandatory { get; set; }
        public double Price { get; set; }
    }
}