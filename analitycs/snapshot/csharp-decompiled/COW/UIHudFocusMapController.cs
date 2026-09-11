using GCommon;
using UnityEngine;

namespace COW;

public class UIHudFocusMapController : UIBaseController
{
	public enum EFocusMapUIType
	{
		ThrowerSelect,
		AstrolGate
	}

	private UIHudFocusMapView m_View;

	private Vector3? m_WorldPos;

	private Vector3 m_Center;

	private float OFFSET_SCALE_RATIO_X;

	private float m_MapLocalScale;

	private ResourceID m_UIFXResId;

	private VisualInstanceHolder m_UIFXHolder;

	private EFocusMapUIType m_UIType;

	public static readonly float FOCUS_MAP_DRAG_BOUNDS_OFFSET;

	private const int VIEWPORT_SIZE = 128;

	private RenderTexture m_FocusMapRT;

	private Camera m_FocusMapCamera;

	private UIWidget m_ViewportWidget;

	private Camera m_ViewportReferenceCamera;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void TryReleaseHolder()
	{
	}

	private void InitUIParams(UIMapUtil.MapOffsetContext ctx)
	{
	}

	public void InitByMapOffsetContext(UIMapUtil.MapOffsetContext ctx)
	{
	}

	public void UpdateMapPosition(Vector3 worldPos)
	{
	}

	public void RefreshView(UIWidget viewportWidget, ResourceID UIFXResId, float mapLocalScale, EFocusMapUIType uiType = EFocusMapUIType.ThrowerSelect)
	{
	}

	private void InitFocusMapCamera()
	{
	}

	public void SetViewportWidget(UIWidget widget, Camera referenceCamera = null)
	{
	}

	private void UpdateViewportFromWidget()
	{
	}

	private void SetActiveFocusMapCamera(bool active)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
