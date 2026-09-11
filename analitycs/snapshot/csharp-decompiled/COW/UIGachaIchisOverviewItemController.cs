using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaIchisOverviewItemController : UIBaseController
{
	private const string PROGRESS_FG_SPRITE_01 = "FF_UI_Ichis_Normal_Popup_bar01";

	private const string PROGRESS_FG_SPRITE_02 = "FF_UI_Ichis_Normal_Popup_bar02";

	private const string PROGRESS_FG_SPRITE_03 = "FF_UI_Ichis_Normal_Popup_bar03";

	private static readonly Color SOLD_OUT_LABEL_COLOR;

	private static readonly Color AVAILABLE_LABEL_COLOR;

	private UIGachaIchisOverviewItemView m_View;

	private IchisOverviewTierData m_Data;

	private List<UIGachaIchisOverviewAwardItemController> m_RewardCtrls;

	private bool m_IsRewardVisible;

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

	public void SetData(IchisOverviewTierData data)
	{
	}

	public void SetRewardVisible(bool visible)
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshTierIcon()
	{
	}

	private void RefreshProgressSprite()
	{
	}

	private void CreateRewardItems()
	{
	}

	private void ResizeAwardCollider()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
