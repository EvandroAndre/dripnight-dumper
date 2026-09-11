namespace GCommon;

public class Singleton<T> where T : class, new()
{
	private static T s_instance;

	public static T instance => null;

	protected Singleton()
	{
	}

	public static void CreateInstance()
	{
	}

	public static void DestroyInstance()
	{
	}

	public static T GetInstance()
	{
		return null;
	}

	public static bool HasInstance()
	{
		return false;
	}

	public virtual void Init()
	{
	}

	public virtual void UnInit()
	{
	}
}
