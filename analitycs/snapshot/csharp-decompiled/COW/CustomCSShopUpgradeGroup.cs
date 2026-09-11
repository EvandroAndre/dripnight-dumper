using System.Collections.Generic;

namespace COW;

public class CustomCSShopUpgradeGroup
{
	private UIModelCustomRoom m_ModelCustomRoom;

	public uint GroupID;

	public uint BaseSettingIndex;

	public bool BaseSettingSelected;

	public List<uint> UpgradedSettingIndexes;

	public bool UpgradedSettingSelected;

	private UIModelCustomRoom ModelCustomRoom => null;

	private bool Valid()
	{
		return false;
	}

	public void AutoToggle()
	{
	}
}
