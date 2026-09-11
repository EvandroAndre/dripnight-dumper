using GCommon;

namespace COW;

internal class UIGachaLimitRemoveConfirmController : UIPopupWindowController
{
	private UICommonTinyMsgBoxView m_View;

	private UIModelGacha m_ModelGacha;

	private uint m_GachaID;

	private uint m_SubID;

	private bool m_IsDefaultRemove;

	private uint[] m_RemoveItemIds;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnOKClick()
	{
	}

	public void SetViewData(uint gachaID, uint subID)
	{
	}

	public void SetDefaultRemoveLogData(bool isDefaultRemove, uint[] removeItemIds)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
