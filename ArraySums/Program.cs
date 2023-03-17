using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            //Get Array Size
            int sizeH, sizeV;
            bool validSize = false;
            Console.WriteLine("Give me the horizontal size:");
            input = Console.ReadLine();
            validSize = Int32.TryParse(input, out sizeH);
            if (!validSize){
                Console.WriteLine("Invalid Input");
                return;
            }
            Console.WriteLine("Give me the vertical size:");
            input = Console.ReadLine();
            validSize = Int32.TryParse(input, out sizeV);
            if (!validSize){
                Console.WriteLine("Invalid Input");
                return;
            }

            //Get inputs
            float[,] myFloatArray = new float[sizeV, sizeH];
            for (int i = 0; i < myFloatArray.GetLength(0); i++)
            {
                for (int j = 0; j < myFloatArray.GetLength(1); j++)
                {
                    Console.WriteLine($"Please write the value of {i}, {j}");
                    input = Console.ReadLine();
                    float inputFloat;
                    float.TryParse(input, out inputFloat);
                    myFloatArray[i, j] = inputFloat;
                }
            }

            //Calculate Values Horizontal Lines
            for (int i = 0; i < myFloatArray.GetLength(0); i++)
            {
                float sum = 0f;
                for (int j = 0; j < myFloatArray.GetLength(1); j++)
                {
                    sum += myFloatArray[i,j];
                }
                Console.WriteLine($"Value of the sum horizontal line {i} = {sum}");
            }

            //Calculate Values Vertical Lines
            for (int i = 0; i < myFloatArray.GetLength(1); i++)
            {
                float sum = 0f;
                for (int j = 0; j < myFloatArray.GetLength(0); j++)
                {
                    sum += myFloatArray[j,i];
                }
                Console.WriteLine($"Value of the sum vertical line {i} = {sum}");
            }
        }
    }
}
