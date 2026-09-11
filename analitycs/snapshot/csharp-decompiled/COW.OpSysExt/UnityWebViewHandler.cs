using UnityEngine;

namespace COW.OpSysExt;

public class UnityWebViewHandler : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public string msg;

		internal void _003CForceCloseAll_003Eb__0()
		{
		}
	}

	private const string UNITY_WEBVIEW_HANDLER = "UnityWebViewHandler";

	private static UnityWebViewHandler _I;

	public static UnityWebViewHandler I => null;

	public static void Init()
	{
	}

	public void OnWebViewMessage_Android(string msg)
	{
	}

	public void testResult(string result)
	{
	}

	public void ForceCloseAll(string msg)
	{
	}
}
