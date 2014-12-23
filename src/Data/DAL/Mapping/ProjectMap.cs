using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Prizm.Domain.Entity;

namespace Prizm.Data.DAL.Mapping
{
    public class ProjectMap : SubclassMap<Project>
    {
        public ProjectMap()
        {
            Map(_ => _.Title).Column("title");
            Map(_ => _.Client).Column("client");
            Map(_ => _.MillName).Column("millName");
            Map(_ => _.DocumentSizeLimit).Column("documentSizeLimit");
            Map(_ => _.WorkstationType).Column("workstationType");
            Map(_ => _.MillPipeNumberMask).Column("millPipeNumberMask");
            Map(_ => _.MillPipeNumberMaskRegexp).Column("millPipeNumberMaskRegexp");
            Map(_ => _.ExternalFilesPath).Column("externalFilesPath");
        }
    }
}
