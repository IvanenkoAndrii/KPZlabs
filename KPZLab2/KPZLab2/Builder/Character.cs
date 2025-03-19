using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLab2.Builder
{
    public class Character
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public string Build { get; set; }
        public string FeatureLabel { get; set; }
        public string FeatureColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothes { get; set; }
        public List<string> Inventory { get; set; }
        public List<string> GoodDeeds { get; set; }
        public List<string> EvilDeeds { get; set; }

        public Character()
        {
            Inventory = new List<string>();
            GoodDeeds = new List<string>();
            EvilDeeds = new List<string>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Height: {Height} m");
            sb.AppendLine($"Build: {Build}");
            if (!string.IsNullOrEmpty(FeatureLabel))
                sb.AppendLine($"{FeatureLabel}: {FeatureColor}");
            sb.AppendLine($"Eye Color: {EyeColor}");
            sb.AppendLine($"Clothes: {Clothes}");
            sb.AppendLine("Inventory: " + string.Join(", ", Inventory));
            if (GoodDeeds.Count > 0)
                sb.AppendLine("Good Deeds: " + string.Join(", ", GoodDeeds));
            if (EvilDeeds.Count > 0)
                sb.AppendLine("Evil Deeds: " + string.Join(", ", EvilDeeds));
            return sb.ToString();
        }
    }
}
