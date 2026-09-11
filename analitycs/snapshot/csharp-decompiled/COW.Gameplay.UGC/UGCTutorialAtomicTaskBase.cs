using System;
using GCommon;

namespace COW.Gameplay.UGC;

public abstract class UGCTutorialAtomicTaskBase
{
	protected UGCTutorialAtomicTaskData m_Data;

	protected Action m_OnComplete;

	protected bool m_IsStarted;

	protected bool m_IsCompleted;

	private UGCTutorialContextData m_InputContext;

	private UGCTutorialContextData m_OutputContext;

	public string AtomicTaskId => null;

	public bool IsStarted => false;

	public bool IsCompleted => false;

	public UGCTutorialContextData OutputContext => null;

	public void Init(UGCTutorialAtomicTaskData data, Action onComplete)
	{
	}

	public void SetInputContext(UGCTutorialContextData context)
	{
	}

	protected UGCTutorialContextData GetInputContext()
	{
		return null;
	}

	protected T GetInputContextContent<T>() where T : class
	{
		return null;
	}

	protected void SetOutputContext(string contextType, object content)
	{
	}

	public void Start()
	{
	}

	public void Dispose()
	{
	}

	public abstract bool CheckCompletion();

	protected abstract void OnStart();

	protected abstract void OnDispose();

	protected virtual void AutoComplete()
	{
	}

	protected void Complete()
	{
	}

	protected EventDispatcher GetGameEventDispatcher()
	{
		return null;
	}

	protected void RefreshActiveGuides()
	{
	}
}
