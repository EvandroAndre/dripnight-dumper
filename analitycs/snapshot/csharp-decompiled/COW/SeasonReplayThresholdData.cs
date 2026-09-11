using GCommon;

namespace COW;

public class SeasonReplayThresholdData : CSVBaseData
{
	public string FieldName;

	public string Des;

	public float[] Thresholds;

	public int[] Percentages;

	public string[] Tags;

	public string[] RoleTags;

	public string IconRes;

	public string RecTag;

	public string RecTagIconRes;

	public string RecTeam;

	public string RecTeamIconRes;

	public string RecTeamIconResTopColor;

	public string RecTeamIconResBottomColor;

	public string IconResTopColor;

	public string IconResBottomColor;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public float GetThresholdByValue(float value, ref int percentage)
	{
		return 0f;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
