using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.OpSysExt;

internal class UnityWebViewInstanceHandler : MonoBehaviour
{
	[Serializable]
	private struct ConsoleMessage_Android
	{
		public string messageLevel;

		public int lineNumber;

		public string message;

		public string sourceId;
	}

	[Serializable]
	private struct WebViewClientError
	{
		public int webViewId;

		public int errorCode;

		public string errorMessage;

		public string failingUrl;

		public bool isMainFrame;

		public long timestamp;
	}

	[Serializable]
	private struct WebViewClientHttpError
	{
		public int webViewId;

		public int statusCode;

		public string reasonPhrase;

		public string failingUrl;

		public bool isMainFrame;

		public long timestamp;
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public UnityWebViewInstanceHandler _003C_003E4__this;

		public string filePath;

		internal void _003COnCaptureScreenshotSuccess_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public UnityWebViewInstanceHandler _003C_003E4__this;

		public string error;

		internal void _003COnCapturedScreenshotFailure_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public UnityWebViewInstanceHandler _003C_003E4__this;

		public bool canGoBackward;

		internal void _003CCanGoBackwardResult_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public UnityWebViewInstanceHandler _003C_003E4__this;

		public bool canGoForward;

		internal void _003CCanGoForwardResult_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public UnityWebViewInstanceHandler _003C_003E4__this;

		public string result;

		internal void _003COnFetchWebViewURLResult_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public UnityWebViewInstanceHandler _003C_003E4__this;

		public string data;

		internal void _003COnJavaScriptPostMessage_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public UnityWebViewInstanceHandler _003C_003E4__this;

		public string javaScriptResultString;

		internal void _003COnJavaScriptResult_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public string errorJson;

		public UnityWebViewInstanceHandler _003C_003E4__this;

		internal void _003COnReceivedError_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public string httpErrorJson;

		public UnityWebViewInstanceHandler _003C_003E4__this;

		internal void _003COnReceivedHttpError_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public UnityWebViewInstanceHandler _003C_003E4__this;

		public string userAgent;

		internal void _003COnGetUserAgentString_003Eb__0()
		{
		}
	}

	public Action<int, string> GetUserAgentStringCallback;

	public Action<int, string> FetchWebViewURLCallback;

	public Action<int, bool> CanGoBackwardCallback;

	public Action<int, bool> CanGoForwardCallback;

	private const string UNITY_WEBVIEW_INSTANCE_HANDLER_TEMPLATE = "UnityWebViewInstanceHandler_{0}";

	private static int _NextInstanceId;

	private static Dictionary<int, UnityWebViewInstanceHandler> _Handlers;

	private int _WebViewId;

	public Action<string> CaptureScreenshotSuccessCallback;

	public Action<string> CaptureScreenshotFailureCallback;

	private static int NewInstanceId()
	{
		return 0;
	}

	public static UnityWebViewInstanceHandler Create()
	{
		return null;
	}

	public static UnityWebViewInstanceHandler Get(int webViewId)
	{
		return null;
	}

	public static void Bind(int webViewId, UnityWebViewInstanceHandler handler)
	{
	}

	public static void Destroy(int webViewId)
	{
	}

	public static void DestroyAll()
	{
	}

	public void OnCaptureScreenshotSuccess(string filePath)
	{
	}

	public void OnCapturedScreenshotFailure(string error)
	{
	}

	public void CanGoBackwardResult(string result)
	{
	}

	public void CanGoForwardResult(string result)
	{
	}

	public void OnFetchWebViewURLResult(string result)
	{
	}

	public void OnJavaScriptPostMessage(string data)
	{
	}

	public void OnJavaScriptResult(string javaScriptResultString)
	{
	}

	public void OnWebViewMessage_Android(string msg)
	{
	}

	public void OnConsoleMessage_Android(string consoleMessage)
	{
	}

	public void OnReceivedError(string errorJson)
	{
	}

	public void OnReceivedHttpError(string httpErrorJson)
	{
	}

	public void OnGetUserAgentString(string userAgent)
	{
	}
}
