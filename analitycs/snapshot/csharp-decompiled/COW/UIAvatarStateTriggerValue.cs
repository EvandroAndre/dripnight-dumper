namespace COW;

public class UIAvatarStateTriggerValue<T> where T : struct
{
	private T m_value;

	public void Set(T t)
	{
	}

	public T GetAndReset()
	{
		return default(T);
	}

	public void CloneTo(UIAvatarStateTriggerValue<T> s)
	{
	}
}
