namespace GCommon;

public interface IHttpRequest
{
	HttpManager.Priority Priority { get; set; }

	string Cmd { get; set; }

	string LastHttpErrorMessage { get; }

	HttpErrorCode LastHttpErrorCode { get; }

	bool IsDone { get; set; }

	bool Start();

	bool Start(string token, string releaseVersion);

	bool IsStarted();

	bool IsExpired();

	bool IsFinished();

	bool IsUnauthorized();

	void OnUnauthorized();

	bool NeedNotify();

	bool RecordIfHasError();

	void Dispose();
}
