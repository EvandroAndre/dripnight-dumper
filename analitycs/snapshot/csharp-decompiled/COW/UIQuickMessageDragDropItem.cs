using UnityEngine;

namespace COW;

public class UIQuickMessageDragDropItem : UIDragDropItem
{
	public bool UseCustomRestriction;

	private bool? m_HasMovedAfterPressed;

	private UIQuickMessageSettingController m_Parent;

	private IQuickMsgItemData m_MsgItemData;

	private bool m_IsOnDisable;

	public void Init(UIQuickMessageSettingController parent, IQuickMsgItemData msgItemData, GameObject clonedTemplate)
	{
	}

	protected override void OnDragStart()
	{
	}

	protected override void Update()
	{
	}

	private void MyStartDraging()
	{
	}

	private bool CheckIsCanDrag()
	{
		return false;
	}

	protected override void OnDragDropMove(Vector2 delta)
	{
	}

	protected override void OnDragDropRelease(GameObject surface)
	{
	}

	protected override void OnDisable()
	{
	}

	private void _003CUpdate_003Eb__6_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragStart()
	{
	}

	public void _003C_003EiFixBaseProxy_Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropMove(Vector2 P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropRelease(GameObject P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDisable()
	{
	}
}
