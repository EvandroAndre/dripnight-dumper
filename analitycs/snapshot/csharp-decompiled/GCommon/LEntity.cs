using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class LEntity : PooledClassObject, IEntityTicker, IEntityInfo
{
	private bool m_LResActive;

	public bool NeedUpdate;

	public bool NeedStreamerUpdate;

	public bool NeedStreamerDynamic;

	public bool NeedPVS;

	public bool NeedPVSCullParticleSystem;

	protected bool m_VisibleHandlerRegistered;

	public EntityInfo m_EntityInfo;

	private Dictionary<string, ITransformNode> m_cachedTransformNodeDic;

	private ITransformNode m_emptyTransformNode;

	public bool IsInTrigger;

	private GameObject gameobject;

	private LTransform lTransform;

	private uint m_UniqueID;

	protected EEntityProxyType m_ProxyType;

	public virtual bool EnableAsyncLoad => false;

	public virtual ResourceID LResID => default(ResourceID);

	protected bool LResActive
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public GameObject gameObject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public LTransform LTransform => null;

	public uint UniqueID => 0u;

	public EntityInfo GetEntityInfo()
	{
		return default(EntityInfo);
	}

	public virtual void InitEntityInfo()
	{
	}

	public void LoadRes()
	{
	}

	private void LoadModelCallBack(uint uniqueid, bool success, Object obj)
	{
	}

	public virtual void RecyleLRes()
	{
	}

	protected virtual void RefreshLRes(bool recyle = true)
	{
	}

	protected virtual void OnLoadModel()
	{
	}

	public void SetNeedStreamerUpdate(bool v)
	{
	}

	public override void OnRelease()
	{
	}

	public virtual void Init()
	{
	}

	public void UpdateLActive(bool active)
	{
	}

	public bool CheckActive()
	{
		return false;
	}

	protected virtual bool CheckIsInStreamerRange(Vector3 checkPos)
	{
		return false;
	}

	public virtual void InitRes()
	{
	}

	public virtual void Start()
	{
	}

	public virtual void Destroy()
	{
	}

	public virtual void Recycle()
	{
	}

	public virtual void RecycleRes()
	{
	}

	public virtual void InitComponent()
	{
	}

	protected virtual bool NeedRecyleLRes()
	{
		return false;
	}

	protected bool NeedEnableStreamerDynamic()
	{
		return false;
	}

	public virtual void RegisterVisibleHandler()
	{
	}

	public virtual void UnregisterVisibleHandler()
	{
	}

	public virtual void OnInit()
	{
	}

	public virtual void OnInitRes()
	{
	}

	public virtual void OnStart()
	{
	}

	public virtual void OnDestroy()
	{
	}

	public virtual void OnRecycle()
	{
	}

	public virtual void OnRecycleRes()
	{
	}

	public virtual void OnRecyleLRes()
	{
	}

	public virtual void OnFixedUpdate(float gameTime, float deltaTime)
	{
	}

	public virtual void OnUpdate(float gameTime, float deltaTime)
	{
	}

	public virtual void OnPaused()
	{
	}

	public virtual void OnResumed()
	{
	}

	public bool IsAutonomousProxy()
	{
		return false;
	}

	public bool IsSimulatedProxy()
	{
		return false;
	}

	public void SetAutonomousProxy()
	{
	}

	public void SetSimulatedProxy()
	{
	}

	public float GetMaxBoundsExtent()
	{
		return 0f;
	}

	public virtual ITransformNode GetTransformNode(string name)
	{
		return null;
	}

	public static Bounds GetMaxBounds(Transform obj, bool needFindDeactive = false)
	{
		return default(Bounds);
	}

	public static float GetMaxBoundsExtent(Bounds bounds)
	{
		return 0f;
	}

	public static float GetMaxBoundsExtent(Transform obj)
	{
		return 0f;
	}

	public virtual void UpdateVisibleStateByStreamer(Vector3 min, Vector3 max)
	{
	}

	protected virtual void OnUpdateVisibleStateByStreamer(Vector3 min, Vector3 max)
	{
	}

	protected bool ForceCallStreamerUpdate()
	{
		return false;
	}

	protected void SetUniqueId(uint newId)
	{
	}
}
