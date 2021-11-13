using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomPCBuilder.Interfaces;
namespace CustomPCBuilder
{
    class UI
    {
        private int Choice { get; set; }
        List<IProcessor> ProcessorList;
        List<IMotherboard> MotherboardList;
        List<IRam> RamList;
        List<IChasis> ChasisList;
        List<IPowerSupplyUnit> PSUList;

        public IProcessor Processor;
        public IMotherboard Motherboard;
        public IRam Ram;
        public IChasis Chasis;
        public IPowerSupplyUnit PowerSupplyUnit;

        //IPersonalComputerBuilder PersonalComputer = new PersonalComputerBuilder();

        public UI()
        {
           
            ProcessorList = new List<IProcessor>();
            MotherboardList = new List<IMotherboard>();
            PSUList = new List<IPowerSupplyUnit>();
            RamList = new List<IRam>();
            ChasisList = new List<IChasis>();
            InitializeProcessorList();
            InitializeMotherList();
            InitializePowerSupplyList();
            InitializeRamList();
            InitializeChasisList();
        }

        public void MainMenu()
        {
            Console.WriteLine("Build Your Custom PC!!!");
            Console.WriteLine("1- Processor");
            Console.WriteLine("2- Motherboard");
            Console.WriteLine("3- Ram");
            Console.WriteLine("4- Chasis");
            Console.WriteLine("5- Psu");
            Console.WriteLine("6- Build Your Personal Computer");
            Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    DisplayProcessors();
                    break;
                case 2:
                    DisplayMotherboards();
                    break;
                case 3:
                    DisplayRams();
                    break;
                case 4:
                    DisplayChasis();
                    break;
                case 5:
                    DisplayPowerSupplyUnit();
                    break;
                case 6:
                    BuildPC();
                    MainMenu();
                    break;
                default:
                    break;
            }

        }

       
        void DisplayProcessors()
        {
            int choice;
            for (int i = 0; i < ProcessorList.Count; i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("\nProcessor - " + (i + 1));
                Console.WriteLine("Name : " + ProcessorList[i].ModelName);
                Console.WriteLine("Cores : " + ProcessorList[i].Cores);
                Console.WriteLine("Threads : " + ProcessorList[i].Threads);
                Console.WriteLine("Socket : " + ProcessorList[i].Socket);
                Console.WriteLine("Price : " + ProcessorList[i].Price);
            }
            Console.WriteLine("\n1- Add Processor");
            Console.WriteLine("2- Main Menu");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Product#");
                    int ProductNumber = Convert.ToInt32(Console.ReadLine());
                    Processor = ProcessorList[ProductNumber - 1];
                    Console.WriteLine("Added Successfully");
                    MainMenu();
                    break;
                case 2:
                    MainMenu();
                    break;
            }

        }
        void DisplayMotherboards()
        {
            int choice;
            for (int i = 0; i < MotherboardList.Count; i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("\nMotherboard - " + (i + 1));
                Console.WriteLine("Name : " + MotherboardList[i].ModelName);
                Console.WriteLine("Socket : " + MotherboardList[i].Socket);
                Console.WriteLine("Price : " + MotherboardList[i].Price);
            }
            Console.WriteLine("\n1- Add Motherboard");
            Console.WriteLine("2- Main Menu");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Product#");
                    int ProductNumber = Convert.ToInt32(Console.ReadLine());
                    Motherboard = MotherboardList[ProductNumber - 1];
                    Console.WriteLine("Added Successfully");
                    MainMenu();
                    break;
                case 2:
                    MainMenu();
                    break;
            }
        }
        void DisplayRams()
        {
            int choice;
            for (int i = 0; i < RamList.Count; i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("\n RAM - " + (i + 1));
                Console.WriteLine("Name : " + RamList[i].ModelName);
                Console.WriteLine("Type : " + RamList[i].Type);
                Console.WriteLine("Price : " + RamList[i].Price);
            }
            Console.WriteLine("\n1- Add RAM");
            Console.WriteLine("2- Main Menu");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Product#");
                    int ProductNumber = Convert.ToInt32(Console.ReadLine());
                    Ram = RamList[ProductNumber - 1];
                    Console.WriteLine("Added Successfully");
                    MainMenu();
                    break;
                case 2:
                    MainMenu();
                    break;
            }
        }
        void DisplayChasis()
        {
            int choice;
            for (int i = 0; i < ChasisList.Count; i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("\n Chasis - " + (i + 1));
                Console.WriteLine("Name : " + ChasisList[i].ModelName);
                Console.WriteLine("Price : " + ChasisList[i].Price);
            }
            Console.WriteLine("\n1- Add RAM");
            Console.WriteLine("2- Main Menu");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Product#");
                    int ProductNumber = Convert.ToInt32(Console.ReadLine());
                    Chasis = ChasisList[ProductNumber - 1];
                    Console.WriteLine("Added Successfully");
                    MainMenu();
                    break;
                case 2:
                    MainMenu();
                    break;
            }
        }
        void DisplayPowerSupplyUnit()
        {
            int choice;
            for (int i = 0; i < PSUList.Count; i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("\n Power Supply Unit - " + (i + 1));
                Console.WriteLine("Name : " + PSUList[i].ModelName);
                Console.WriteLine("Price : " + PSUList[i].Price);
            }
            Console.WriteLine("\n1- Add PSU");
            Console.WriteLine("2- Main Menu");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Product#");
                    int ProductNumber = Convert.ToInt32(Console.ReadLine());
                    PowerSupplyUnit =  PSUList[ProductNumber - 1];
                    Console.WriteLine("Added Successfully");
                    MainMenu();
                    break;
                case 2:
                    MainMenu();
                    break;
            }
        }

        void InitializeProcessorList()
        {
            IProcessor P1 = new Processor();
            P1.ModelName = "Ryzen 5 3600";
            P1.Cores = 6;
            P1.Threads = 12;
            P1.TDP = 65;
            P1.Socket = "AM4";
            P1.Price = 35000;

            IProcessor P2 = new Processor();
            P2.ModelName = "Ryzen 7 3700x";
            P2.Cores = 8;
            P2.Threads = 16;
            P2.TDP = 100;
            P2.Socket = "AM4";
            P2.Price = 55000;

            ProcessorList.Add(P1);
            ProcessorList.Add(P2);
        }
        void InitializeMotherList()
        {
            IMotherboard M1 = new Motherboard();
            M1.ModelName = "MSI B450 Tomahawk";
            M1.Socket = "AM4";
            M1.Price = 20000;

            IMotherboard M2 = new Motherboard();
            M2.ModelName = "MPG X570 GAMING PLUS";
            M2.Socket = "AM4";
            M2.Price = 35000;

            MotherboardList.Add(M1);
            MotherboardList.Add(M2);
        }

        void InitializeRamList()
        {
            IRam obj1 = new Ram();
            obj1.ModelName = "Corsair VENGEANCE LPX 8GB (1 x 8GB) DDR4 DRAM 2400MHz";
            obj1.Price = 7000;

            IRam obj2 = new Ram();
            obj2.ModelName = "VENGEANCE® LPX 8GB (1 x 8GB) DDR4 DRAM 3000MHz";
            obj2.Price = 8500;

            RamList.Add(obj1);
            RamList.Add(obj2);
        }

        void InitializePowerSupplyList()
        {
            IPowerSupplyUnit obj1 = new PowerSupplyUnit();
            obj1.ModelName = "Corsair VS550 550 Watt 80 Plus Power Supply";
            obj1.Price = 5500;

            IPowerSupplyUnit obj2 = new PowerSupplyUnit();
            obj2.ModelName = "RMx Series™ RM850x — 850 Watt 80 PLUS® Gold Certified Fully Modular PSU";
            obj2.Price = 27000;

            PSUList.Add(obj1);
            PSUList.Add(obj2);
        }

        void InitializeChasisList()
        {
            IChasis obj1 = new Chasis();
            obj1.ModelName = "H510 | NZXT";
            obj1.Price = 14000;

            IChasis obj2 = new Chasis();
            obj2.ModelName = "H510 Elite";
            obj2.Price = 17000;

            ChasisList.Add(obj1);
            ChasisList.Add(obj2);
        }

      void BuildPC()
        {
            if(Processor == null)
            {
                Console.WriteLine("Processor Is Required");
                MainMenu();
            }
            else if (Motherboard == null)
            {
                Console.WriteLine("Motherboard Is Required");
                MainMenu();
            }
            if (Ram == null)
            {
                Console.WriteLine("Ram Is Required");
                MainMenu();
            }
            if (Chasis == null)
            {
                Console.WriteLine("Chasis Is Required");
                MainMenu();
            }
            if (PowerSupplyUnit == null)
            {
                Console.WriteLine("PowerSupplyUnit Is Required");
                MainMenu();
            }

            var builder = new PersonalComputerBuilder();
            Console.WriteLine("Building Your PC......");
            builder.setMotherboard(Motherboard).setRam(Ram).setChasis(Chasis).setPowerSupplyUnit(PowerSupplyUnit).setProcessor(Processor);
            Console.WriteLine("Your Custom Pc Has been Build\n Total Cost Of Your Build = " + builder.Build().CalculateCost());

        }
    }
}
