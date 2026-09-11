using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIPrimePrivilegeLevelItemController : UIBaseController
{
	private UIPrimePrivilegeLevelItemView m_View;

	private UIModelPrime m_ModelPrime;

	private List<uint> m_PrivilegeIds;

	private uint m_Level;

	private List<UIPrimePrivilegeBigItemController> m_PrivilegeBigItemControllers;

	private List<UIPrimePrivilegeSmallItemController> m_PrivilegeSmallItemControllers;

	private int m_HalfExpandWidth;

	private int m_HalfShrinkWidth;

	private bool m_Expand;

	private const int MAX_BG_HEIGHT_TWOTHREE_ITEMS = 336;

	private const int MAX_BG_HEIGHT_FOURITEMS = 400;

	private const int EXPAND_HALF_PROGRESS_WIDTH = 120;

	private const int EXPAND_HALF_PROGRESS_WIDTH_WIDE = 220;

	public int HalfExpandWidth => 0;

	public int HalfShrinkWidth => 0;

	public uint Level => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData(List<uint> privileges, uint level)
	{
	}

	public void SetViewDataShrink(List<uint> privileges, uint level)
	{
	}

	public void SetViewDataForMaxLevel(List<uint> privileges)
	{
	}

	private void RefreshProgressBar(bool isMax = false)
	{
	}

	public void RefreshSelected(uint privilegeId, uint level)
	{
	}

	public void SetProgressWidth()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
