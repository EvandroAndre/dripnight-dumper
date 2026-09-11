using GCommon;

namespace COW;

public class ClothesExt_Effect : CSVBaseData
{
	public static ClothesExt_Effect Default;

	public uint iID;

	public ResourceID EffectID_3P_M;

	public ResourceID EffectID_3P_F;

	public ResourceID EffectID_M;

	public ResourceID EffectID_F;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
