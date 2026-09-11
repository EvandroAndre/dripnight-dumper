using System;

namespace COW;

public class UINewVaultSecondTabItemViewData
{
	public int DataIndex;

	public UIModelNewVault.eSecondTab Tab;

	public UIModelNewVault.eFirstTab FirstTab;

	public bool IsTip;

	public int Count;

	public uint IconItemID;

	public bool IsGray;

	public Action<int> OnClick;

	public Action<UIModelNewVault.eSecondTab, UINewVaultSecondTabItemController> OnRefreshIcon;

	public Action<UIModelNewVault.eSecondTab> OnCloseTips;

	public void RefreshIconItemID()
	{
	}
}
