using UnityEngine;

public class BaseTableItem : MonoBehaviour, ILayoutTableItem
{
	private UIWidget m_Widget;

	protected bool m_HasInit;

	public bool m_SkipPadding;

	public virtual void Init()
	{
	}

	public virtual void UnInit()
	{
	}

	public virtual Vector2 GetSize()
	{
		return default(Vector2);
	}

	protected virtual void EditorExecute()
	{
	}

	public virtual bool SkipPadding()
	{
		return false;
	}
}
