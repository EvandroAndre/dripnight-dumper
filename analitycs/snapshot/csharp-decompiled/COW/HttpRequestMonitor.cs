using System;
using GCommon;
using message;

namespace COW;

internal class HttpRequestMonitor : IHttpManagerMonitor
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__10_0;

		public static Action _003C_003E9__11_0;

		public static Action _003C_003E9__14_0;

		internal void _003COnUnauthorized_003Eb__10_0()
		{
		}

		internal void _003COnRetryFailed_003Eb__11_0()
		{
		}

		internal void _003COnApplicationResume_003Eb__14_0()
		{
		}
	}

	public ulong LoginTime;

	private bool forceBlockUI;

	private int m_HasSendCountSinceLoginDesc;

	private static HttpRequestMonitor instance;

	public static HttpRequestMonitor Instance => null;

	public void SetForceBlockUI(bool block)
	{
	}

	public bool ForceBlockUI()
	{
		return false;
	}

	public void OnStartRequest(HttpManager.EHttpChannel channel, HttpRequest curHttpReq)
	{
	}

	public void OnEndRequest(HttpManager.EHttpChannel channel, string cmd, bool hasNext, IHttpRequest curReq)
	{
	}

	public void OnUnauthorized(HttpManager.EHttpChannel channel)
	{
	}

	public void OnRetryFailed(HttpManager.EHttpChannel channel, HttpRequest curHttpReq)
	{
	}

	public bool IsQueueningHttpMessageType(ServiceMessageTypeHTTP httpMessgeType, ref IHttpRequest httpReq)
	{
		return false;
	}

	public bool IsQueueningHttpMessageType(ServiceMessageTypeHTTP httpMessgeType)
	{
		return false;
	}

	public void OnApplicationResume()
	{
	}

	public void ResetSendCountSinceLoginDesc()
	{
	}

	public int SendCountSinceLoginDesc()
	{
		return 0;
	}
}
