using GCommon;

public class VirtualBrandLogoTouch : CSVBaseData, IGetId
{
	public uint BrandID;

	public ResourceID BrandTouchVfxID;

	public ResourceID BrandLogoVoiceID;

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
