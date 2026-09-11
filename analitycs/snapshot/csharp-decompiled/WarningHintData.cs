using GCommon;

public class WarningHintData : CSVBaseData
{
	public int ID;

	public float MaxDistance;

	public float MinDistance;

	public float Duration;

	public int Priority;

	public ResourceID EffectRes;

	public float MinTransparency;

	public int CountLimit;

	public bool IsOpen;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
