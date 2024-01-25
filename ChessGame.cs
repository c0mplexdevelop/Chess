using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess;
internal class ChessGame
{
    private static readonly int MAX_ROW = 8;
    private static readonly int MAX_COL = 8;
    private Piece[][] board = CreateBoard();

    private PieceFactory whitePieceFactory = new PieceFactory(PieceColorEnum.WHITE);
    private PieceFactory blackPieceFactory = new PieceFactory(PieceColorEnum.BLACK);

    public readonly Piece[][] Board { get { return board; } }

    private Piece[][] CreateBoard()
    {
        Piece[][] tempBoard = new Piece[][](8);
        for (int row = 0; row < MAX_ROW; row++)
        {
            var columnBoard = new Piece[8];
            tempBoard[row] = columnBoard;
        } 

        return tempBoard;
    }

    private void FillBoardWithPieces()
    {
        FillPawns();
    }

    private void FillPawns()
    {
        int BLACK_PAWN_ROW = 1;
        int WHITE_PAWN_ROW = MAX_ROW - 1;

       

        for(int col = 0; col < MAX_COL; col++)
        {
            
        }
    }
}

