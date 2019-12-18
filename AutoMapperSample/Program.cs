using AutoMapper;
using System;

namespace AutoMapperSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // AutoMapper setup
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ClassA, ClassB>();
            });
            IMapper mapper = config.CreateMapper();

            // Initialize class
            ClassA classA = new ClassA()
            {
                MyProperty1 = "Test 1",
                MyProperty2 = "Test 2",
                MyProperty3 = "Test 3"
            };

            // Create map from ClassA -> ClassB
            ClassB classB = mapper.Map<ClassA, ClassB>(classA);

            // Manual mapping
            classB.MyProperty4 = "Test 4"; 

            // Test outputs
            Console.WriteLine($"Class A: MyProperty1: {classA.MyProperty1}, Class B: MyProperty1: {classB.MyProperty1}");
            Console.WriteLine($"Class A: MyProperty2: {classA.MyProperty2}, Class B: MyProperty2: {classB.MyProperty2}");
            Console.WriteLine($"Class A: MyProperty3: {classA.MyProperty3}, Class B: MyProperty3: {classB.MyProperty3}");
        }
    }
}
