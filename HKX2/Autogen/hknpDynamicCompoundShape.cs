using SoulsFormats;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hknpDynamicCompoundShape : hknpCompoundShape
    {
        public hknpDynamicCompoundShapeData m_boundingVolumeData;
        
        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_boundingVolumeData = des.ReadClassPointer<hknpDynamicCompoundShapeData>(br);
            br.ReadUInt64();
        }
        
        public override void Write(BinaryWriterEx bw)
        {
            base.Write(bw);
            // Implement Write
            bw.WriteUInt64(0);
        }
    }
}