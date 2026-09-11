using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIRecSelectUploadPlanPopupController : UIPopupWindowController
{
	private UIRecSelectUploadPlanPopupView m_View;

	private UIModelLoadout m_ModelLoadout;

	private uint m_SelectedPlanIndex;

	private int m_PlanIndex;

	private List<PlayerPlanItem> m_Plans;

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

	private PlayerPlanItem DeepCopyPlayerPlan(PlayerPlanItem source)
	{
		return null;
	}

	public void SetViewData(int planIndex)
	{
	}

	private void OnClickUploadPlan(uint planID)
	{
	}

	private void OnClickConfirm()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
