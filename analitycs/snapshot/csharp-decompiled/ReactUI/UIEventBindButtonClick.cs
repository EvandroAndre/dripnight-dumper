using System;

namespace ReactUI;

public sealed class UIEventBindButtonClick : UIEventBind
{
	private string eventName;

	private UIButton button;

	private SignalDelegateList m_delegateList;

	[NonSerialized]
	public bool IsInterceptClickEvent;

	private Action m_OnInterceptClickEvent;

	public event Action OnInterceptClickEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	private SignalDelegateList GetDelegateList()
	{
		return null;
	}

	protected override void RefreshBind()
	{
	}

	private new void Awake()
	{
	}

	private void OnButtonClick()
	{
	}

	protected override void OnDestroy()
	{
	}
}
