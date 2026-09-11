using GCommon;
using UnityEngine;

namespace COW;

public class EdgeDetectHudItem : CustomHudItem
{
	public UIWidget EdgeDetectWidget;

	protected int m_ScreenWidth;

	protected int m_ScreenHeight;

	protected EUIAnchor m_Anchor;

	protected override void Awake()
	{
	}

	protected override void OnHudDragEnd(GameObject go)
	{
	}

	public void SetAnchor(EUIAnchor anchor)
	{
	}

	public virtual void EdgeDetect()
	{
	}

	public bool DetectWillTouchEdge(int direction, float delta)
	{
		return false;
	}

	protected override void OnFocus()
	{
	}

	protected override void OnLostFocus()
	{
	}

	private void BindEdgeDetectWidget()
	{
	}

	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	public void _003C_003EiFixBaseProxy_OnHudDragEnd(GameObject P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnFocus()
	{
	}

	public void _003C_003EiFixBaseProxy_OnLostFocus()
	{
	}
}
