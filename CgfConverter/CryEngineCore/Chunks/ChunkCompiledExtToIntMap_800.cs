﻿using System;
using System.IO;
using System.Linq;

namespace CgfConverter.CryEngineCore
{
    public class ChunkCompiledExtToIntMap_800 : ChunkCompiledExtToIntMap
    {
        public override void Read(BinaryReader b)
        {
            base.Read(b);
            NumExtVertices = this.DataSize / sizeof(UInt16);
            Source = new UInt16[NumExtVertices];
            for (int i = 0; i < NumExtVertices; i++)
            {
                Source[i] = b.ReadUInt16();
            }
            // Add to SkinningInfo
            SkinningInfo skin = GetSkinningInfo();
            skin.Ext2IntMap = Source.ToList();
            skin.HasIntToExtMapping = true;
        }
    }
}
