using System;

namespace COW;

public class HippoCrisisInventorySubTabData
{
	public HippoCrisisInventorySubTab Tab;

	public HippoCrisisInventoryTab ParentTab;

	public Action<HippoCrisisInventorySubTab> OnClick;

	public string IconSpriteName;

	public int index;
}
