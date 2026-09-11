using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIClanActivenessProgressBarItemController : UIBaseController, IUIModelDataChangeObserver
{
	private UIClanActivenessProgressBarItemView m_View;

	private uint m_LeftNodeValue;

	private uint m_RightNodeValue;

	private uint m_MyActivenessValue;

	private ClientClanActivenessAwardDesc m_Desc;

	private UIStandardItemMiniController m_AwardCtrl;

	private AwardDesc m_AwardDesc;

	private UIModelClan m_ModelClan;

	private UIProgressBar m_ProgressBar;

	private UILabel m_ProgressLabel;

	private UIButton m_ProgressAwardBtn;

	private GameObject m_RewardGetEffect;

	private GameObject m_Thumb;

	private GameObject m_ActiveThumb;

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

	public void SetViewData(ClientClanActivenessAwardDesc desc, uint leftValue)
	{
	}

	public void RefreshData()
	{
	}

	private void RefreshProgressBar()
	{
	}

	private void InstantThumbVfx()
	{
	}

	private void SetProgressAward()
	{
	}

	private void RefreshProgressAwardInfo()
	{
	}

	private void UpdateMyActiveness()
	{
	}

	private void OnAwardClicked()
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
}
