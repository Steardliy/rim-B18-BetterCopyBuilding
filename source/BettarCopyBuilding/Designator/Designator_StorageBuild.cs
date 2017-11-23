﻿using RimWorld;
using System.Reflection;
using Verse;

namespace BetterCopyBuilding
{
    public class Designator_StorageBuild : Designator_Build
    {
        private StorageSettings tmpSettings;

        public Designator_StorageBuild(BuildableDef bDef, StorageSettings settings) : base(bDef)
        {
            tmpSettings = settings;
        }
        public override void DesignateSingleCell(IntVec3 c)
        {
            Map.GetComponent<StorageSettingManager>().Add(tmpSettings, c);
            base.DesignateSingleCell(c);
        }
    }
}
