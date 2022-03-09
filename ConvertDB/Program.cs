using ConvertDB.CenterManagment;
using System;

namespace ConvertDB
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseValueConvertor bs = new BaseValueConvertor();
            LocationConvertor lc = new LocationConvertor();
            PersonConvertor person = new PersonConvertor();
            CenterConvertor center = new CenterConvertor();
            UserConvertor user = new UserConvertor();
            DrugConvertor drug = new DrugConvertor();
            PrescriptionConvertor prescription = new PrescriptionConvertor();


            Console.Clear();
            Console.WriteLine("1- Convert BaseValues");
            Console.WriteLine("2- Convert Location");
            Console.WriteLine("3- Convert MedicalStaffs");
         //   Console.WriteLine("Option 3");
            Console.WriteLine();
            Console.Write("Click On NumPad : ");

            var originalpos = Console.CursorTop;

            var k = Console.ReadKey();
            var i = 3;

            while (k.KeyChar != 'q')
            {
                if (k.Key == ConsoleKey.NumPad1)
                {
                    switch(k.Key)
                    {
                        case ConsoleKey.NumPad1:
                            //   bs.Convert();
                            //   lc.Convert();
                            //  person.Convert();
                            //  center.Convert();
                               user.Convert();
                            // drug.Convert();
                         //   prescription.Convert();

                            break;

                        case ConsoleKey.NumPad2:
                            center.Convert();
                            break;
                    }
                    i++;
                }

                Console.SetCursorPosition(8, originalpos);
                k = Console.ReadKey();
            }
        }
    }
}
