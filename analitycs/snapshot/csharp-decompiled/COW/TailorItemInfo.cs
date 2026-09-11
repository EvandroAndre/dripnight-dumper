using proto;

namespace COW;

public class TailorItemInfo
{
	public enum ETailorItemType
	{
		Bundle,
		BaseCloth,
		BundleCloth,
		SingleCloth,
		Collection,
		SpecialEffects
	}

	private TailorUnlockDesc m_TailorUnlockDesc;

	private bool m_IsPlaceHolder;

	private uint m_ItemID;

	private ETailorItemType m_ItemType;

	public TailorUnlockDesc TailorUnlockDesc => null;

	public bool IsPlaceHolder => false;

	public uint ItemID => 0u;

	public ETailorItemType ItemType => ETailorItemType.Bundle;

	public TailorItemInfo(uint ID, bool isPlaceHolder, ETailorItemType tailorItemType, TailorUnlockDesc tailorUnlockDesc)
	{
	}
}
