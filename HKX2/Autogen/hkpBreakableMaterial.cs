using SoulsFormats;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkpBreakableMaterial : hkReferencedObject
    {
        public float m_strength;
        public int m_typeAndFlags;
        public hkRefCountedProperties m_properties;
        
        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_strength = br.ReadSingle();
            m_typeAndFlags = br.ReadInt32();
            m_properties = des.ReadClassPointer<hkRefCountedProperties>(br);
        }
        
        public override void Write(BinaryWriterEx bw)
        {
            base.Write(bw);
            bw.WriteSingle(m_strength);
            bw.WriteInt32(m_typeAndFlags);
            // Implement Write
        }
    }
}