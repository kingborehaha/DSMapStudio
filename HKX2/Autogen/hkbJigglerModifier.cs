using SoulsFormats;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public enum JiggleCoordinates
    {
        JIGGLE_IN_WORLD_COORDINATES = 0,
        JIGGLE_IN_MODEL_COORDINATES = 1,
    }
    
    public class hkbJigglerModifier : hkbModifier
    {
        public List<hkbJigglerGroup> m_jigglerGroups;
        public JiggleCoordinates m_jiggleCoordinates;
        
        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_jigglerGroups = des.ReadClassPointerArray<hkbJigglerGroup>(br);
            m_jiggleCoordinates = (JiggleCoordinates)br.ReadSByte();
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt32();
            br.ReadUInt16();
            br.ReadByte();
        }
        
        public override void Write(BinaryWriterEx bw)
        {
            base.Write(bw);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}