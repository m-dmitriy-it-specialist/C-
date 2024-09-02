using System;

namespace vehicles_types
{
    class cadillac : ground_vehicle
    {
        decimal fuelAmount = 45.5m;
        public int CurrentMileage { get; set; } = 1;

        public override bool Move()
        {
            bool ThisIsMoving = base.Move();
            while (ThisIsMoving == false)
            {
                ThisIsMoving = true;
            }
            return ThisIsMoving;
        }
        public void Move_MilesFuel()
        {
            --fuelAmount;
            CurrentMileage++;
        }
        public void fueled()
        {
            Console.WriteLine("It is a fueldriving");

        }
    }
}
