using System.Collections.Generic;
using GCommon;

namespace COW;

public class WaitingResponseHandlerWithRequest
{
	private Dictionary<string, HttpRequest> m_WaitingHttpRequestDict;

	public void Clear()
	{
	}

	public void WaitWithRequest(string id, HttpRequest req)
	{
	}

	public void CancelWaitWithRequest(string id)
	{
	}

	public bool IsPendingWithRequest(string id, out HttpRequest req)
	{
		req = null;
		return false;
	}
}
