namespace ShapeArea
{
    public abstract class Shape<T>(T args)
    {
        #region Public Properties

        public abstract float Area { get; }
        public T args { get; internal set; } = args;

        public string Name => GetType().Name;

        #endregion Public Properties
    }
}