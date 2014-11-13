using Domain.Entity.Mill;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    public class ChemicalCompositionMap : SubclassMap<ChemicalComposition>
    {
        public ChemicalCompositionMap()
        {
            Table("ChemicalComposition");
        }
    }
}
