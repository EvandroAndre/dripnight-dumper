using System;

namespace COW;

public abstract class UIUGCHudWidgetAttributeController<T> : UIUGCHudWidgetAttributeBaseController
{
	protected T m_AttributeData;

	protected Action<T> m_GetAction;

	public abstract T AttributeData { get; set; }

	public override object AttributeObject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void BindAttribute(T initValue, Action<T> get)
	{
	}

	public override void SetAttributeDirty()
	{
	}

	public virtual void InitAttribute(T data)
	{
	}
}
