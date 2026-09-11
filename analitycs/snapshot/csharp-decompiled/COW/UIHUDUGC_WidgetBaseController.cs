using COW.Gameplay.UGC;
using UnityEngine;

namespace COW;

public abstract class UIHUDUGC_WidgetBaseController : UIHUDUGC_BaseController
{
	public UGCHudWidget m_Widget;

	public virtual void BindWidget(UGCHudWidget widget)
	{
	}

	protected override Vector3 GetRectLocalPosition()
	{
		return default(Vector3);
	}

	public override void DestroyEntity()
	{
	}

	protected override void OnAnchorPositionChanged(Vector3 cur)
	{
	}

	protected override void OnAnchorMinChanged(Vector2 cur)
	{
	}

	protected override void OnAnchorMaxChanged(Vector2 cur)
	{
	}

	protected override void OnPivotChanged(Vector2 cur)
	{
	}

	protected override void OnSizeDeltaChanged(Vector2 cur)
	{
	}

	protected override void OnAngleChanged(float cur)
	{
	}

	protected void OnColorChanged(int cur)
	{
	}

	protected virtual void OnAlphaChanged(float cur)
	{
	}

	protected override void OnParentEntityIDChanged(string cur)
	{
	}

	protected virtual void TryBindWidget()
	{
	}

	public virtual void DynamicCreateWidget(Transform parent)
	{
	}

	protected override void OnHostHudEntityChanged(string cur)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAnchorPositionChanged(Vector3 P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnAnchorMinChanged(Vector2 P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnAnchorMaxChanged(Vector2 P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnPivotChanged(Vector2 P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSizeDeltaChanged(Vector2 P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnAngleChanged(float P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnParentEntityIDChanged(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnHostHudEntityChanged(string P0)
	{
	}
}
