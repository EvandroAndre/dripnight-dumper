using System;
using System.Collections;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;

namespace COW;

public class VoiceToTextComponent
{
	public enum EVoiceToTextState
	{
		Idle,
		WaitingPermission,
		WaitingChannelPause,
		Recording,
		Converting,
		SendingToServer,
		Finished,
		Error
	}

	public enum EVoiceToTextError
	{
		None,
		MicOccupied,
		MicUnavailable,
		AudioConverting,
		ChannelPauseFailed,
		RecordingTooShort,
		ConvertFailed,
		ServerError
	}

	private sealed class _003CWaitForBase64DataAndSend_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ConvertAudioReturnParams convertResult;

		public VoiceToTextComponent _003C_003E4__this;

		private float _003CelapsedTime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitForBase64DataAndSend_003Ed__65(int _003C_003E1__state)
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

		void IEnumerator.Reset()
		{
		}
	}

	private static readonly Dictionary<EVoiceToTextError, string> s_ErrorKeyMap;

	private int m_MaxRecordingLengthSec;

	private int m_SampleRate;

	private float m_MinValidRecordingLength;

	private const float RECORDING_PROGRESS_DELAY_TIME = 0.03f;

	private EVoiceToTextState m_State;

	private IVoiceToText m_VoiceToTextCallback;

	private VoiceToTextGIConfig m_GIConfig;

	private uint m_WaitChannelPauseDelayCall;

	private uint m_RecordingProgressDelayCall;

	private Coroutine m_RecordingCoroutine;

	private Coroutine m_ConvertCoroutine;

	private float m_CurrentRecordingLength;

	private float m_RecordingStartRealtime;

	private UnityHttpRequest m_HttpRequest;

	private string m_RecognizedText;

	private bool m_IsInited;

	private bool m_IsEnabled;

	private byte[] m_BinaryBuffer;

	private byte[] m_LangBytesCache;

	private int m_LastSerializedSize;

	public EVoiceToTextState State => EVoiceToTextState.Idle;

	public float CurrentRecordingLength => 0f;

	public float MaxRecordingLength => 0f;

	public bool IsRecording => false;

	public bool IsConverting => false;

	public bool IsSending => false;

	public bool IsIdle => false;

	public bool IsBusy => false;

	public bool IsInited => false;

	public VoiceToTextGIConfig GIConfig => null;

	public static string GetErrorKey(EVoiceToTextError error)
	{
		return null;
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public void OnDestroy()
	{
	}

	public void InitVoiceToText(IVoiceToText voiceToTextCallback)
	{
	}

	public void ConfigureRecording(int maxRecordingLengthSec, int sampleRate, float minValidLength)
	{
	}

	public void ConfigureGI(VoiceToTextGIConfig giConfig)
	{
	}

	public bool StartRecording()
	{
		return false;
	}

	public void StopRecordingAndSend()
	{
	}

	public void CancelRecording()
	{
	}

	public void OnGameVoiceChannelPaused(bool isSuccess)
	{
	}

	public void OnApplicationPause(bool isPause)
	{
	}

	private void OnPermissionGranted()
	{
	}

	private void CancelWaitChannelPauseDelayCall()
	{
	}

	private void StartRecordingInternal()
	{
	}

	private void OnRecordingReady()
	{
	}

	private void OnRecordingTimeOut()
	{
	}

	private void OnRecordingFailed()
	{
	}

	private void CancelRecordingProgressDelayCall()
	{
	}

	private void ConvertAndSend()
	{
	}

	private void ConvertRawDataAndSend()
	{
	}

	private void ConvertBase64DataAndSend()
	{
	}

	private IEnumerator WaitForBase64DataAndSend(ConvertAudioReturnParams convertResult)
	{
		return null;
	}

	private void SendToGIServer(string base64AudioData)
	{
	}

	private void SendToGIServerBinary(byte[] rawAudioData, int audioSize)
	{
	}

	private byte[] SerializeASRBinaryRequest(byte[] rawAudioData, int audioSize)
	{
		return null;
	}

	private void OnGIResponseFinish(AIAssistantResponse info)
	{
	}

	private void CleanupDelayCallsAndCoroutines()
	{
	}

	private void CleanupAll()
	{
	}

	private void _003COnPermissionGranted_003Eb__55_0()
	{
	}

	private void _003COnRecordingReady_003Eb__58_0()
	{
	}
}
