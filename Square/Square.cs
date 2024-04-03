using ShapeArea;

namespace SquareShape
{
    public class Square : Shape<SquareArg>
    {
        #region Public Constructors

        public Square(SquareArg args) : base(args)
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public override float Area => args.Length * args.Length;

        #endregion Public Properties
    }
}