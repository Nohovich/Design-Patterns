namespace ProtoType_Pattern
{
    public class Point : IProto<Point>
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"X : {X} Y : {Y}";
        }

        /// <summary>
        /// making a protoType known as a clone that don't share the same space in the memory,
        /// so the values been changed won't inflect the original object
        /// </summary>
        /// <returns></returns>
        public Point Clone()
        {
            Point result = new Point(this.X, this.Y);
            return result;
        }
    }
}