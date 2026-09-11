using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using TsiU;

namespace GCommon;

public class HttpManager : TSingleton<HttpManager>
{
	private class TokenInfo
	{
		public string Token;

		public uint TTL;

		public uint ValidTime;
	}

	public enum EHttpChannel
	{
		Main,
		Second,
		Background,
		LLM
	}

	public enum Priority
	{
		Normal,
		Urgent,
		UrgentKeepOrder
	}

	public class HttpChannel
	{
		private LinkedList<IHttpRequest> m_Requests;

		public bool UseSystemTimeout;

		public static bool HttpRequestDispose;

		public bool SendNextSameFrame;

		public bool CanUseProxy;

		public IEnumerable<IHttpRequest> HttpRequests => null;

		public IHttpRequest GetCurrentRequest()
		{
			return null;
		}

		public void Append(IHttpRequest req)
		{
		}

		public void Insert(IHttpRequest req)
		{
		}

		public void Insert(IHttpRequest req, int index)
		{
		}

		public void InsertUrgentKeepOrder(IHttpRequest req)
		{
		}

		public int FindRequest(string httpMessgeType)
		{
			return 0;
		}

		public LinkedListNode<IHttpRequest> GetNode(int index)
		{
			return null;
		}

		public void RemoveNode(IHttpRequest node)
		{
		}

		public int MoveAfter(int srcIndex, int dstIndex)
		{
			return 0;
		}

		public bool IsExpired(IHttpRequest req)
		{
			return false;
		}

		public void Done(IHttpRequest req)
		{
		}

		public int ReuqestCount()
		{
			return 0;
		}

