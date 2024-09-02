/*
+ Ввести в модель классов транспорта виртуальные методы в базовом классе(например, Move) и переопределить их в производных классах.
унаследовать от созданных интерфейсов и асбтрактного существующие классы.
 */
namespace vehicles_types
{

    class ground_vehicle : abstract_vehicle, Ifueled
    {
        public virtual bool Move()
        {
            bool IsMove = false;
            return IsMove;
        }
        public string wheels = "Wheels make spinnning";
        public decimal fuelTankVolume = 80.5m;
        public int MaxMileage { get; } = 100;

    }
}
