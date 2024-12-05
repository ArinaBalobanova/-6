using System;

namespace HomeWork.Classes
{
    class BuldingParameters
    {
        private static int lastnumberOfBuilding = 0; // Последний использованный номер здания
        private int numberOfBuilding;
        private double height;
        private int floors;
        private int apartments;
        private int entrances;
        public BuldingParameters(double height, int floors, int apartments, int entrances)
        {
            this.numberOfBuilding = GenerateNumberOfBuilding();
            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
            this.entrances = entrances;
        }
        private static int GenerateNumberOfBuilding()
        {
            return ++lastnumberOfBuilding;
        }
        public double FloorHeight()// высота этажа
        {
            return height / floors;
        }
        public int ApartmentsPerEntrance()// количество квартир в подъезде
        {
            return apartments / entrances;
        }
        public int ApartmentsPerFloor() //количество квартир на этаже
        {
            return apartments / floors;
        }
        public int CalculateApartmentsPerFloor()
        {
            return apartments / floors;
        }
        public int GetBuildingId()
        {
            return numberOfBuilding;
        }

        public double GetHeight()
        {
            return height;
        }

        public int GetFloors()
        {
            return floors;
        }

        public int GetApartments()
        {
            return apartments;
        }

        public int GetEntrances()
        {
            return entrances;
        }
        public void PrintBuildingInfo()
        {
            Console.WriteLine($"Уникальный номер здания: {numberOfBuilding}");
            Console.WriteLine($"Высота здания: {height}");
            Console.WriteLine($"Этажность: {floors}");
            Console.WriteLine($"Количество квартир: {apartments}");
            Console.WriteLine($"Количество подъездов: {entrances}");
        }
    }
}
