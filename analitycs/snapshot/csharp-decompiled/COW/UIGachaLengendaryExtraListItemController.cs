using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaLengendaryExtraListItemController : UIBaseController
{
	private UIGachaLengendaryExtraListItemView m_View;

	private UIModelGacha m_ModelGacha;

	private ExtraRewardDesc m_ItemDesc;

	private int m_Indx;

	private uint m_GachaID;

	private bool m_ItemOwned;

	private RareRewardState m_RareRewardState;

	private BaseItemInfo m_BaseItemInfo;

	private ExtraAwardItemState m_State;

	private GameObject m_RareRewardVfx;

	private Color m_SecondPrizeColor;

	private Color m_BigPrizeColor;

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

	private void SetLockTokenText()
	{
	}

	private void SetUnlockTokenText()
	{
	}

	private void SetCDNNode()
	{
	}

	private void SetNodeVFX()
	{
	}

	private void SetQualityBG(int Quality, UISprite QualityBG, UISprite prizeBg)
	{
	}

	private void OnItemBtnSelect()
	{
	}

	private void ReOpenBtnClick()
	{
	}

	public void ShowReareRewardVfx(object[] data)
	{
	}

	public void HideReareRewardVfx()
	{
	}

	private void _003CRefreshExtraAwardItemView_003Eb__18_0()
	{
	}

	private void _003CSetCDNNode_003Eb__21_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
