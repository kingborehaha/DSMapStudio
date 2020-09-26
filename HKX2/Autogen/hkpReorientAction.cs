using SoulsFormats;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkpReorientAction : hkpUnaryAction
    {
        public Vector4 m_rotationAxis;
        public Vector4 m_upAxis;
        public float m_strength;
        public float m_damping;
        
        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            m_rotationAxis = des.ReadVector4(br);
            m_upAxis = des.ReadVector4(br);
            m_strength = br.ReadSingle();
            m_damping = br.ReadSingle();
            br.ReadUInt64();
        }
        
        public override void Write(BinaryWriterEx bw)
        {
            base.Write(bw);
            bw.WriteUInt64(0);
            bw.WriteSingle(m_strength);
            bw.WriteSingle(m_damping);
            bw.WriteUInt64(0);
        }
    }
}