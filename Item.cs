using System;
using Justiciar.Enums;

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

        public Item()
        {
            //How to get a random value from enum
            Array rarities = Enum.GetValues(typeof(Rarity.Levels));
            Array leadAdjs = Enum.GetValues(typeof(Adjectives.Leading));
            Array endAdjs = Enum.GetValues(typeof(Adjectives.Ending));
            Array itemTypes = Enum.GetValues(typeof(Items.Types));
            Rarity.Levels randomRarity = GetRandomRarity(rarities);
            Adjectives.Leading randomLeadAdj = GetRandomLeadingAdj(leadAdjs);
            Adjectives.Ending randomEndAdj = GetRandomEndingAdj(endAdjs);
            Items.Types randomItemType = GetRandomItemType(itemTypes);

            rarity = randomRarity;
            leadingAdj = randomLeadAdj;
            itemType = randomItemType;
            endingAdj = randomEndAdj;
        }

        static Rarity.Levels GetRandomRarity(Array values)
        {
            Random random = new Random();
            return (Rarity.Levels)values.GetValue(random.Next(values.Length));
        }

        static Adjectives.Leading GetRandomLeadingAdj(Array values)
        {
            Random random = new Random();
            return (Adjectives.Leading)values.GetValue(random.Next(values.Length));
        }

        static Adjectives.Ending GetRandomEndingAdj(Array values)
        {
            Random random = new Random();
            return (Adjectives.Ending)values.GetValue(random.Next(values.Length));
        }

        static Items.Types GetRandomItemType(Array values)
        {
            Random random = new Random();
            return (Items.Types)values.GetValue(random.Next(values.Length));
        }

        public override string ToString()
        {
            return (string.Format("{0}{1}{2}{3}", 
                                  rarity, 
                                  (leadingAdj is Adjectives.Leading.Nothing ? "" : " " + leadingAdj.ToString()), 
                                  " " + itemType, 
                                  (endingAdj is Adjectives.Ending.Nothing ? "" : (" of " + endingAdj))));
        }
    }
}
