using GCommon;
using UnityEngine;

namespace COW;

internal class UIRuleVScrollTableContainerController : UIRuleTabPanelBaseController
{
	private UIRuleVScrollTableContainerView m_View;

	private float m_Width;

	public CVScrollTableContainerData Data;

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

	private void OnScrollViewDragStarted()
	{
	}

	public void SetViewData(CVScrollTableContainerData data, float width)
	{
	}

	private void BuildChildComponent(Transform container, IModeEditComponentData componentData, bool isLastOne, bool isFirstOne)
	{
	}

	private void Reposition()
	{
	}

	public override void ScrollToTargetUIRuleCtrl(int id)
	{
	}

	public override void ScrollToTargetShopCtrl(string shopID)
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

	public void _003C_003EiFixBaseProxy_ScrollToTargetUIRuleCtrl(int P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ScrollToTargetShopCtrl(string P0)
	{
	}
}
