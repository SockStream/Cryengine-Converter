﻿using System;
using System.IO;

namespace CgfConverter.CryEngineCore
{
    // cccc0014:  provides material name as used in the .mtl file
    public class ChunkMtlName_744 : ChunkMtlName
    {
        public override void Read(BinaryReader b)
        {
            base.Read(b);

            Name = b.ReadFString(128);
            NumChildren = b.ReadUInt32();
            PhysicsType = new MtlNamePhysicsType[NumChildren];
            MatType = NumChildren == 0 ? MtlNameTypeEnum.Single : MtlNameTypeEnum.Library;

            for (int i = 0; i < NumChildren; i++)
            {
                PhysicsType[i] = (MtlNamePhysicsType)Enum.ToObject(typeof(MtlNamePhysicsType), b.ReadUInt32());
            }
        }
    }
}
