using System;

namespace UMA;

[Serializable]
public class AdditiveInfo
{
	public EAdditiveTargetSlot TargetSlot;

	public byte SlotIndex;

	public byte OverlayOrder;

	public EAdditiveMethod Method;

	public EAdditiveOrderType OrderType;

	public EWardrobeSlot TargetWardrobeSlot => EWardrobeSlot.None;

	public static AdditiveInfo DeserializeFromByte(byte b)
	{
		return null;
	}

	public static bool NotNullOrEmpty(AdditiveInfo info)
	{
		return false;
	}

	public static bool IsNullOrEmpty(AdditiveInfo info)
	{
		return false;
	}
}
