﻿using Domain.Entity.Construction;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    public class JointMap : SubclassMap<Joint>
    {
        public JointMap()
        {
            Map(_ => _.Number).Column("number");
            Map(_ => _.NumberKP).Column("numberKP");
            Map(_ => _.DistanceFromKP).Column("distanceFromKP");
            Map(_ => _.LoweringDate).Column("loweringDate");
            Map(_ => _.Status).Column("status");
            Map(_ => _.GpsHeight).Column("gpsHeight");
            Map(_ => _.GpsLatitude).Column("gpsLatitude");
            Map(_ => _.GpsLongitude).Column("gpsLongitude");
            Component<PartData>(_ => _.FirstElement, m =>
            {
                m.Map(_ => _.Id).Column("part1Id");
                m.Map(_ => _.PartType).Column("part1Type");
                m.Map(_ => _.Number).Column("part1Number");

            });

            Component<PartData>(_ => _.SecondElement, n =>
            {
                n.Map(_ => _.Id).Column("part2Id");
                n.Map(_ => _.PartType).Column("part2Type");
                n.Map(_ => _.Number).Column("part2Number");

            });

            HasMany<JointTestResult>(_ => _.JointTestResults).KeyColumn("jointId").Cascade.All().Not.LazyLoad();
            HasMany<JointWeldResult>(_ => _.JointWeldResults).KeyColumn("jointId").Cascade.All().Not.LazyLoad();
        }
    }
}
