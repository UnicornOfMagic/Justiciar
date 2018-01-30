using System;
namespace Justiciar
{
    public class Item
    {

        Rarity.Levels rarity;
        Adjectives.Leading leadingAdj;
        Adjectives.Ending endingAdj;
        Items.Types itemType;

        public Item(Rarity.Levels rarity, Adjectives.Leading leadingAdj, Items.Types itemType, Adjectives.Ending endingAdj)
        {
            this.rarity = rarity;
            this.leadingAdj = leadingAdj;
            this.itemType = itemType;
            this.endingAdj = endingAdj;
        }

        public Item() {
            //How to get a random value from enum
            Array values = Enum.GetValues(typeof(Rarity.Levels));
            Random random = new Random();
            Rarity.Levels randomRarity = (Rarity.Levels)values.GetValue(random.Next(values.Length));

            rarity = randomRarity;
            leadingAdj = Adjectives.Leading.Flaming;
            itemType = Items.Types.Sword;
            endingAdj = Adjectives.Ending.Justice;
        }

        public override string ToString()
        {
            return (rarity + " " + leadingAdj + " " + itemType + " of " + endingAdj);
        }
    }
}
