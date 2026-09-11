using System;
using UnityEngine;

namespace COW;

public class UISparkPetDragDropItem : UIDragDropItem
{
	private UISparkPetAvatar m_SparkPetAvatar;

	private UISparkPetAvatarWindowController m_Controller;

	private Camera m_Camera;

	private UIRoot m_Root;

	private float m_ScreenToUIRatio;

	private UIWidget m_Widget;

	private float m_WidgetHeightInWorld;

	public Action OnDragStartCallback;

	public Action OnDragEndCallback;

	public Action OnClickCallback;

	public Action m_OnOtherSparkDragStartCallback;

	public Action<Vector2> m_OnOtherSparkDragEndCallback;

	public Action<GameObject> m_OnOtherSparkClickCallback;

	public void Init(UISparkPetAvatar sparkPetAvatar, UISparkPetAvatarWindowController controller, Camera camera, UIWidget widget)
	{
	}

	public void SetOtherCallBackAction(Action onOtherSparkDragStartCallback, Action<Vector2> onOtherSparkDragEndCallback, Action<GameObject> onOtherSparkClickCallback)
	{
	}

	public void CallDragDropStart()
	{
	}

	public void CallDragDropMove(Vector2 delta)
	{
	}

	public void CallOnDragDropRelease(GameObject surface)
	{
	}

	protected override void OnDragDropStart()
	{
	}

	protected override void OnDragDropMove(Vector2 delta)
	{
	}

	protected override void OnDragDropRelease(GameObject surface)
	{
	}

	protected override void OnPress(bool isPressed)
	{
	}

	private void OnSparkPetClicked()
	{
	}

	public void SetDragBoundsAuto(float insetX = 0f, float insetY = 0f)
	{
	}

	public void SetDragBoundsManual(float minX, float maxX, float minY, float maxY)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropStart()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropMove(Vector2 P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropRelease(GameObject P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnPress(bool P0)
	{
	}
}
