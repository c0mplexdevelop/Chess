using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess;

internal class PieceFactory
{
    private PieceColorEnum pieceColor;
    internal PieceFactory(PieceColorEnum pieceColor)
    {
        this.pieceColor = pieceColor;
    }

    Piece CreatePawn(int row, int col)
    {
        Piece pawn = new Piece
        {
            PieceColor = pieceColor,
            PieceType = PieceTypeEnum.PAWN,
            Row = row,
            Column = col,
        };
        return pawn;
    }

    Piece CreateRook(int row, int col)
    {
        Piece rook = new Piece
        {
            PieceColor = pieceColor,
            PieceType = PieceTypeEnum.ROOK,
            Row = row,
            Column = col,
        };
        return rook;
    }

    Piece CreateKnight(int row, int col)
    {
        Piece knight = new Piece
        {
            PieceColor = pieceColor,
            PieceType = PieceTypeEnum.HORSE,
            Row = row,
            Column = col,
        };
        return knight;
    }

    Piece createBishop(int row, int col)
    {
        Piece bishop = new Piece
        {
            PieceColor = pieceColor,
            PieceType = PieceTypeEnum.BISHOP,
            Row = row,
            Column = col,
        };
        return bishop;
    }

    Piece createQueen(int row, int col)
    {
        Piece queen = new Piece
        {
            PieceColor = pieceColor,
            PieceType = PieceTypeEnum.QUEEN,
            Row = row,
            Column = col
        };

        return queen;
    }

    Piece createKing(int row, int col)
    {
        Piece king = new Piece
        {
            PieceColor = pieceColor,
            PieceType = PieceTypeEnum.KING,
            Row = row,
            Column = col,
        }

        return king;
    }
}
