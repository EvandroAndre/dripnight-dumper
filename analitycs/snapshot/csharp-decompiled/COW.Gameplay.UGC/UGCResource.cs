using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCResource
{
	public delegate void OnUGCResourceChanged(UGCResource res);

	protected string m_uuid;

	protected bool m_isLoading;

	protected int m_refCount;

	public bool UnloadAble;

	protected int m_loadingDependCound_;

	private bool _003CAutoInvokeLoadCallback_003Ek__BackingField;

	private List<object> m_loadCallbackList;

	public Action<bool> LoadCallbackInvoker;

	protected List<OnUGCResourceChanged> onUGCResourceChangeds;

	protected List<UGCCompConnectGameObject> ConnectGameObjects;

	public bool IsLoadedAfterNextCompleted => false;

	public bool IsLoaded
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string UUID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected int m_loadingDependCound
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool AutoInvokeLoadCallback
	{
		get
		{
			return _003CAutoInvokeLoadCallback_003Ek__BackingField;
		}
		set
		{
			_003CAutoInvokeLoadCallback_003Ek__BackingField = value;
		}
	}

	public List<object> LoadCallbackList => null;

	public virtual void SetLoadParams(IUGCResourceLoadParams loadParams)
	{
	}

	public virtual string[] GetDependenceResources()
	{
		return null;
	}

	public virtual bool LoadFromData(byte[] data)
	{
		return false;
	}

	public virtual void OnUnityObjectLoaded(bool isSucc, UnityEngine.Object resObject)
	{
	}

	public virtual void OnUnityObjectLoadedWithSub(bool isSucc, UnityEngine.Object resObject, string subIndex)
	{
	}

	public virtual void ReleaseUnityResRef()
	{
	}

	public virtual void Unload()
	{
	}

	protected virtual void AfterOneDependLoaded()
	{
	}

	public void AddLoadCallback(object callback)
	{
	}

	public void CallbackLoadFinished(bool isSucc)
	{
	}

	public void AddRef()
	{
	}

	public void DecRef()
	{
	}

	public bool AddChangeNotify(OnUGCResourceChanged callback)
	{
		return false;
	}

	public void RemoveChangeNotify(OnUGCResourceChanged callback)
	{
	}

	public void NotifyChangedWhoUseMe()
	{
	}

	public void AddGameObjectConnect(GameObject obj)
	{
	}

	public void RemoveGameObjectConnect(UGCCompConnectGameObject conn)
	{
	}
}
