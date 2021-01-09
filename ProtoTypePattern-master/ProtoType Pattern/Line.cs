namespace ProtoType_Pattern
{
    public class Line : IProto<Line>
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }

        public Line(Point p1, Point p2)
        {
            P1 = p1;
            P2 = p2;
        }

        /// <summary>
        /// making a protoType known as a clone that don't share the same space in the memory,
        /// so the values been changed won't inflect the original object
        /// </summary>
        /// <returns></returns>
        public Line Clone()
        {
            // were not passing reference type values so the object won't share the same space in the memory
            // we are making the point return a clone of itself
            Line result = new Line(P1.Clone(), P2.Clone());
            return result;

            //return (Line)this.MemberwiseClone(); // good only for value types
        }

        public override string ToString()
        {
            return $"P1 {P1} P2 {P2}";
        }
    }
}