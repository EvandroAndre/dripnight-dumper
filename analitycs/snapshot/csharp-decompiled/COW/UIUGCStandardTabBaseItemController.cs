using System;
using GCommon;

namespace COW;

public class UIUGCStandardTabBaseItemController : UIBaseController
{
	protected Action<string> SelectCallBack;

	protected UGCStandardTabItemViewData m_Data;

	public virtual void OnSelected()
	{
	}

	public virtual void OnUnSelected()
	{
	}

	public void SetItemSelectCallBack(Action<string> action)
	{
	}

	public virtual void Disappear()
	{
	}

	public virtual void Appear()
	{
	}

	public virtual int WidgetHeight()
	{
		return 0;
	}

	public virtual void RefreshSize()
	{
	}
}
