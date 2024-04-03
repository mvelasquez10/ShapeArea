namespace ShapeArea
{
    public abstract record ShapeArgs
    {
        public string Name => GetType().Name;
    }
}