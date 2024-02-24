using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main()
    {
        NetworkInterface nic = NetworkInterface.GetAllNetworkInterfaces()[0];
        PhysicalAddress macAddress = nic.GetPhysicalAddress();
        string macString = string.Join("-", macAddress.GetAddressBytes().Select(b => b.ToString("X2")));
        Console.WriteLine("L'adresse MAC de {0} est {1}", nic.Description, macString);
    }
}