public class CellAndRelativePosition
{

    public Cell cell;
    public Direction direction;

    public enum Direction
    {
        North,
        South,
        East,
        West
    }

    public CellAndRelativePosition (Cell cell, Direction direction)
    {
        this.cell = cell;
        this.direction = direction;
    }
}
