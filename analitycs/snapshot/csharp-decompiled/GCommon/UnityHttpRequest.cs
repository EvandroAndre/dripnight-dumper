using System;
using System.Collections.Generic;
using UnityEngine.Networking;

namespace GCommon;

public class UnityHttpRequest : IHttpRequest
{
	public static bool DelegateCheck;

	private const int MAX_RETRY_COUNT = 5;

	public string URL;

	private string _003CCmd_003Ek__BackingField;

	public float Timeout;

	public byte[] Data;

	public Dictionary<string, string> Headers;

	public UnityWebRequest Request;

	public StreamingDownloadHandler DownloadHandler;

	public Action<HttpErrorCode, byte[], int> OnFinished;

	public Action<byte[], int, int> OnUpdate;

	public uint HttpOption;

	public int PreHandledContentLen;

	public int PreContentLen;

	private bool _003CIsDone_003Ek__BackingField;

	public bool IsTimeOut;

	private HttpManager.Priority priority;

	public int StartFrameCount;

	public HttpRequestState State;

	private int m_SendCount;

	private float m_ReqStartTime;

	private float m_LastActiveTime;

	private string _003CLastHttpErrorMessage_003Ek__BackingField;

	private HttpErrorCode m_LastHttpErrorCode;

	public string Cmd
	{
		get
		{
			return _003CCmd_003Ek__BackingField;
		}
		set
		{
			_003CCmd_003Ek__BackingField = value;
		}
	}

	public bool IsDone
	{
		get
		{
			return _003CIsDone_003Ek__BackingField;
		}
		set
		{
			_003CIsDone_003Ek__BackingField = value;
		}
	}

	public HttpManager.Priority Priority
	{
		get
		{
			return HttpManager.Priority.Normal;
		}
		set
		{
		}
	}

	public string LastHttpErrorMessage
	{
		get
		{
			return _003CLastHttpErrorMessage_003Ek__BackingField;
		}
		private set
		{
			_003CLastHttpErrorMessage_003Ek__BackingField = value;
		}
	}

	public HttpErrorCode LastHttpErrorCode
	{
		get
		{
			return HttpErrorCode.OK;
		}
		private set
		{
		}
	}

	public bool Start()
	{
		return false;
	}

	public bool Start(string token, string releaseVersion)
	{
		return false;
	}

	public bool IsStarted()
	{
		return false;
	}

	public bool IsExpired()
	{
		return false;
	}

	public bool IsFinished()
	{
		return false;
	}

	public bool IsUnauthorized()
	{
		return false;
	}

	public void UpdateLastActiveTime()
	{
	}

	public void OnUnauthorized()
	{
	}

	public bool NeedNotify()
	{
		return false;
	}

	public bool RecordIfHasError()
	{
		return false;
	}

	public void Dispose()
	{
	}

	private HttpErrorCode GetResponseCode()
	{
		return HttpErrorCode.OK;
	}

	public void InvokeOnFinished(HttpErrorCode httpErrorCode, byte[] allDownloadedData, string httpErrorMsg, int downloadedSize)
	{
	}

	public void Cancel()
	{
	}
}
