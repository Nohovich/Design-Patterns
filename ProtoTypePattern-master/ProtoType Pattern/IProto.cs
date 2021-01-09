namespace ProtoType_Pattern
{
    /// <summary>
    /// interface for cloning itself
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IProto<T>
    {
        T Clone();
    }
}