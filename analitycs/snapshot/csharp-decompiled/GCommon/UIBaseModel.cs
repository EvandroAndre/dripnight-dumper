using System.Collections.Generic;

namespace GCommon;

public abstract class UIBaseModel
{
	public static bool ObserverCheck;

	public static bool SceneChangeCalledInLoadAndRun;

	public static bool SceneChangeRemoveUIObserver;

	private List<IUIModelDataChangeObserver> m_Observers;

	private int m_NotityCount;

	public virtual void Init()
	{
	}

	public void RegisterDataChangedNotification(IUIModelDataChangeObserver observer)
	{
	}

	public void UnRegisterDataChangedNotification(IUIModelDataChangeObserver observer)
	{
	}

	public virtual void NotifyDataChanged(uint propID, object[] param)
	{
	}

	public abstract uint GetModelType();

	public virtual void LoginOffline()
	{
	}

	public virtual void Login(object[] data)
	{
	}

	public virtual void Logout(object[] data)
	{
	}

	public virtual void SceneChange(object[] data)
	{
	}

	public void Cleanup()
	{
	}

	protected virtual void OnCleanup()
	{
	}

	protected virtual void OnSceneChange(object[] data)
	{
	}

	public virtual void ClearCache()
	{
	}

	public bool HasObserver(IUIModelDataChangeObserver observer)
	{
		return false;
	}
}
