using GCommon;

namespace COW;

public class InGamePhotoVerticalHudData : CSVBaseData
{
	public string HudName;

	public EUIAnchor Anchor;

	public float CoordinateY;

	public float CoordinateX;

	public float Rotate;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
