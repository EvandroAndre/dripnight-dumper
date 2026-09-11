using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIBigEventPeakDayWndBaseController : UIPopupWindowController, IUIModelDataChangeObserver
{
	protected UIBigEventPeakDayWndBaseView m_View;

	protected UIModelActivity m_ModelActivity;

	protected ClientActivityDesc m_PeakDayDesc;

	private List<UIStandardItemMiniController> itemList;

	protected bool itemMiniTween;

	public bool ShowFirstItemName;

	public virtual ELimitedEvent.EventID GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public virtual EActivity.SubType GetActivitySubType()
	{
		return EActivity.SubType.SubType_NONE;
	}

	public virtual UIStandardItemMiniController GetItemController()
	{
		return null;
	}

	public virtual string GetPeakDayLoginKey()
	{
		return null;
	}

	public virtual string GetPeakDayExpiredKey()
	{
		return null;
	}

	public virtual string GetPeakDayTitleKey()
	{
		return null;
	}

	public virtual UICommonRewardWndController.WndStyleEnum GetRewandWndStyle()
	{
		return UICommonRewardWndController.WndStyleEnum.COMMON;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void CloseAllItem()
	{
	}

	public virtual void CloseUI()
	{
	}

	public void SetViewData()
	{
	}

	protected virtual void OnBtnClaimClick()
	{
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
