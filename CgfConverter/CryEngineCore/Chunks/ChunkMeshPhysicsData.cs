namespace CgfConverter.CryEngineCore
{
    class ChunkMeshPhysicsData : Chunk
    {
        // Collision mesh or something like that.  TODO

        public int PhysicsDataSize { get; set; }             //Size of the physical data at the end of the chunk.
        public int Flags { get; set; }
        public int TetrahedraDataSize { get; set; }          // Bytes per data entry
        public int TetrahedraID { get; set; }                // Chunk ID of the data stream
        public ChunkDataStream Tetrahedra { get; set; }
        public uint Reserved1 { get; set; }
        public uint Reserved2 { get; set; }

        public PhysicsData physicsData { get; internal set; }  // if physicsdatasize != 0
        public byte[] TetrahedraData { get; internal set; } // Array length TetrahedraDataSize.  

        public override string ToString()
        {
            return $@"Chunk Type: {ChunkType}, ID: {ID:X}, Version: {Version}";
        }

        public void WriteChunk()
        {
            Utils.Log(LogLevelEnum.Debug, "*** START MeshPhysicsData Chunk ***");
            Utils.Log(LogLevelEnum.Debug, "    ChunkType:           {0}", ChunkType);
            Utils.Log(LogLevelEnum.Debug, "    Node ID:             {0:X}", ID);
            Utils.Log(LogLevelEnum.Debug, "    Node ID:             {0:X}", PhysicsDataSize);
            Utils.Log(LogLevelEnum.Debug, "    Node ID:             {0:X}", TetrahedraDataSize);
            Utils.Log(LogLevelEnum.Debug, "    Node ID:             {0:X}", TetrahedraID);
            Utils.Log(LogLevelEnum.Debug, "    Node ID:             {0:X}", ID);
        }
    }
}
