using ShapeArea;

namespace SquareShape
{
    public record SquareArg : ShapeArgs
    {
        public uint Length { init; get; }
    }
}