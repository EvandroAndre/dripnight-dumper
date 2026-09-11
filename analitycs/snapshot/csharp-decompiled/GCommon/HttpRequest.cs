using System;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class HttpRequest : IHttpRequest
{
	public static bool DelegateCheck;

	private const int MAX_RETRY_COUNT = 5;

	public string URL;

	private string cmd;

	public float Timeout;

	public byte[] Data;

	public Dictionary<string, string> Headers;

	public WWW www;

	public Action<HttpErrorCode, object> OnFinished;

	public Action OnDeserialize;

	public Type ResponseType;

	public EHttpDataType DataType;

	public uint HttpOption;

	private bool isDone;

	public bool IsBlock;

	public bool IsTimeOut;

	private HttpManager.Priority priority;

	public int StartFrameCount;

	public object DeserializedObject;

	public bool HaveDeserializeObject;

	public HttpRequestState State;

	public byte[] ThreadSerializedBytes;

	private int m_SendCount;

	private float m_ReqStartTime;

	private string m_LastErrorMessage;

	private HttpErrorCode m_LastHttpErrorCode;

	public LoadingType loadingType;

	public string Cmd
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsDone
	{
		get
		{
			return false;
		}
		set
		{
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

	public float ReqStartTime => 0f;

	public string LastHttpErrorMessage => null;

	public HttpErrorCode LastHttpErrorCode => HttpErrorCode.OK;

	public bool Start()
	{
		return false;
	}

	public bool Start(string token, string releaseVersion)
	{
		return false;
	}

	public bool NeedRetry()
	{
		return false;
	}

	public bool HasRetried()
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

	public void OnUnauthorized()
	{
	}

	public void DeserializeInThread()
	{
	}

	public void Deserialize(byte[] data)
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

	public void Notify()
	{
	}

	public void InvokeOnDeserialize()
	{
	}

	public void Dispose()
	{
	}

	private HttpErrorCode GetResponseCode()
	{
		return HttpErrorCode.OK;
	}

	private HttpErrorCode GetDetailedExectionError()
	{
		return HttpErrorCode.OK;
	}

	private void InvokeFinished(HttpErrorCode errorCode, object res, string errorMsg)
	{
	}
}
