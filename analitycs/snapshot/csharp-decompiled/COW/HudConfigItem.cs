using GCommon;

namespace COW;

public class HudConfigItem
{
	public double CoordinateX;

	public double CoordinateY;

	public EUIAnchor Anchor;

	public double BtnScale;

	public double BtnMaxScale;

	public double BtnMinScale;

	public double ShowAlpha;

	public double MinAlpha;

	public bool Locked;

	public string HudName;

	public bool Hidden;

	public bool Separate;

	public bool LeftAligned;

	public HudConfigItem()
	{
	}

	public HudConfigItem(HudConfigItem item)
	{
	}

	public void CopyFrom(HudConfigItem item)
	{
	}

	public float BtnScalePctToCfgValue(float pctValue)
	{
		return 0f;
	}

	public float GetBtnScalePctValue()
	{
		return 0f;
	}

	public bool ValueEqualTo(HudConfigItem item)
	{
		return false;
	}

	public bool EqualTo(HudConfigItem item)
	{
		return false;
	}
}
