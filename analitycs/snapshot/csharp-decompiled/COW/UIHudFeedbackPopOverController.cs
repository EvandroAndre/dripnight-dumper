using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudFeedbackPopOverController : UIBaseController
{
	private UIHudFeedbackPopOverView m_View;

	private List<UIHudFeedbackPopOverItem> m_DebuffDetailItems;

	private UIClickMask m_ClickMask;

	private const int MaxHeight = 220;

	private int TopMarginHeight;

	private int BottomMarginHeight;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnClickMask()
	{
	}

	private bool OnEscapeClick()
	{
		return false;
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void CreateDetailItems(int count)
	{
	}

	public void ShowMedals(uint[] groupMedals, Vector3 clickWorldPos)
	{
	}

	private void UpdateDetailItems(uint[] groupMedals, ref int contentHeight)
	{
	}

	public void ShowPlayerMedals(List<IngameFeedbackData> data, Vector3 clickWorldPos)
	{
	}

	private void UpdatePlayerBadgeItems(List<IngameFeedbackData> data, ref int contentHeight)
	{
	}

	public void SetPanelDepth(int increaseDepth)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
