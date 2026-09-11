using COW.Gameplay.UGC;
using UnityEngine;

namespace COW;

public class UIHUDUGC_ScrollViewController : UIHUDUGC_PanelBaseController
{
	private UGCHudPanelRepItem m_PanelCmpt;

	private UGCHudScrollViewRepItem m_ScrollViewCmpt;

	private UIHUDUGC_ScrollViewCulling m_Culling;

	protected override void OnDestroy()
	{
	}

	protected override void InitEntityData()
	{
	}

	protected override void InitWidget()
	{
	}

	public void OnDragStarted()
	{
	}

	protected override void RefreshWidgetInfo()
	{
	}

	private void OnCancelDragIfFitsChange(bool cur)
	{
	}

	private void OnContentOriginChange(int cur)
	{
	}

	private void OnCustomXYChange(Vector2 cur)
	{
	}

	private void OnDragEffectChange(int cur)
	{
	}

	private void OnMomentumAmountChange(float cur)
	{
	}

	private void OnRestrictWithinPanelChange(bool cur)
	{
	}

	private void OnScrollDirectionChange(int cur)
	{
	}

	private void RefreshScrollViewCulling(UGCHudScrollView sv, bool rebuild)
	{
	}

	private void OnScrollWheelFactorChange(float cur)
	{
	}

	private void OnSmoothDragStartChange(bool cur)
	{
	}

	private void OnHorizontalBarChange(int cur)
	{
	}

	private void OnVerticalBarChange(int cur)
	{
	}

	private void OnShowPositionChange(Vector2 cur)
	{
	}

	private void OnDisableColliderChanged(bool cur)
	{
	}

	public override void RefreshAlpha()
	{
	}

	public void _003C_003EiFixBaseProxy_InitEntityData()
	{
	}

	public void _003C_003EiFixBaseProxy_InitWidget()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshWidgetInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshAlpha()
	{
	}
}
