using System;
using System.Collections.Generic;
using System.Text;

namespace StartCraftConsoleKG
{
    class Unit
    {
        //private int stamina;
        //public int MyProperty { 
        //    get { return stamina;  }
        //    set { stamina = value; } 
        //}
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Stamina { get; set; }
        public int DamageToEnemy { get; set; }

        public Unit()
        {

        }
        public void Move(int directionX, int directionY)
        {
            if (directionX >= 0)
            {
                if (PositionX < 80) PositionX += 1;
            }
            else
            {
                if (PositionX > 0) PositionX -= 1;
            }

            if (directionY >= 0)
            {
                if (PositionY < 30) PositionY += 1;
            }
            else
            {
                if (PositionY > 0) PositionY -= 1;
            }
        }

        public void Attack(Unit enemy)
        {
            enemy.Stamina -= this.DamageToEnemy;
        }
    }
}
