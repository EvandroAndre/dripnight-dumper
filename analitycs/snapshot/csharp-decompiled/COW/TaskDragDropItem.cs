using System;
using GCommon;
using UnityEngine;

namespace COW;

public class TaskDragDropItem : UIDragDropItem
{
	public new int tag;

	public int value;

	public string soundStartDrag;

	public string soundReleaseDrag;

	public bool IsFinishDragDisableInteract;

	private TaskDragDropContainer m_LastDrop;

	private ResourceID m_resStartDrag;

	private ResourceID m_resReleaseDrag;

	public Action OnFinishRightRelease;

	protected override void Start()
	{
	}

	protected override void OnDragDropStart()
	{
	}

	protected override void OnDragDropRelease(GameObject surface)
	{
	}

	public void _003C_003EiFixBaseProxy_Start()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropStart()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropRelease(GameObject P0)
	{
	}
}
