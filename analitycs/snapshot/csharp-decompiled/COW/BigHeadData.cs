using System.Collections.Generic;
using GCommon;

namespace COW;

public class BigHeadData : CSVBaseData
{
	public uint Lv;

	public float HeadScale;

	public float HeadShotDamageScale;

	public int KillScore;

	public int HeadKillScore;

	public int BoostKillScore;

	public uint HeadAvatar;

	public int NeedKillCount;

	public List<uint> BuffIDs;

	public ResourceID EffectID;

	public ResourceID HeadIcon;

	public ResourceID LightHeadIcon;

	public ResourceID LightOffHeadIcon;

	public string Name;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
