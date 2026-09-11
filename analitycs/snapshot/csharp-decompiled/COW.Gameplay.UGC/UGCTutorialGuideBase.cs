using System;

namespace COW.Gameplay.UGC;

public abstract class UGCTutorialGuideBase
{
	protected UGCTutorialGuideData m_Data;

	protected bool m_IsShowing;

	public string GuideId => null;

	public string GuideType => null;

	public bool IsShowing => false;

	public virtual bool IsBlocking => false;

	public void Init(UGCTutorialGuideData data)
	{
	}

	public void Show(Action onComplete)
	{
	}

	public void Hide()
	{
	}

	public void Dispose()
	{
	}

	protected virtual void OnInit()
	{
	}

	protected abstract void OnShow(Action onComplete);

	protected abstract void OnHide();

	protected virtual void OnDispose()
	{
	}
}
