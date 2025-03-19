using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLab2.Builder
{
    public class CharacterDirector
    {
        public void ConstructHero(ICharacterBuilder builder)
        {
            builder.SetName("Rastle")
                   .SetHeight(1.65)
                   .SetBuild("Athletic")
                   .SetFeatureLabel("Hair Color")
                   .SetFeatureColor("Black")
                   .SetEyeColor("Blue")
                   .SetClothes("Golden Armor")
                   .SetInventory(new List<string> { "Sword", "Shield", "Healing Potion" })
                   .AddGoodDeed("Saved a village")
                   .AddGoodDeed("Rescued a captive");
        }

        public void ConstructEnemy(ICharacterBuilder builder)
        {
            builder.SetName("Dragon")
                   .SetHeight(9.2)
                   .SetBuild("Muscular")
                   .SetFeatureLabel("Scales Color")
                   .SetFeatureColor("Red")
                   .SetEyeColor("Red")
                   .SetClothes("Dark Cloak")
                   .SetInventory(new List<string> { "Fire", "Ancient Civilization Armor", "Cursed Amulet" })
                   .AddEvilDeed("Destroyed a town")
                   .AddEvilDeed("Stole sacred relics");
        }
    }
}
