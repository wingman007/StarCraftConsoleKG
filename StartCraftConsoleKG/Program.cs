using System;

namespace StartCraftConsoleKG
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit unit1 = new Unit();
            Unit unit2 = new Unit();

            Time time = new Time();
            time.AttachUnit(unit1);
            time.AttachUnit(unit2);

            Space space = new Space();
            space.RegisterUnitInSpace(unit1);
            space.RegisterUnitInSpace(unit2);

            View view = new View(space);
            

            time.Start(view);
        }
    }
}
