using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIVeteranV3SignRewardController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIVeteranV3SignRewardView m_View;

	private UIModelVeteran m_ModelVeteran;

	private List<VeteranRewardItem> m_DailyRewardList;

	private readonly List<UIVeteranV3SignRewardItemController> m_DailyRewardItemCtrlList;

	private bool m_ClaimRewardUrgent;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnBtnCloseClick()
	{
	}

	public void ClaimTodayRewards()
	{
	}

	private void LoadStaticContent()
	{
	}

	private void RefreshDynamicContent()
	{
	}

	private void RefreshView()
	{
	}

	public void SetUrgent()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
