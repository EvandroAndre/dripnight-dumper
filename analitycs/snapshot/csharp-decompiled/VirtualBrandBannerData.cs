using GCommon;
using UnityEngine;

public class VirtualBrandBannerData : CSVBaseData, IGetId
{
	public uint BrandID;

	public ResourceID BrandKeyart;

	public ResourceID BrandPose;

	public string BrandIntroduce;

	public string BrandSlogan;

	public Color32 LogoColor;

	public Color32 ValueColor;

	public ResourceID ValueIcon;

	public ResourceID ValueBackground;

	public ResourceID BgVfx;

	public ResourceID FrontVfx;

	public ResourceID BigValueIcon;

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
