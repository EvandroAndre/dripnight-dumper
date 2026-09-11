using System.Collections.Generic;
using GCommon;

namespace COW;

public class UISecondRechargeController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private enum OperateStatus
	{
		None,
		GoTo,
		UnFinished,
		Available,
		Received
	}

	private UISecondRechargeView m_View;

	private List<UISecondRechargeRewardItemController> m_Items;

	private UIModelActivity m_ModelActivity;

	private ActivityGroupDesc m_GroupDesc;

	private OperateStatus m_OperateStatus;

	private UISecondRechargeRewardItemController m_CurrentSelectItem;

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

	private void OnClickClose()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void UpdateView(object data)
	{
	}

	private void ShowUIAfterCDNLoaded()
	{
	}

	private void CreateRewardItemList()
	{
	}

	private void SetOperateButtonUI()
	{
	}

	private void OnClickCharge()
	{
	}

	private void OnClickCliam()
	{
	}

	private bool HasReceived()
	{
		return false;
	}

	public void OnSelectItem(UISecondRechargeRewardItemController rewardItem)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
