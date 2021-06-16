using PageUp.Model;
using System;

namespace PageUp
{
    class Program
    {
        static void Main(string[] args)
        {
            IParcel parcel = new Parcel();

            parcel.Weight = ShowMessage("Enter Weight in kg: ");
            parcel.Height = ShowMessage("Enter Height in cm: ");
            parcel.Width = ShowMessage("Enter Width in cm: ");
            parcel.Depth = ShowMessage("Enter Depth: ");

            Console.Write("Category: ");
            Console.WriteLine(parcel.Category());

            Console.Write("Cost: ");
            Console.WriteLine(parcel.Cost());
        }

        private static int ShowMessage(string message)
        {
            string input = string.Empty;

            while (!ValidValue(input))
            {
                Console.Write(message);
                input = Console.ReadLine();
            }

            return int.Parse(input);
        }

        private static bool ValidValue(string input)
        {
            int output;
            if (int.TryParse(input, out output))
            {
                return output > 0 ? true : false;
            }
            else
            {
                return false;
            }
        }
    }
}
