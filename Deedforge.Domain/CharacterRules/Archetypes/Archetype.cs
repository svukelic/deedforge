using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deedforge.Domain.CharacterRules.Archetypes
{
    public class Archetype
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ArchetypeFeature> Features { get; set; }
    }
}
