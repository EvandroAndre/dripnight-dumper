using GCommon;

namespace COW;

public class InGameTriggerMaskData : CSVBaseData
{
	public uint ID;

	public uint Priority;

	public ResourceID IconRes;

	public uint FollowType;

	public uint MarkType;

	public int Deviation;

	public float Duration;

	public float CoolDown;

	public uint IsBlinkOn;

	public uint ShowTime;

	public int Zoom;

	public uint ProgressColor;

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
