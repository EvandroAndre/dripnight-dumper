using GCommon;

public class VirtualBrandGainData : CSVBaseData, IGetId
{
	public uint BrandID;

	public ResourceID GainAnim;

	public ResourceID GainAnimA;

	public ResourceID GainStatu;

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}
}
