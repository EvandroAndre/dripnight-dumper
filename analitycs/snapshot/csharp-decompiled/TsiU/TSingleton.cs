namespace TsiU;

public class TSingleton<T> where T : class, new()
{
	protected static T _instance;

	public static T instance => null;
}
