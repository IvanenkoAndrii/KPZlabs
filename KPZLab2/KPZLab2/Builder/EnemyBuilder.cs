using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLab2.Builder
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private readonly Character _character;

        public EnemyBuilder()
        {
            _character = new Character();
        }

        public ICharacterBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }

        public ICharacterBuilder SetHeight(double height)
        {
            _character.Height = height;
            return this;
        }

        public ICharacterBuilder SetBuild(string build)
        {
            _character.Build = build;
            return this;
        }

        public ICharacterBuilder SetFeatureLabel(string label)
        {
            _character.FeatureLabel = label;
            return this;
        }

        public ICharacterBuilder SetFeatureColor(string color)
        {
            _character.FeatureColor = color;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            _character.EyeColor = eyeColor;
            return this;
        }

        public ICharacterBuilder SetClothes(string clothes)
        {
            _character.Clothes = clothes;
            return this;
        }

        public ICharacterBuilder SetInventory(List<string> inventory)
        {
            _character.Inventory = inventory;
            return this;
        }

        public ICharacterBuilder AddGoodDeed(string deed)
        {
            return this;
        }

        public ICharacterBuilder AddEvilDeed(string deed)
        {
            _character.EvilDeeds.Add(deed);
            return this;
        }

        public Character Build()
        {
            return _character;
        }
    }
}
