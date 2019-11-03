using System;
using System.Collections.Generic;
using System.Text;

namespace StartCraftConsoleKG
{
    class View
    {
        public Space Space { get; set; }
        public View(Space space)
        {
            Space = space;
        }
        public void RenderWorld()
        {
            Console.Clear();
            RenderUnits();
        }

        public void RenderUnits()
        {
            Unit unit;
            for (int i = 0; i < Space.CartazianCoordinates.GetLength(0); i++)
            {
                for (int j = 0; j < Space.CartazianCoordinates.GetLength(1); j++)
                {
                    for (int n = 0; n < 600; n++)
                    {
                        unit = Space.CartazianCoordinates[i, j, n];
                        if (unit == null) continue;
                        RenderIndividualunit(unit);
                    }
                }
            }
        }

        public void RenderIndividualunit(Unit unit)
        {
            Console.SetCursorPosition((unit.PositionX < 80) ? unit.PositionX : 80, (unit.PositionY < 30) ? unit.PositionY : 30);
            Console.Write("#");
            // Console.ForegroundColor = (ConsoleColor)unit.Color;
            // Console.Write(unit.Avatar);
        }
    }
}
