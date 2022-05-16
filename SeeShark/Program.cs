using System;


namespace SeeShark // Note: actual namespace depends on the project name.
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var addedNumbers = ExampleMethods.add_numbers(10, 5);
            Console.WriteLine(addedNumbers);

            var exampleStruct = ExampleMethods.get_example_struct();
            Console.WriteLine($"{exampleStruct.x}, {exampleStruct.y}");
            
            Console.ReadLine();
        }
    }
}