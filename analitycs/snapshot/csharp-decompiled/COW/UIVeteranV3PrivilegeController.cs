using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIVeteranV3PrivilegeController : UIPopupWindowController
{
	public enum PrivilegeType
	{
		FightBuff = 1,
		FreeTrialCard,
		GameBuff,
		Activity,
		BooyahPass,
		Max
	}

	private UIVeteranV3PrivilegeView m_View;

	private readonly string Animation_LongTerm_In;

	private UIModelVeteran m_VeteranModel;

	private UIModelInventory m_InventoryModel;

	private uint m_delayCallCloseAnim;

	private List<UIVeteranV3PrivilegeItemController> m_CtrlItemList;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	private void OnCloseButtonClick()
	{
	}

	public void ShowVeteranPrivilege()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}
}
