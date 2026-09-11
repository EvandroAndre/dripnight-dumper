using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaELS_TT53ExtraListItemController : UIBaseController
{
	private UIGachaELS_TT53ExtraListItemView m_View;

	private UIModelGacha m_ModelGacha;

	private ExtraRewardDesc m_ItemDesc;

	private int m_Indx;

	private uint m_GachaID;

	private bool m_ItemOwned;

	private RareRewardState m_RareRewardState;

	private Vector3 m_RootPos;

	private BaseItemInfo m_BaseItemInfo;

	private ExtraAwardItemState m_State;

	private GameObject m_RareRewardVfx;

	private GameObject m_RareRewardClaimVFX;

	private GameObject m_VFX;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(ExtraRewardDesc data, int data_index, uint chestID, bool reminder = false)
	{
	}

	private void UpdateReminderView()
	{
	}

	private void UpdateItemState()
	{
	}

	private void RefreshExtraAwardItemView()
	{
	}

	private void SetNodeVFX()
	{
	}

	private void SetQualityBG(int Quality)
	{
	}

	private void OnItemBtnSelect()
	{
	}

	private void ReOpenBtnClick()
	{
	}

	public void ShowRareRewardVfx()
	{
	}

	public void HideReareRewardVfx()
	{
	}

	private void SetClaimVFX()
	{
	}

	private void _003CRefreshExtraAwardItemView_003Eb__18_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
