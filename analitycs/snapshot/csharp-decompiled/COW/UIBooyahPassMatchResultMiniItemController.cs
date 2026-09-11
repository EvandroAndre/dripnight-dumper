using GCommon;
using UnityEngine;

namespace COW;

internal class UIBooyahPassMatchResultMiniItemController : UIEasyListItemController
{
	private UIBooyahPassMatchResultMiniItemView m_View;

	private UIStandardItemMiniController m_MiniCtrl;

	private UIModelBooyahPass m_ModelBooyahPass;

	private BooyahPassBaseItemData m_BaseItemData;

	private BaseItemInfo m_Info;

	private Vector3 MATCH_RESULT_WND_ITEM_SCALE;

	private Vector3 m_OriginPos;

	private bool m_IsPP;

	private uint m_CurGrade;

	private bool m_ShowCheckMark;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetCheckMark(bool value)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void ShowMatchResultRewardWnd()
	{
	}

	private void RefreshRewardView(int index)
	{
	}

	private void SetPrivilegeRewardView()
	{
	}

	private void SetBtnClickEvent(bool isPrivilegeReward)
	{
	}

	private void ShowPrivilegeRewardTips()
	{
	}

	private void SetNormalRewardView()
	{
	}

	private void RefreshGradeView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
