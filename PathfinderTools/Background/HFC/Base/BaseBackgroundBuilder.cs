using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    abstract public class BaseBackgroundBuilder
    {
        protected IHomelandTable homelandTable;
        protected IParentsTable parentsTable;
        protected ISiblingsTable siblingsTable;
        protected List<Enum> traits = new List<Enum>();

        protected SiblingsList characterSiblings;
        protected Homeland characterHomeland;

        public Parents CharacterParents { get; protected set; }

        public Homeland CharacterHomeland { get; protected set;}

        public SiblingsList CharacterSiblings { get; protected set; }

        public List<Enum> CharacterTraits { get; protected set; }

        protected void generateCharacterTraits()
        {
            traits.Clear();

            foreach (Enum trait in characterHomeland.Traits)
            {
                if (!traits.Contains(trait)) { traits.Add(trait); }
            }

            foreach (Enum trait in CharacterParents.Traits)
            {
                if (!traits.Contains(trait)) { traits.Add(trait); }
            }

            foreach (Enum trait in characterSiblings.Traits)
            {
                if (!traits.Contains(trait)) { traits.Add(trait); }
            }
        }
    }
}
