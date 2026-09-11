using System;

namespace COW;

public class AutoTaskCommonErrorWnd : AutoPopupTask
{
	private UICommonErrorWndController m_UIController;

	private string _003CMessage_003Ek__BackingField;

	private string _003CTitle_003Ek__BackingField;

	private Action _003CCallback_003Ek__BackingField;

	public string Message
	{
		get
		{
			return _003CMessage_003Ek__BackingField;
		}
		set
		{
			_003CMessage_003Ek__BackingField = value;
		}
	}

	public string Title
	{
		get
		{
			return _003CTitle_003Ek__BackingField;
		}
		set
		{
			_003CTitle_003Ek__BackingField = value;
		}
	}

	public Action Callback
	{
		get
		{
			return _003CCallback_003Ek__BackingField;
		}
		set
		{
			_003CCallback_003Ek__BackingField = value;
		}
	}

	public override bool Do()
	{
		return false;
	}

	public override bool IsDone()
	{
		return false;
	}

	public override int[] NeedHttpRequests()
	{
		return null;
	}
}
