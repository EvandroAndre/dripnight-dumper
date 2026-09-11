using GCommon;
using proto;

namespace COW;

internal class UIUGCConfirmWndController : UIPopupWindowController
{
	private UIUGCConfirmWndView m_View;

	private UIModelSceneEdit m_ModelSceneEdit;

	private SceneEditSlotInfo m_CurSlotInfo;

	private EWorkshop.UnlockSlotCostType m_CostType;

	private uint m_CostCnt;

	private uint m_CostItem;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(SceneEditSlotInfo info)
	{
	}

	private void UpdateLocText(string titleKey, string mainKey, string warnKey, string btnConfirmKey, string btnCancelKey)
	{
	}

	private void ProcessOnUnlockSlot()
	{
	}

	private void OnBtnCancelClick()
	{
	}

	private void OnBtnApplyClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
