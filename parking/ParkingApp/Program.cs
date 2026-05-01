using System;

class ParkingSlot
{
    public bool IsOccupied { get; private set; }
    public string? VehicleNumber { get; private set; }

    public void Park(string vehicleNumber)
    {
        if (IsOccupied)
        {
            Console.WriteLine("Slot is already occupied.");
            return;
        }

        if (string.IsNullOrWhiteSpace(vehicleNumber))
        {
            Console.WriteLine("Vehicle number cannot be empty.");
            return;
        }

        IsOccupied = true;
        VehicleNumber = vehicleNumber;
        Console.WriteLine("Vehicle parked: " + vehicleNumber);
    }

    public void Unpark()
    {
        if (!IsOccupied)
        {
            Console.WriteLine("Slot already empty.");
            return;
        }

        Console.WriteLine("Vehicle removed: " + VehicleNumber);
        IsOccupied = false;
        VehicleNumber = null;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ParkingSlot slot = new ParkingSlot();

        slot.Park("DHAKA-1234");
        slot.Unpark();
    }
}