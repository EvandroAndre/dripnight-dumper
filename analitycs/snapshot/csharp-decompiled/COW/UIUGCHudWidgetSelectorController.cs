using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCHudWidgetSelectorController : UIBaseController
{
	private UIUGCHudWidgetSelectorView m_View;

	private UGCHudWidget m_Widget;

	private Transform m_FrameTrans;

	private UIModelUGCHudEdit m_Model;

	private bool m_IsPressWidget;

	private bool m_IsDrag;

	private Vector3 m_LastLocalPosition;

	private const int MIN_WIDTH = 6;

	private const int MIN_HEIGHT = 6;

	public int Width => 0;

	public int Height => 0;

	public Transform FrameTrans => null;

	public UIWidget FrameWidget => null;

	public UGCHudWidget Widget => null;

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

	public void BindWidget(UGCHudWidget widget)
	{
	}

	public void SetPosition(Vector3 positon)
	{
	}

	public void SetRotation(Quaternion rotation)
	{
	}

	public void ResizeWidget(UIWidget.Pivot pivot, float x, float y)
	{
	}

	public void RotateWidget(float deltaAngle)
	{
	}

	public void SetFrameColor(Color frameColor)
	{
	}

	private void OnBindWidgetHorizontalAlignmentChanged(UGCHudWidget.HorizontalAlignmentEnum value)
	{
	}

	private void OnBindWidgetVerticalAlignmentChanged(UGCHudWidget.VerticalAlignmentEnum value)
	{
	}

	private void OnBindWidgetPositionChanged()
	{
	}

	private void OnBindWidgetRotationChanged()
	{
	}

	private void OnBindWidgetSizeChanged()
	{
	}

	private void OnDragStart(GameObject go)
	{
	}

	private void OnDrag(GameObject go, Vector2 delta)
	{
	}

	private void OnDragEnd(GameObject go)
	{
	}

	private void OnWidgetPress(GameObject go, bool pressed)
	{
	}

	private void OnWidgetDrag(GameObject go, Vector2 delta)
	{
	}

	private void OnClickTopLeft(GameObject go)
	{
	}

	private void OnClickBottomLeft(GameObject go)
	{
	}

	private void OnAdjustPointDragStart(UIWidget.Pivot pivotType, GameObject point)
	{
	}

	private void OnAdjustPointDrag(UIWidget.Pivot pivotType, Vector2 delta, GameObject point)
	{
	}

	private void OnAdjustPointDragEnd(UIWidget.Pivot pivotType, GameObject point)
	{
	}

	private UIWidget.Pivot GetPivot(GameObject go)
	{
		return UIWidget.Pivot.TopLeft;
	}

	private void _003COnClickTopLeft_003Eb__38_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
