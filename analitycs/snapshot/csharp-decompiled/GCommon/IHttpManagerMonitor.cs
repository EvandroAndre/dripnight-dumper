namespace GCommon;

public interface IHttpManagerMonitor
{
	void OnStartRequest(HttpManager.EHttpChannel channel, HttpRequest curHttpReq);

	void OnEndRequest(HttpManager.EHttpChannel channel, string cmd, bool hasNext, IHttpRequest curHttpReq);

	void OnUnauthorized(HttpManager.EHttpChannel channel);

	void OnRetryFailed(HttpManager.EHttpChannel channel, HttpRequest curHttpReq);
}
