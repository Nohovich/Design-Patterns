using System;

namespace ProtoType_Pattern
{
    class LineW : ICloneable
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }

        public LineW(Point p1, Point p2)
        {
            P1 = p1;
            P2 = p2;
        }

        public override string ToString()
        {
            return $"P1 {P1} P2 {P2}";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}