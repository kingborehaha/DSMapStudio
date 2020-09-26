using SoulsFormats;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public enum EdgeFilterType
    {
        EDGE_FILTER_DEFAULT = 0,
        EDGE_FILTER_USER = 1,
    }
    
    public class hkaiAstarEdgeFilter : hkReferencedObject
    {
        public EdgeFilterType m_type;
        
        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_type = (EdgeFilterType)br.ReadByte();
            br.ReadUInt32();
            br.ReadUInt16();
            br.ReadByte();
        }
        
        public override void Write(BinaryWriterEx bw)
        {
            base.Write(bw);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}