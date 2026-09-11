using UnityEngine;

namespace VoxelBusters.ReplayKit.Common.DesignPatterns;

public class SingletonPattern<T> : MonoBehaviour, ISingleton where T : MonoBehaviour
{
	protected static T instance;

	protected static object instanceLock;

	protected static bool destroyedOnApplicationQuit;

	private Transform m_transform;

	private GameObject m_gameObject;

	private bool m_isInitialized;

	private bool m_isForcefullyDestroyed;

	public static T Instance
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public Transform CachedTransform => null;

	public GameObject CachedGameObject => null;

	private void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void Reset()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected virtual void Init()
	{
	}

	public void ForceDestroy()
	{
	}
}
