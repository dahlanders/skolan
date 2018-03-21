using System;

namespace ElevatorLab
{
    public class Elevator
    {
        public string Name { get; }
        public int LowestFloor { get; }
        public int HighestFloor { get; }

        public int CurrentFloor { get; private set; }
        public uint UntilMaintainance { get; private set; }

        public int CountFloors => HighestFloor - LowestFloor;

        public bool PowerIsOn => UntilMaintainance > 0;

        public Elevator(string name, int lowestFloor, int highestFloor, int startFloor, uint untilMaintainance)
        {
            if (highestFloor < lowestFloor)
                throw new ArgumentException("Highest floor can't be lower than lowest floor");

            if (startFloor < lowestFloor || startFloor > highestFloor)
                throw new ArgumentException("Start floor has to be between lowest floor and highest floor");

            Name = name;
            LowestFloor = lowestFloor;
            HighestFloor = highestFloor;
            CurrentFloor = startFloor;
            UntilMaintainance = untilMaintainance;
        }


        public Elevator(string name, int lowestFloor, int highestFloor) : this(name, lowestFloor, highestFloor, lowestFloor, 10)
        {
        }

        public void GoUp()
        {
            if (PowerIsOn)
            {
                if (CurrentFloor < HighestFloor)
                {
                    CurrentFloor++;
                    WearAndTear();
                }
            }

        }

        public void GoDown()
        {
            if (PowerIsOn)
            {
                if (CurrentFloor > LowestFloor)
                {
                    CurrentFloor--;
                    WearAndTear();
                }
            }
        }

        private void WearAndTear()
        {
            if (UntilMaintainance > 0)
                UntilMaintainance--;
        }

        public string Report()
        {
            string isOn = PowerIsOn ? "Hissen är på" : "Hissen är av";
            return $"Hissen {Name} är på våning {CurrentFloor}. {isOn}. Tills underhåll: {UntilMaintainance}";
        }
    }
}
