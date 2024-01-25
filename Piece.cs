using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess;

internal class Piece
{
    public PieceTypeEnum PieceType { get; init; }
    public PieceColorEnum PieceColor { get; init; }

    public int Row {  get; set; }
    public int Column { get; set; }

    public Tuple<int, int> Position { get { return Tuple.Create(Row, Column) } }
}
