using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIGachaIchis55OverviewItemController : UIBaseController
{
	private const string PROGRESS_FG_SPRITE_01 = "FF_UI_Ichis_55_PrizesLeftPB_Up_S";

	private const string PROGRESS_FG_SPRITE_02 = "FF_UI_Ichis_55_PrizesLeftPB_Up_ABC";

	private const string PROGRESS_FG_SPRITE_03 = "FF_UI_Ichis_55_PrizesLeftPB_Up_D";

	private const float PROGRESS_THUMB_MIN_VISIBLE = 0.015f;

	private const float PROGRESS_THUMB_MAX_VISIBLE = 0.99f;

	private UIGachaIchis55OverviewItemView m_View;

	private IchisOverviewTierData m_Data;

	private List<UIGachaIchis55OverviewAwardItemController> m_RewardCtrls;

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

	private void RefreshProgress(float progress)
	{
	}

	private void UpdateProgressSliceHeadPosition(float progress)
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
