using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using GCommon;
using UnityEngine;

namespace COW;

public class GameRecordEngine : SingletonModule<GameRecordEngine>
{
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public Action SuccessAction;

		internal void _003CStartRecordingWithRequestPermission_003Eb__0(Dictionary<int, bool> results)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public GameRecordEngine _003C_003E4__this;

		public Action onFinishAction;

		internal void _003CStartRecording_003Eb__0()
		{
		}
	}

	private sealed class _003CStartRecording_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameRecordEngine _003C_003E4__this;

		public Action onFinishAction;

		public Action onFailedAction;

		public int lengthSec;

		public int frequency;

		public Action onMicrophoneReadyAction;

		private _003C_003Ec__DisplayClass31_0 _003C_003E8__1;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartRecording_003Ed__31(int _003C_003E1__state)
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

	private string m_CurrentMicrophone;

	private int m_RecordedSamples;

	private AudioClip m_CurrentRecordAudioClip;

	private uint m_FinishRecordingDelayCall;

	private bool m_IsUsingMicrophone;

	private bool m_IsConverting;

	private Thread m_ConvertBase64Thread;

	public const float ConvertTimeOut = 2f;

	private int m_BufferInUse;

	private float[] m_PcmDataBuffer;

	private float[] m_StereoDataBuffer;

	private short[] m_PcmShortBuffer;

	private byte[] m_Mp3Buffer;

	private byte[] m_Mp3FlushBuffer;

	private byte[] m_WavBuffer;

	private static readonly int[] _MicPermissions;

	private bool _003CEnableASRDebugSave_003Ek__BackingField;

	public bool IsUsingMicrophone => false;

	public bool IsConverting
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool EnableASRDebugSave
	{
		get
		{
			return _003CEnableASRDebugSave_003Ek__BackingField;
		}
		set
		{
			_003CEnableASRDebugSave_003Ek__BackingField = value;
		}
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override bool NeedResetCleanup()
	{
		return false;
	}

	public bool CheckMicrophoneValid()
	{
		return false;
	}

	public void StartRecordingWithRequestPermission(Action SuccessAction)
	{
	}

	public void StartRecordingWithAudioMute()
	{
	}

	public IEnumerator StartRecording(int lengthSec, int frequency, Action onMicrophoneReadyAction, Action onFinishAction, Action onFailedAction)
	{
		return null;
	}

	public void StopRecording()
	{
	}

	public void StopRecordingNoResumeBGM()
	{
	}

	public void FinishRecording()
	{
	}

	public byte[] GetCurrentRecordAudioClipData(EAudioDataFormat format, float[] samples, out int audioSize, int frequency, int bitRate = 16, bool isStereo = false)
	{
		audioSize = default(int);
		return null;
	}

	public void ConvertRecordAudioClipBase64DataInThread(EAudioDataFormat format, ConvertAudioReturnParams result, int bitRate = 16, bool isStereo = false)
	{
	}

	private void ConvertRecordAudioClipBase64DataInThreadInternal(object obj)
	{
	}

	public void ConvertRecordAudioClipRawData(EAudioDataFormat format, ConvertAudioReturnParams result, int bitRate = 16, bool isStereo = false)
	{
	}

	public byte[] GetRecordAudioClipWAVData(float[] samples, int recordedSamples, out int wavSize, int frequency, bool isStereo = false)
	{
		wavSize = default(int);
		return null;
	}

	public byte[] GetRecordAudioClipMP3Data(float[] samples, int recordedSamples, out int mp3Size, int bitRate, int frequency, bool isStereo = false)
	{
		mp3Size = default(int);
		return null;
	}

	public void ResumeTeamVoiceAndRecoverBGM()
	{
	}

	public void SafeCancelConvertThread()
	{
	}

	public void SaveAudioToFile(byte[] audioBytes, int audioSize, bool isMp3)
	{
	}

	public void SaveSerializedDataToFile(byte[] data, int dataSize)
	{
	}

	private float[] GetPCMData(AudioClip audioClip, bool isStereo)
	{
		return null;
	}

	private float[] ConvertToStereo(float[] data, int dataLength)
	{
		return null;
	}

	private float[] ConvertToMono(float[] data, int dataLength)
	{
		return null;
	}

	private void ResetRecordingState()
	{
	}

	private bool PauseTeamVoiceAndMuteBGM()
	{
		return false;
	}

	private void MuteGameBGM()
	{
	}

	private void RecoverGameBGM()
	{
	}

	private static void EnsureBufferCapacity<T>(ref T[] buffer, int requiredSize)
	{
	}

	private static void WriteInt32ToBuffer(byte[] buffer, int offset, int value)
	{
	}

	private static void WriteInt16ToBuffer(byte[] buffer, int offset, short value)
	{
	}

	private static void WriteFourCC(byte[] buffer, int offset, string tag)
	{
	}

	private byte[] ConvertToWAV(float[] samples, int sampleSize, int channels, int frequency, out int wavDataSize)
	{
		wavDataSize = default(int);
		return null;
	}

	private byte[] ConvertToMp3(float[] samples, int recordedSamples, int channels, int frequency, int bitRate, out int mp3Size)
	{
		mp3Size = default(int);
		return null;
	}

	private int ConvertToMp3Internal(float[] pcmData, int pcmSize, out byte[] mp3Data, out int mp3Size, int sampleRate, int channels, int bitRate)
	{
		mp3Data = null;
		mp3Size = default(int);
		return 0;
	}

	public bool _003C_003EiFixBaseProxy_NeedResetCleanup()
	{
		return false;
	}
}
