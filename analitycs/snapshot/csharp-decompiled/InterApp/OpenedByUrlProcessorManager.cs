using System.Collections.Generic;

namespace InterApp;

public class OpenedByUrlProcessorManager
{
	private static OpenedByUrlProcessorManager _I;

	private static readonly char[] URL_STRIP_SEPARATOR;

	private Dictionary<string, OpenedByUrlProcessor> _UriToProcessor;

	public static OpenedByUrlProcessorManager I => null;

	// C# has no syntax for parameterized property 'Item'.
	public OpenedByUrlProcessor get_Item(string uri)
	{
		return null;
	}

	public void set_Item(string uri, OpenedByUrlProcessor value)
	{
	}

	private OpenedByUrlProcessorManager()
	{
	}

	public static string UrlStrip(string uri)
	{
		return null;
	}
}
