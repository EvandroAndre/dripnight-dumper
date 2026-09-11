using GCommon;

namespace COW;

public class TitleData : CSVBaseData, IGetId
{
	public uint iID;

	public uint class_type;

	public uint sortId;

	public string TitleKey;

	public string RimResString;

	public ResourceID RimRes;

	public ResourceID EffectRes;

	public float TimeLimit;

	public bool IsShow;

	public ResourceID TitleFrameRes;

	public float GroupTitleBubbleTime;

	public uint GetId()
	{
		return 0u;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public void RegisterIconCDNRes()
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
