using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDAIChatEntranceController : UIBaseController, IAIChatDraggableItem
{
	private UIHUDAIChatEntranceView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public Transform GetContainerWidgetTransform()
	{
		return null;
	}

	public Vector2 GetContainerWidgetSize()
	{
		return default(Vector2);
	}

	public void SetContainerWidgetPosition(Vector3 location)
	{
	}

	public bool IsDragging()
	{
		return false;
	}

	public Vector2 GetBound()
	{
		return default(Vector2);
	}

	public UIWidget GetMaskWidget()
	{
		return null;
	}

	public void FlipEntranceIcon(bool isFlip)
	{
	}

	public void SetTitleVisible(bool isVisible)
	{
	}

	public void SetDepth(int depth)
	{
	}

	public void RefreshDragRegion()
	{
	}

	private void OnChatEntranceClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
