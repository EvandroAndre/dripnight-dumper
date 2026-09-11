namespace GCommon;

public abstract class SingletonModule<T> : ISingletonModule where T : SingletonModule<T>, new()
{
	private static T _instance;

	private bool m_HasInited;

	private bool m_HasUnloadPartialMemory;

	public static T instance => null;

	public SingletonModule()
	{
	}

	public void Init()
	{
	}

	public void Cleanup()
	{
	}

	protected abstract void OnInit();

	protected abstract void OnCleanup();

	public void UnLoadMemoryIfNecessary()
	{
	}

	public void ReloadMemoryIfNecessary()
	{
	}

	public virtual bool NeedResetCleanup()
	{
		return false;
	}

	protected virtual void OnUnloadMemeory()
	{
	}

	protected virtual void OnReloadMemory()
	{
	}
}
