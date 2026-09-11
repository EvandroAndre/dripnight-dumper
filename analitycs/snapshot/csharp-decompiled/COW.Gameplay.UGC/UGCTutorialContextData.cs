namespace COW.Gameplay.UGC;

public class UGCTutorialContextData
{
	public string contextType;

	public object content;

	public T GetContent<T>() where T : class
	{
		return null;
	}
}
