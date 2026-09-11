using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMapAstrolGateWndController : UIBaseController
{
	private UIHudMapAstrolGateWndView m_View;

	private uint m_UIFXHolder;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void InitByMapOffsetContext(UIMapUtil.MapOffsetContext ctx)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void Hide()
	{
	}

	public void RefreshView(Vector3 localPos)
	{
	}

	public void SetDragEnabled(bool enabled)
	{
	}

	public void SetUIFX(ResourceID vfxResID)
	{
	}

	private void ReleaseUIFX()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
