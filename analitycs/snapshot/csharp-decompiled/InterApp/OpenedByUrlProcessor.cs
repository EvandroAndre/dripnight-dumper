using System;
using System.Collections.Generic;

namespace InterApp;

public class OpenedByUrlProcessor
{
	public delegate bool WillProcessDelegate(string url);

	public delegate void ProcessDelegate(string url);

	public delegate bool CheckVersionDelegate(InterAppActionType actionType, InterAppAction action);

	public WillProcessDelegate WillProcessFallback;

	public ProcessDelegate ProcessFallback;

	public CheckVersionDelegate CheckClientVersion;

	public Action CheckVersionFallback;

	public const string STRING_VERSION = "version";

	public string ClientVersion;

	private string _Url;

	private string _ActionKey;

	private Dictionary<string, InterAppActionType> _ActionToType;

	private static readonly char[] PARAMETER_PAIR_SEPARATOR;

	private static readonly char[] PARAMETER_KEY_VALUE_SEPARATOR;

	public string Url => null;

	public string ActionKey => null;

	// C# has no syntax for parameterized property 'Item'.
	public InterAppActionType get_Item(string action)
	{
		return null;
	}

	public void set_Item(string action, InterAppActionType value)
	{
	}

	public OpenedByUrlProcessor(string url, string actionKey)
	{
	}

	public string Prepare(string url, string action, Dictionary<string, string> parameters = null, bool isDeepLink = false)
	{
		return null;
	}

	private bool ExtractParameters(string url, out InterAppActionType actionType, out InterAppAction action)
	{
		actionType = null;
		action = null;
		return false;
	}

	public bool WillProcess(string url)
	{
		return false;
	}

	public void Process(string url)
	{
	}

	public InterAppAction PeekInterAppAction(string url)
	{
		return null;
	}
}
