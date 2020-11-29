﻿using System;

namespace TddChessEngineLib
{
    // возможность первого хода
    // 1. Есть ли кто-то в точке назначения
    // 2. Границы карты
    // 3. Направление
    // 4. Ввести переменную сходила ли пешка или нет
    // 5. (пока за скобки) Живая или нет
    // 6. Длина шага 2 или 1
    public class Pawn
    {
        public string CurrentPosition { get; private set; }
        public FigureColor FigureColor { get; }

        public Pawn(string initialPosition, FigureColor figureColor)
        {
            CurrentPosition = initialPosition;
            FigureColor = figureColor;
        }

        public void Turn(string startPosition, string finalPosition)
        {
            int startLine =  Convert.ToInt32(startPosition[1].ToString());
            int finalLine = Convert.ToInt32(finalPosition[1].ToString());
            // код хода для чёрной фигуры
            if(FigureColor == FigureColor.Black)
            {
                if(finalLine < startLine)
                {
                    CurrentPosition = finalPosition;    
                }
                else{
                throw new ArgumentException("Black Pawn can't go back");
                }
                
            }
            else
            {
                if(finalLine > startLine)
                {
                    if ( finalLine>=5 && 
                    finalLine - startLine>1){
                    throw new ArgumentException("White Pawn can't go to far");
                    }
                    else{
                    CurrentPosition = finalPosition;    
                    }
                }
                else{
                throw new ArgumentException("White Pawn can't go back");
                }
            }

            // код хода для белой фигуры (пока без проверок)
            CurrentPosition = finalPosition;
        }
    }

    public enum FigureColor 
    {
        White,
        Black
    }
}
