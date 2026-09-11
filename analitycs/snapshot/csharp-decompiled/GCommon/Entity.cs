using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class Entity : MonoBehaviour, IEntityTicker, IEntityInfo
{
	public static uint sUniqueEntityID;

	public bool NeedUpdate;

	public bool NeedStreamerUpdate;

	public bool UseNeedStreamerDynamic;

	public bool NeedStreamerDynamic;

	public bool NeedUpdateStreamerOnRegister;

	public bool NeedPVS;

	public bool NeedPVSCullParticleSystem;

	private bool m_VisibleHandlerRegistered;

	private bool m_Recycle;

	protected EntityInfo m_EntityInfo;

	private Dictionary<string, ITransformNode> m_cachedTransformNodeDic;

	private ITransformNode m_emptyTransformNode;

	private static List<Transform> s_reusedChildrenList;

	protected Transform m_CachedTransform;

	private uint m_UniqueID;

	protected EEntityProxyType m_ProxyType;

	public virtual Transform CachedTransform => null;

	public Vector3 Position
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 Forward
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 Right
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 Up
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Quaternion Rotation
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	public uint UniqueID => 0u;

	private static uint GetUniqueID()
	{
		return 0u;
	}

	public EntityInfo GetEntityInfo()
	{
		return default(EntityInfo);
	}

	public virtual void InitEntityInfo()
	{
	}

	public void SetNeedStreamerUpdate(bool v)
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	protected virtual void UpdateVisibleOnRegister()
	{
	}

	public void RegisterVisibleHandler()
	{
	}

	public void UnregisterVisibleHandler()
	{
	}

	public void RegisterVisibleHandlerEnableStreamerDynamic()
	{
	}

	public void UnregisterVisibleHandlerEnableStreamerDynamic()
	{
	}

	public virtual void Show()
	{
	}

	public virtual void Hide()
	{
	}

	public virtual void ReUse()
	{
	}

	public virtual bool Recycle()
	{
		return false;
	}

	protected virtual void OnAwake()
	{
	}

	protected virtual void OnStart()
	{
	}

	public virtual void OnReUse()
	{
	}

	public virtual void OnRecycle()
	{
	}

	public virtual void OnRecycleClearData()
	{
	}

	protected virtual void OnOnDestroy()
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

	public static Transform FindTransformByName(GameObject go, string name, bool reverse = false)
	{
		return null;
	}

	public static Bounds GetMaxBounds(Transform obj, bool needFindDeactive = false)
	{
		return default(Bounds);
	}

	public static Bounds GetMaxBoundsUseCustom(Transform obj, bool needFindDeactive = false, CustomBounds[] custombounds = null)
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

	protected virtual void UpdateVisibleStateByStreamer(Vector3 min, Vector3 max)
	{
	}

	protected virtual void OnUpdateVisibleStateByStreamer(Vector3 min, Vector3 max)
	{
	}

	protected void TryClearLocalPlayerTriggerEntityInfo(Collider specificTrigger = null)
	{
	}

	protected bool ForceCallStreamerUpdate()
	{
		return false;
	}

	protected void SetUniqueId(uint newId)
	{
	}

	public virtual void RecycleForInGameReload()
	{
	}

	public virtual void ResetForInGameReload()
	{
	}
}
