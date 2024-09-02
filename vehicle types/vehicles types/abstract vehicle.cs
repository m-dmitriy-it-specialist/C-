using System;

//+ Реализовать в объектной модели транспорта один абстрактный класс транспортное средство – и набор интерфейсов(работающее на топливе, перевозящее пассажиров и т.п.), 

namespace vehicles_types
{
    abstract class abstract_vehicle : Ifueled
    {
        public void fueled()
        {
            throw new NotImplementedException("Working on fuel");
        }

        public void status_moving()
        {
            Console.WriteLine("Vehicle have engine");
        }

    }
}
