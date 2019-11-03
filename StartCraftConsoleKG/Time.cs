using System;
using System.Collections.Generic;
using System.Text;

namespace StartCraftConsoleKG
{
    class Time
    {
        public Unit[] units { get; set; }

        public Time()
        {
            units = new Unit[600];
        }

        public void Start(View view)
        {
            while (true)
            {               
                Tick();
                view.RenderWorld();
            }
        }

        public void Tick(int period = 100) {
            for (int i = 0; i < units.Length; i++)
            {
                if (units[i] == null) continue;
                // units[i].Move(1, 1); // this should be a callback
                units[i].Move(1,1);
            }
            System.Threading.Thread.Sleep(period);
        }

        public void AttachUnit(Unit unit)
        {
            int i = 0;
            for (i = 0; i < units.Length; i++)
            {
                if (units[i] == null) break;
            }
            units[i] = unit;
        }
    }
}
