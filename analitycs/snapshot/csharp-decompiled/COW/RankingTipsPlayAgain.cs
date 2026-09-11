using GCommon;

namespace COW;

public class RankingTipsPlayAgain : CSVBaseData, IGetId
{
	public uint IndexId;

	public uint GroupId;

	public uint TipsId;

	public string TeamIcon;

	public uint Frequency;

	public uint BROrderId;

	public uint[] BRRank;

	public string BRTips;

	public string BRSecTips;

	public uint BRLowerLimit1;

	public uint BRLowerLimit2;

	public uint[] CSRank;

	public uint CSOrderId;

	public string CSTips;

	public string CSSecTips;

	public uint CSLowerLimit1;

	public uint CSLowerLimit2;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override int GetIntKey()
	{
		return 0;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public int _003C_003EiFixBaseProxy_GetIntKey()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
