using System;
using System.Collections.Generic;

namespace DemoStrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Declaration
            var strategies = new Dictionary<EnumPerson, IPerson>
            {
                { EnumPerson.Asian, new AsianPerson() },
                { EnumPerson.Europe, new EuropePerson() }
            };

            //Action
            var param = new ParamModel
            {
                Name = "Nam",
                Description = "Nam Desc"
            };

            strategies[EnumPerson.Europe].DoWork(param);
            //strategies[EnumPerson.Asian].DoWork(param);

            Console.ReadLine();
        }
    }

    enum EnumPerson
    {
        Asian,
        Europe
    }

    class ParamModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    interface IPerson
    {
        void DoWork(ParamModel model);
    }

    class AsianPerson : IPerson
    {
        public void DoWork(ParamModel model)
        {
            Console.WriteLine("Asian Person do work - " + model.Name);
        }
    }

    class EuropePerson : IPerson
    {
        public void DoWork(ParamModel model)
        {
            Console.WriteLine("Europe Person do work - " + model.Name);
        }
    }
}
