using System;

namespace COW;

public class UINewVaultItemViewData
{
	public UIModelNewVault.eSecondTab Tab;

	public int Index;

	public int ID;

	public Action<int> OnClick;

	public bool IsEquiped;

	public bool IsLoved;

	public bool IsOwned;
}
