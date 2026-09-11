using ECAPackage;

namespace COW;

public class LitJsonProxy : IJsonProxy
{
	public T Parse<T>(string jsonString)
	{
		return default(T);
	}

	public string Serialize<T>(T obj, int option)
	{
		return null;
	}
}
