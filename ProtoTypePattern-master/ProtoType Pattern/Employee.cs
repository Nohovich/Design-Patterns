namespace ProtoType_Pattern
{
    public class Employee
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        public override string ToString()
        {
            return $"{Id} {FName} {LName}";
        }
    }
}