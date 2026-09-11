using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudUGCTutorialMaskController : UIBaseController
{
	private UIHudUGCTutorialMaskView m_View;

	private UIWidget m_TargetWidget;

	private int m_OriginalPanelDepth;

	private bool m_UpdateMask;

	private bool m_AbovePopup;

	private bool m_MaskAll;

	private List<UIWidget> m_AdditionalTargets;

	private List<UIWidget> m_AdditionalHollowCenters;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void LateUpdate()
	{
	}

	public void BindMask(string hollowType, UIWidget targetWidget, bool update = true, bool abovePopup = true, bool disableCollider = false, bool maskAll = false)
	{
	}

	private void SyncPanelDepthWithTarget()
	{
	}

	private void SyncTargetWidgetGeometry()
	{
	}

	public void AddHollowTarget(UIWidget targetWidget)
	{
	}

	private void ClearAdditionalHollowTargets()
	{
	}

	private void SyncAdditionalTargets()
	{
	}

	private void SyncWidgetToHollow(UIWidget target, UIWidget hollowCenter)
	{
	}

	public int GetPanelDepth()
	{
		return 0;
	}

	public void SetInputBlocking(bool blocking)
	{
	}

	private void ApplyHollowType(string hollowType)
	{
	}

	private void ApplyMaskAll()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
