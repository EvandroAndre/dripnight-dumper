using UnityEngine;

namespace COW;

internal class SettingUIPresetValue
{
	public static Vector3 ShortSliderScale;

	public static Vector3 ShortSliderThumb;

	public static int NormalScreeLength;

	public static int NormalScreeHeight;

	public static int ShortItemDetalValue;

	public static int CommonSettingItemLength;

	public static int ShortSettingItemWordLength1 => 0;

	public static int ShortSettingItemWordLength2 => 0;

	public static int ShortSettingItemWordChildLength1 => 0;

	public static int ShortSettingItemWordChildLength2 => 0;

	public static int ShortSettingSliderItemWordChildLength => 0;

	public static int GetShortItemDetalLenght()
	{
		return 0;
	}

	private static int GetAutoExtendLabelLength()
	{
		return 0;
	}

	public static int GetMiddleUIXOffset()
	{
		return 0;
	}
}
