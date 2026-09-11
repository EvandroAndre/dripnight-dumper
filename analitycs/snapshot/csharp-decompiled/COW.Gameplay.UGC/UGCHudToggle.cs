using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCHudToggle : UGCHudWidget
{
	public UISprite m_UnSelectedSprite;

	public UISprite m_SelectedSprite;

	protected UIToggle m_Toggle;

	protected BoxCollider m_Col;

	public UIToggle Toggle => null;

	public BoxCollider Col => null;

	public override UGCHudWidgetType GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	protected override void OnInternalEnable()
	{
	}

	public override void AddDragScrollView(UIScrollView scrollView)
	{
	}

	public void SetValue(bool value)
	{
	}

	public bool GetValue()
	{
		return false;
	}

	public void RefreshImage()
	{
	}

	public override void SetLayer(int layer)
	{
	}

	public override Vector2Int SetDepth(Vector2Int depth, int stepDepth)
	{
		return default(Vector2Int);
	}

	public override void SetParentHasChanged()
	{
	}

	public UGCHudWidgetType _003C_003EiFixBaseProxy_GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	public void _003C_003EiFixBaseProxy_OnInternalEnable()
	{
	}

	public void _003C_003EiFixBaseProxy_AddDragScrollView(UIScrollView P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetLayer(int P0)
	{
	}

	public Vector2Int _003C_003EiFixBaseProxy_SetDepth(Vector2Int P0, int P1)
	{
		return default(Vector2Int);
	}

	public new void _003C_003EiFixBaseProxy_SetParentHasChanged()
	{
	}
}
