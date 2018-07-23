using System;
using System.Linq;

namespace Justiciar
{
    public static class Forge
    {

        public static Item ForgeItem()
        {
            return new Item();
        }

        public static Enum GetRandomEnumValue(Object t)
        {
            return Enum.GetValues(t.GetType())
                .OfType<Enum>()
                .OrderBy(e => Guid.NewGuid())
                .FirstOrDefault();
        }
    }
}
