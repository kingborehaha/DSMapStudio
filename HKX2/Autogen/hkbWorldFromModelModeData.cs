using SoulsFormats;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public enum WorldFromModelMode
    {
        WORLD_FROM_MODEL_MODE_USE_OLD = 0,
        WORLD_FROM_MODEL_MODE_USE_INPUT = 1,
        WORLD_FROM_MODEL_MODE_COMPUTE = 2,
        WORLD_FROM_MODEL_MODE_NONE = 3,
    }
    
    public class hkbWorldFromModelModeData : IHavokObject
    {
        public short m_poseMatchingBone0;
        public short m_poseMatchingBone1;
        public short m_poseMatchingBone2;
        public WorldFromModelMode m_mode;
        
        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_poseMatchingBone0 = br.ReadInt16();
            m_poseMatchingBone1 = br.ReadInt16();
            m_poseMatchingBone2 = br.ReadInt16();
            m_mode = (WorldFromModelMode)br.ReadSByte();
            br.ReadByte();
        }
        
        public virtual void Write(BinaryWriterEx bw)
        {
            bw.WriteInt16(m_poseMatchingBone0);
            bw.WriteInt16(m_poseMatchingBone1);
            bw.WriteInt16(m_poseMatchingBone2);
            bw.WriteByte(0);
        }
    }
}