using UnityEngine;

namespace COW;

public class TaskDragDropContainer : UIDragDropContainer
{
	public Transform[] targetPosition;

	public bool attached;

	public new int tag;

	public int value;

	private int m_TarIdx;

	private void Awake()
	{
	}

	public virtual void OnAddItem(TaskDragDropItem item)
	{
	}

	public virtual void OnRemoveItem(TaskDragDropItem item)
	{
	}

	public virtual bool Check()
	{
		return false;
	}
}
