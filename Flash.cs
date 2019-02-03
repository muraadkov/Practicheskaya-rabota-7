using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR6
{
    public class Flash : Storage
    {
        public int SpeedUSB30 { get; set; }
        public int MemorySize { get; set; }
        public double FreeSpace { get; set; }
        public Flash(string name)
        {
            SpeedUSB30 = 70;
            MemorySize = 4000;
            Name = name;
            Model = "память " + (MemorySize / 1000) + "GB" + ", скорость USB 3.0";
        }
        public override double GetMemoryCapacity()
        {
            return MemorySize;
        }
        public override void CopyDateToTheDevice()
        {
            int sizeOfFile = 565000;
            int file = 780;
            int filesSize = 0;
            int timeSpend = 0;
            while (filesSize < MemorySize && filesSize + file < MemorySize)
            {
                filesSize += file;
            }

            timeSpend = filesSize / SpeedUSB30;
            FreeSpace = MemorySize - filesSize;

            int commonTimeSpend = sizeOfFile / timeSpend;
            int getNumbersOfDevices = sizeOfFile / filesSize;
            Console.WriteLine("Требуется флешек: " + getNumbersOfDevices);
            Console.WriteLine("Времени потрачено: " + commonTimeSpend + " минут");
        }
        public override double GetInfoAboutFreeMemoryOnDevice()
        {
            return FreeSpace;
        }
        public override string GetFullInfoAboutDevice()
        {
            return "Информация о устройстве: " + "\nНазвание: " + Name +"\nПамять устройства: " + MemorySize + "\nСкорость: " + SpeedUSB30 + "mbps" + "\nМодель: " + Model + "\nОставшееся место: " + FreeSpace;
        }
    }
}