		public void Clear()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass47_0<T>
	{
		public HttpManager _003C_003E4__this;

		public string cmd;

		public Action<HttpErrorCode, object> onFinished;

		internal void _003CCreatePostReq_003Eb__0(HttpErrorCode errCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass61_0
	{
		public HttpManager _003C_003E4__this;

		public string cmd;

		public Action<HttpErrorCode, byte[], int> onFinished;

		internal void _003CRequestPostStream_003Eb__0(HttpErrorCode httpErrCode, byte[] allData, int dataSize)
		{
		}
	}

	public const uint HTTPOPTION_DEFAULT = 0u;

	public const uint HTTPOPTION_SILENCE = 2u;

	public const uint HTTPOPTION_BLOCK = 4u;

	private const float DEFAULT_TIMEOUT = 10f;

	public static string ReleaseVersion;

	public static bool HttpRequestDispose;

	public static bool HttpDeserializeInThread;

	public static bool SendNextSameFrame;

	public static bool OpenBackgroundChannel;

	private bool m_RunResponseDeserializeThread;

	private static byte[] placeholder;

	private Dictionary<int, HttpChannel> m_HttpChannels;

	private TokenInfo m_TokenInfo;

	private IHttpManagerMonitor m_Impl;

	private EHttpDataType m_ReqDataType;

	private EHttpDataType m_ResDataType;

	private AesManaged m_aes;

	private bool m_EnableEncrypt;

	private Queue<HttpRequest> m_ResponseQueue;

	private AntiAddicHistoryInfo m_AntiAddicHistoryInfo;

	private Thread m_ResponseDesrializeThread;

	private AutoResetEvent m_NotifyDesrializeEvent;

	private EHttpChannel m_CurrentChannel;

	public EHttpChannel CurrentChannel => EHttpChannel.Main;

	public string LastErrorMessage => null;

	public HttpErrorCode LastErrorCode => HttpErrorCode.OK;

	public void Init()
	{
	}

	public void SetImpl(IHttpManagerMonitor impl)
	{
	}

	public void UpdateTokenInfo(string token, uint ttl)
	{
	}

	public string GetToken()
	{
		return null;
	}

	public uint GetTokenValidTime()
	{
		return 0u;
	}

	public void Clear()
	{
	}

	public void Update(float gameTime)
	{
	}

	private void UpdateRequestState(HttpChannel channel, EHttpChannel channelType, IHttpRequest curIReq, out bool isDone)
	{
		isDone = default(bool);
	}

	private void UpdateHttpRequestStateInternal(HttpChannel channel, EHttpChannel channelType, HttpRequest curReq, out bool isDone)
	{
		isDone = default(bool);
	}

	private void DoneHttpRequest(HttpChannel channel, EHttpChannel channelType, IHttpRequest req)
	{
	}

	public EHttpChannel OverrideChannel(EHttpChannel channel, string cmd)
	{
		return EHttpChannel.Main;
	}

	public HttpRequest RequestPost<T>(string url, string cmd, object data, Action<HttpErrorCode, object> onFinished = null, float timeout = 0f, uint http_option = 0u, EHttpDataType reqDataType = EHttpDataType.None, EHttpDataType resDataType = EHttpDataType.None, EHttpChannel channel = EHttpChannel.Main, bool encrypt = true, LoadingType loadingType = LoadingType.CircleLoading, Priority priority = Priority.Normal, int urgentAfterIndex = -1, bool sendImmediately = false, Dictionary<string, string> customHeaders = null, Action OnDeserialize = null)
	{
		return null;
	}

	public void RequestGet<T>(string url, string cmd, Action<HttpErrorCode, object> onFinished, float timeout, [Optional][DefaultParameterValue(0u)] uint http_option, [Optional][DefaultParameterValue(0)] EHttpDataType resDataType, [Optional][DefaultParameterValue(0)] EHttpChannel channel, [Optional][DefaultParameterValue(0)] LoadingType loadingType, object[] args)
	{
	}

	private HttpRequest CreatePostReq(string url, string cmd, object data, EHttpDataType reqDataType = EHttpDataType.None, EHttpDataType resDataType = EHttpDataType.None)
	{
		return null;
	}

	private HttpRequest CreatePostReq<T>(string url, string cmd, object data, Action<HttpErrorCode, object> onFinished, float timeout = 0f, uint http_option = 0u, EHttpDataType reqDataType = EHttpDataType.None, EHttpDataType resDataType = EHttpDataType.None, bool encrypt = true, LoadingType loadingType = LoadingType.CircleLoading, Priority priority = Priority.Normal, Dictionary<string, string> customHeaders = null, Action OnDeserialize = null)
	{
		return null;
	}

	private void ProcessCustomHeaders(Dictionary<string, string> targetHeaders, Dictionary<string, string> customHeaders)
	{
	}

	public byte[] Encrypt(byte[] data)
	{
		return null;
	}

	public bool IsCmdInQueue(string cmd, ref IHttpRequest httpReq)
	{
		return false;
	}

	public bool IsCmdInQueue(string cmd)
	{
		return false;
	}

	public void FindRequest(string cmd, out EHttpChannel requestChannel, out int index)
	{
		requestChannel = default(EHttpChannel);
		index = default(int);
	}

	public bool FindRequest(IHttpRequest req, out EHttpChannel requestChannel)
	{
		requestChannel = default(EHttpChannel);
		return false;
	}

	public void SetUrgentKeepOrder(string cmd)
	{
	}

	public void RemoveRequest(IHttpRequest req)
	{
	}

	public void UpdateAntiAddictionInfo(AntiAddicHistoryInfo antiAddicHistoryInfo)
	{
	}

	public AntiAddicHistoryInfo GetAntiAddicHistoryInfo()
	{
		return null;
	}

	private void ResponseDeserializeThread()
	{
	}

	public void OnApplicationQuit()
	{
	}

	private void UpdateUnityWebRequestStateInternal(HttpChannel channel, EHttpChannel channelType, UnityHttpRequest curReq, out bool isDone)
	{
		isDone = default(bool);
	}

	public UnityHttpRequest RequestPostStream(string url, string cmd, object requestData, Action<HttpErrorCode, byte[], int> onFinished, Action<byte[], int, int> onUpdate, float timeout, EHttpDataType reqDataType, EHttpChannel channel, bool encrypt, bool sendImmediately, Dictionary<string, string> customHeaders)
	{
		return null;
	}

	private UnityHttpRequest CreateRequest(string url, string cmd, object data, Action<HttpErrorCode, byte[], int> onFinished, Action<byte[], int, int> onUpdate, float timeout, uint http_option, EHttpDataType reqDataType, bool encrypt, Priority priority, Dictionary<string, string> customHeaders)
	{
		return null;
	}

	private void AddRequestToChannel(EHttpChannel channel, int urgentAfterIndex, bool sendImmediately, UnityHttpRequest req)
	{
	}
}
