module LibraryTests

open FsCheck.Xunit

type ChessPiece = King | Queen | Pawn | Rook | Bishop | Knight

// Works
[<Property>]
let test1 (piece : ChessPiece) = 
    true

// Doesn't work
[<Property>]
let test2 (suit : LibraryUnderTest.Suit) = 
    true