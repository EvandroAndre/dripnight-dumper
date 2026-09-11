using UnityEngine;

public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
	private static T m_Instance;

	public static T instance => null;

	public static bool hasInstance => false;

	protected virtual void Awake()
	{
	}

	public virtual void Init()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	private void OnApplicationQuit()
	{
	}
}
