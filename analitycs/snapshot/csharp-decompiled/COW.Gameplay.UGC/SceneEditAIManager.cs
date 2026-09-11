using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using GCommon;
using UnityEngine;
using UnityEngine.Networking;
using message;
using proto;

namespace COW.Gameplay.UGC;

public class SceneEditAIManager : SingletonModule<SceneEditAIManager>
{
	public class ExportQuaternion
	{
		public string X;

		public string Y;

		public string Z;

		public string W;
	}

	public class ExportVector3
	{
		public string X;

		public string Y;

		public string Z;
	}

	public class ExportVector2
	{
		public string X;

		public string Y;
	}

	private enum MarkdownImageState
	{
		Normal,
		FoundExclamation,
		FoundOpenBracket,
		InAltText,
		FoundCloseBracket,
		FoundOpenParen,
		InImagePath,
		Complete
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<AICmd> _003C_003E9__35_0;

		internal int _003CProcessPropertySet_003Eb__35_0(AICmd a, AICmd b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass44_0
	{
		public byte[] bytes;

		internal void _003CExportAndUploadAllLogCmdBytes_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass56_0
	{
		public EUGCGICMDID cmdID;

		public string traceID;

		public Action<DOEOGBNPNAJ, ELLGAABJFFP, byte[]> onFinished;

		internal void _003CSendRequestToGI_003Eb__0(HttpErrorCode httpError, object respObj)
		{
		}

		internal void _003CSendRequestToGI_003Eb__1(HttpErrorCode httpError, object respObj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public string personaID;

		public EUGCGIPROTOCOL protocol;

		public Action<LLMResponse> onFinished;

		internal void _003CSendRequestToGIForPersona_003Eb__0(DOEOGBNPNAJ giError, ELLGAABJFFP giWarning, byte[] respData)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public LLMStreamResponseBase result;

		public EUGCGICMDID cmdID;

		public string traceID;

		public Action<LLMStreamResponseBase> onFinished;

		public SceneEditAIManager _003C_003E4__this;

		public bool hasRecordLatency;

		public double startTimeMs;

		public string personaID;

		public string remainingJsonString;

		public Action<LLMStreamResponseBase> onUpdate;

		internal void _003CSendRequestToGIForPersona_003Eb__0(HttpErrorCode httpError, byte[] allData, int dataLength)
		{
		}

		internal void _003CSendRequestToGIForPersona_003Eb__1(HttpErrorCode httpError, byte[] allData, int dataLength)
		{
		}

		internal void _003CSendRequestToGIForPersona_003Eb__2(byte[] unreadDataBuffer, int startIndex, int unreadDataLength)
		{
		}

		internal void _003CSendRequestToGIForPersona_003Eb__3(byte[] unreadDataBuffer, int startIndex, int unreadDataLength)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public AIAssistantResponse result;

		public EUGCGICMDID cmdID;

		public string traceID;

		public Action<AIAssistantResponse> onFinished;

		public SceneEditAIManager _003C_003E4__this;

		public Action<AIAssistantResponse> onUpdate;

		internal void _003CSendRequestToGIForAssistant_003Eb__0(HttpErrorCode httpError, byte[] allData, int dataLength)
		{
		}

		internal void _003CSendRequestToGIForAssistant_003Eb__1(byte[] dataBytes, int start, int count)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public SceneEditAIManager _003C_003E4__this;

		public AIAssistantResponse result;

		public EUGCGICMDID cmdID;

		public string traceID;

		public Action<AIAssistantResponse> onFinished;

		internal void _003CSendRequestToGIForASR_003Eb__0(HttpErrorCode httpError, byte[] allData, int dataLength)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass61_0
	{
		public Action<long, LLMStreamResponseForJson> onFinished;

		public long ticketID;

		public Action<long, LLMStreamResponseForJson> onUpdate;

		internal void _003CSendRequestToGIForBotAgent_003Eb__0(LLMStreamResponseBase result)
		{
		}

		internal void _003CSendRequestToGIForBotAgent_003Eb__1(LLMStreamResponseBase result)
		{
		}
	}

	private sealed class _003CUploadAllAILogInternal_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public byte[] data;

		public SceneEditAIManager _003C_003E4__this;

		private UnityWebRequest _003Cwww_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CUploadAllAILogInternal_003Ed__47(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	public List<AICmd> AllAILog;

	public List<AICmd> LastSaveAICmdLog;

	public static readonly float DeltaMgn;

	public ExportAILogAll ExportAILogs;

	public float GameTime;

	public string LastSelectEntityID;

	public uint TemplateID;

	public uint AreaID;

	public uint MapID;

	public string WorkShopCode;

	private bool m_Enable;

	public Dictionary<long, List<AICmd>> LastDeltaTimeAllSetProperty;

	private bool m_ThisFrameHasAddLog;

	private Dictionary<long, UnityHttpRequest> m_RunningRequest;

	private MonoBehaviour m_CorObject;

	private List<AICmd> m_ProcessTempList;

	private string m_lastUploadError;

	private static CSGIProxyReq m_reqCache;

	private static long _003CCurrentRequestID_003Ek__BackingField;

	public const long INVALID_REQUEST_ID = -1L;

	private StringBuilder m_sbContent;

	private StringBuilder m_sbAudio;

	private MutableString m_stringBuffer;

	private Dictionary<string, string> m_CustomHeadersCache;

	private byte[] m_remainingProtobufData;

	private int m_remainingProtobufLength;

	private StringBuilder m_pendingMarkdownBuffer;

	private MarkdownImageState m_markdownState;

	private int m_bracketDepth;

	private int m_parenDepth;

	public bool Enable => false;

	public static long CurrentRequestID
	{
		get
		{
			return _003CCurrentRequestID_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentRequestID_003Ek__BackingField = value;
		}
	}

	public void AddAddObjectLog(string EntityID, uint itemID)
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void Init(MonoBehaviour coroutinueRoot)
	{
	}

	private void InternalAddLog(AICmd log)
	{
	}

	private void InternalRemoveLog()
	{
	}

	public void AddUndoLog(string EntityID)
	{
	}

	public void AddSelectLog(string EntityID)
	{
	}

	public void AddDelLog(string EntityID)
	{
	}

	public void CheckAndAddSelectLog(string EntityID)
	{
	}

	public void AddSetPropertyLog(string EntityID, long propertyID, string value)
	{
	}

	public void OnGameInit()
	{
	}

	public void OnAgentDestroy()
	{
	}

	public void OnLogicSetAttrEvt(GEvent evt)
	{
	}

	public ExportQuaternion ConvertToQuaternionFromString(string value)
	{
		return null;
	}

	public ExportVector3 ConvertToVector3FromString(string value)
	{
		return null;
	}

	public ExportVector2 ConvertToVector2FromString(string value)
	{
		return null;
	}

	private void ProcessPropertySet()
	{
	}

	public void OnSave()
	{
	}

	public void OnUpdate()
	{
	}

	public void SetInitParams(uint templateID = 0u, uint mapID = 0u, uint areaID = 0u, string workshopCode = "")
	{
	}

	private string ExportAllLogCmdsString()
	{
		return null;
	}

	private byte[] ExportAllLogCmdBytesInternal()
	{
		return null;
	}

	public void ExportAndUploadAllLogCmdBytes()
	{
	}

	public void UploadAllAILog(string url, byte[] data)
	{
	}

	private IEnumerator UploadAllAILogInternal(string url, byte[] data)
	{
		return null;
	}

	public void ResetRequestID()
	{
	}

	public static void SendHoudiniReq(EUGCGICMDID cmdID, byte[] data, Action<HttpErrorCode, object> onFinished)
	{
	}

	public long SendRequestToGI(EUGCGICMDID cmdID, EUGCGIPROTOCOL protocol, byte[] req, float reqTimeout, Action<DOEOGBNPNAJ, ELLGAABJFFP, byte[]> onFinished = null)
	{
		return 0L;
	}

	public long SendRequestToGIForPersona(EUGCGICMDID cmdID, EUGCGIPROTOCOL protocol, byte[] data, float reqTimeout, string personaID, Action<LLMResponse> onFinished)
	{
		return 0L;
	}

	public long SendRequestToGIForPersona(EUGCGICMDID cmdID, EUGCGIPROTOCOL protocol, byte[] req, int reqTimeOut, string personaID, bool sendImmediately, Action<LLMStreamResponseBase> onFinished, Action<LLMStreamResponseBase> onUpdate)
	{
		return 0L;
	}

	public UnityHttpRequest SendRequestToGIForAssistant(EUGCGICMDID cmdID, byte[] data, int reqTimeOut, Action<AIAssistantResponse> onFinished, Action<AIAssistantResponse> onUpdate)
	{
		return null;
	}

	public UnityHttpRequest SendRequestToGIForASR(EUGCGICMDID cmdID, byte[] data, int reqTimeOut, Action<AIAssistantResponse> onFinished)
	{
		return null;
	}

	public long SendRequestToGIForBotAgent(long ticketID, byte[] data, int reqTimeOut, string personaID, bool sendImmediately, Action<long, LLMStreamResponseForJson> onFinished, Action<long, LLMStreamResponseForJson> onUpdate)
	{
		return 0L;
	}

	private string ProcessContentChunk(string newContent)
	{
		return null;
	}

	private bool ProcessMarkdownCharacter(char c, bool isEscaped)
	{
		return false;
	}

	private void ResetMarkdownState()
	{
	}

	private void ResetFilteringState()
	{
	}

	private bool PackGIRequest(EUGCGIPROTOCOL protocol, byte[] req, out byte[] outBytes)
	{
		outBytes = null;
		return false;
	}

	private string GetContentType(EUGCGIPROTOCOL protocol)
	{
		return null;
	}

	private string GenerateTraceIDAndUpdateHeader(EUGCGIPROTOCOL protocol)
	{
		return null;
	}

	public void GetContentDelta(string jsonString, ref AIAssistantResponse result)
	{
	}

	public void GetContentDeltaForASR(string jsonString, ref AIAssistantResponse result)
	{
	}

	public void GetContentDelta(string jsonString, ref LLMStreamResponseBase result)
	{
	}

	public void GetContentDelta(byte[] unreadDataBuffer, int startIndex, int unreadDataLength, ref LLMStreamResponseBase result)
	{
	}

	private void RemoveRunningRequest(long requestID)
	{
	}

	public void ClearRunningRequest()
	{
	}
}
