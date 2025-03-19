using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLab2.Prototype
{
    public class Virus : ICloneable
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(double weight, int age, string name, string type)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Type = type;
            Children = new List<Virus>();
        }

        public object Clone()
        {
            Virus clone = new Virus(this.Weight, this.Age, this.Name, this.Type);
            foreach (Virus child in this.Children)
            {
                clone.Children.Add((Virus)child.Clone());
            }
            return clone;
        }

        public void DisplayInfo(int generation = 0)
        {
            string indent = new string(' ', generation * 2);
            Console.WriteLine($"{indent}Virus: {Name}, Type: {Type}, Age: {Age}, Weight: {Weight}");
            foreach (Virus child in Children)
            {
                child.DisplayInfo(generation + 1);
            }
        }
    }
}
