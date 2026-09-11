using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using COW.Gameplay.UGC;
using GCommon;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCPersonaModule : IUGCModule
{
	private class CacheAudioDataItem
	{
		public long requestID;

		public string personaID;

		public int GIError;

		public byte[] audioData;
	}

	private class PlayingAudioContext
	{
		public uint PlayDelayCallID;

		public long PlayingAudioID;

		public long ToChangeAudioID;

		public string PersonaID;

		public int GIError;

		public bool ReceiveEnd;

		public bool VoicePlayStarted;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<GGDKDNEHHFK, string> _003C_003E9__27_1;

		public static Func<GGDKDNEHHFK, string> _003C_003E9__27_2;

		internal string _003CRequestCreateRoom_003Eb__27_1(GGDKDNEHHFK personaData)
		{
			return null;
		}

		internal string _003CRequestCreateRoom_003Eb__27_2(GGDKDNEHHFK personaData)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public UGCPersonaModule _003C_003E4__this;

		public int retryCount;

		internal void _003CRequestCreateRoom_003Eb__0(DOEOGBNPNAJ giError, ELLGAABJFFP giWarning, byte[] giResp)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public UGCPersonaModule _003C_003E4__this;

		public LLMStreamResponseBase resp;

		internal void _003CSetPlayStreamVoiceDelayCall_003Eb__0()
		{
		}

		internal void _003CSetPlayStreamVoiceDelayCall_003Eb__1()
		{
		}
	}

	public string RoomID;

	public string Duration;

	private string m_Nickname;

	public NDDCMLOIKLB PersonaSetting;

	public List<UIHudUGC_LLMChatController> AllLLMChatHud;

	private StringBuilder m_sb;

	private StringBuilder m_currentPart;

	private byte[] m_byteBuffer;

	private LinkedList<CacheAudioDataItem> m_CacheAudioDataList;

	private Dictionary<long, MemoryStream> m_VoiceRecordDataMap;

	private PlayingAudioContext m_PlayingAudioContext;

	private UGCRuntime m_ugcRuntime;

	public Dictionary<string, List<string>> ObserverMap;

	private bool m_IsSendingCreateRoom;

	public bool HasCreateRoom;

	private object[] m_EventArgs1;

	private object[] m_EventArgs2;

	private ulong lastSendTime;

	private UserControlHandler userCtrl;

	public string Nickname
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string UserID => null;

	private UserControlHandler UserCtrl => null;

	void IUGCModule.Init(object[] args)
	{
	}

	public void OnTickEventHandle()
	{
	}

	public UGCPersonaModule Create(UGCRuntime ugcRuntime)
	{
		return null;
	}

	void IUGCModule.LoadParameters(Dictionary<object, object> parameters)
	{
	}

	void IUGCModule.Destroy()
	{
	}

	public List<string> GetObservers(string personaID)
	{
		return null;
	}

	private string GenerateRoomID(bool isShortTerm)
	{
		return null;
	}

	public void RequestCreateRoom(int retryCount)
	{
	}

	public long UGCAPIChatToPersona(string personaID, string content, string role, bool shouldReply)
	{
		return 0L;
	}

	public long UGCAPIChatToPersonaStream(string personaID, string content, string role, bool shouldReply)
	{
		return 0L;
	}

	public long UGCAPIUpdateContextToPersona(string personaID, string context, bool shouldReply)
	{
		return 0L;
	}

	public void UGCAPIFeedbackToPersona(string responseID, bool likeOrDislike)
	{
	}

	public void UGCAPIRollbackPersonaMemory(string responseID)
	{
	}

	public long UGCAPIChatToPersonaVoice(string personaID, string content, string role, bool autoPlay)
	{
		return 0L;
	}

	public long RequestChatStream(string content, string personaID, string role, bool shouldReply, bool voiceReply, Action<LLMStreamResponseBase> onFinished, Action<LLMStreamResponseBase> onUpdate)
	{
		return 0L;
	}

	public void ReceiveChatStream_OnUpdate(LLMStreamResponseBase resp)
	{
	}

	private void ReceiveChatStream_OnFinished(LLMStreamResponseBase resp)
	{
	}

	private void OnUpdateVoiceDataForJson(LLMStreamResponseForJson resp)
	{
	}

	private void OnUpdateVoiceDataForProtobuf(LLMStreamResponseForProtobuf resp)
	{
	}

	private void SetPlayStreamVoiceDelayCall(LLMStreamResponseBase resp)
	{
	}

	private void SplitStringsAndUpload(StringBuilder input, long requestID)
	{
	}

	private void RecordVoiceDataForJson(byte[] data, int length, long requestID)
	{
	}

	private void OnFinishVoiceDataForJson(LLMStreamResponseForJson resp)
	{
	}

	private void OnFinishVoiceDataForProtobuf(LLMStreamResponseForProtobuf resp)
	{
	}

	private long RequestChat(string personaID, string content, string role, bool shouldReply, Action<LLMResponse> onFinished)
	{
		return 0L;
	}

	private void ReceiveChat_OnFinished(LLMResponse resp)
	{
	}

	private void StopPlayingAudio()
	{
	}

	public void CheckSendLog()
	{
	}

	public void RefreshRightBtnTouchingArea()
	{
	}

	private void AddCacheAudioData(CacheAudioDataItem item)
	{
	}

	private CacheAudioDataItem GetCacheAudioData(long requestID)
	{
		return null;
	}

	public void PlayCacheAudioData(long requestID)
	{
	}
}
