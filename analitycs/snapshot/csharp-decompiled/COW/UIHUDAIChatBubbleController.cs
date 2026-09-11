using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDAIChatBubbleController : UIBaseController, IAIChatDraggableItem
{
	private UIHUDAIChatBubbleView m_View;

	private const int LABBEL_MARGIN = 24;

	private bool m_FreezeText;

	private uint m_FreezeDelayCall;

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

	public void SetContainerWidgetPosition(Vector3 location)
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

	public bool IsDragging()
	{
		return false;
	}

	public Vector2 GetBound()
	{
		return default(Vector2);
	}

	public void SetViewData(string text, float freezeTime = 0f)
	{
	}

	public void RefreshArrowPivot(EAIChatBubblePivot pivot)
	{
	}

	public void SetDepth(int depth)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void _003CSetViewData_003Eb__12_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
