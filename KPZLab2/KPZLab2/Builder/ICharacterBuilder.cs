using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLab2.Builder
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetHeight(double height);
        ICharacterBuilder SetBuild(string build);
        ICharacterBuilder SetFeatureLabel(string label);
        ICharacterBuilder SetFeatureColor(string color);
        ICharacterBuilder SetEyeColor(string eyeColor);
        ICharacterBuilder SetClothes(string clothes);
        ICharacterBuilder SetInventory(List<string> inventory);
        ICharacterBuilder AddGoodDeed(string deed);
        ICharacterBuilder AddEvilDeed(string deed);
        Character Build();
    }
}
