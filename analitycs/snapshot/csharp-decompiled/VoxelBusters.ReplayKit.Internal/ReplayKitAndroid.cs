using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VoxelBusters.ReplayKit.Internal;

public class ReplayKitAndroid : MonoBehaviour, INativeService
{
	private class Native
	{
		internal class Class
		{
			internal const string NAME = "com.voxelbusters.androidlib.ReplayKitHandler";
		}

		internal class Methods
		{
			internal const string IS_RECORDING_API_AVAILABLE = "isRecordingApiAvailable";

			internal const string IS_RECORDING = "isRecording";

			internal const string IS_PREVIEW_AVAILABLE = "isPreviewAvailable";

			internal const string IS_CAMERA_ENABLED = "isCameraEnabled";

			internal const string IS_EXIST_VIDEO = "isExistVideo";

			internal const string INITIALISE = "initialise";

			internal const string SET_APP_AUDIO_PRIORITY = "setIsAppAudioPriorityOverMicrophone";

			internal const string PREPARE_RECORDING = "prepareRecording";

			internal const string START_RECORDING = "startRecording";

			internal const string STOP_RECORDING = "stopRecording";

			internal const string PREVIEW_RECORDING = "previewRecording";

			internal const string DISCARD_RECORDING = "discardRecording";

			internal const string PREVIEW_FILE_PATH = "getRecordingPath";

			internal const string SAVE_PREVIEW = "savePreviewRecordingToGallery";

			internal const string SHARE_PREVIEW = "sharePreviewRecording";

			internal const string SET_MICROPHONE_STATUS = "setMicrophoneStatus";

			internal const string SET_RECORDING_UI_VISIBILITY = "setRecordingUIVisibility";

			internal const string DISCARD_VIDEO = "discardvideo";

			internal const string GET_THUMBNAIL = "getThumbnail";

			internal const string GET_VIDEO_INFO = "getVideoInfo";

			internal const string PREVIEW_VIDEO = "previewvideo";

			internal const string SET_AUDIO = "setAudio";

			internal const string WRITE_AUDIO = "writeAudioData";

			internal const string WRITE_AUDIO_PAUSE_TIME = "writeAudioPauseTime";

			internal const string SHOW_MESSAGE = "showMessage";

			internal const string DevideHardWare = "getDeviceHardWare";
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<bool> _003C_003E9__5_0;

		internal bool _003CIsRecordingAPIAvailable_003Eb__5_0()
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public ReplayKitAndroid _003C_003E4__this;

		public bool enable;

		internal void _003CSetMicrophoneStatus_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public ReplayKitAndroid _003C_003E4__this;

		public bool show;

		internal void _003CSetRecordingUIVisibility_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public ReplayKitAndroid _003C_003E4__this;

		public string video_path;

		internal void _003CStartRecordingInternal_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public ReplayKitAndroid _003C_003E4__this;

		public string sandbox_video_path;

		internal void _003CStopRecordingInternal_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public ReplayKitAndroid _003C_003E4__this;

		public string filePath;

		internal bool _003CDiscard_003Eb__0()
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public ReplayKitAndroid _003C_003E4__this;

		public string filename;

		public string outputPath;

		internal void _003CSavePreview_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public ReplayKitAndroid _003C_003E4__this;

		public string text;

		public string subject;

		internal void _003CSharePreview_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public ReplayKitAndroid _003C_003E4__this;

		public string filePath;

		internal void _003CDiscardVideo_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public ReplayKitAndroid _003C_003E4__this;

		public string input;

		internal void _003CPreviewVideo_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public ReplayKitAndroid _003C_003E4__this;

		public string input;

		public int kind;

		public string output;

		internal void _003CGetThumbnail_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public ReplayKitAndroid _003C_003E4__this;

		public string filePath;

		internal void _003CGetVideoInfo_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public ReplayKitAndroid _003C_003E4__this;

		public string filePath;

		public int sampleRate;

		public int channels;

		internal void _003CSetAudio_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public ReplayKitAndroid _003C_003E4__this;

		public float[] data;

		public int channels;

		internal void _003CWriteAudio_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public ReplayKitAndroid _003C_003E4__this;

		public long microsecond;

		internal void _003CWriteRecordoPauseTime_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public string cpuName;

		public ReplayKitAndroid _003C_003E4__this;

		internal void _003CGetDeviceHardWare_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public string filePath;

		internal bool _003CIsExistVideo_003Eb__0()
		{
			return false;
		}
	}

	private sealed class _003CResumeAudioInternal_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ReplayKitAndroid _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CResumeAudioInternal_003Ed__34(int _003C_003E1__state)
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

	private sealed class _003CStartRecordingInternal_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ReplayKitAndroid _003C_003E4__this;

		public string video_path;

		private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartRecordingInternal_003Ed__14(int _003C_003E1__state)
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

	private sealed class _003CStopRecordingInternal_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ReplayKitAndroid _003C_003E4__this;

		public string sandbox_video_path;

		private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStopRecordingInternal_003Ed__16(int _003C_003E1__state)
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

	private INativeCallbackListener m_listener;

	private Dictionary<AudioSource, float> collection;

	private MinimalEncoder m_minimalEncoder;

	private AndroidJavaObject m_PluginClass;

	private AndroidJavaObject Plugin => null;

	public void Initialise(INativeCallbackListener listener)
	{
	}

	public bool IsRecordingAPIAvailable()
	{
		return false;
	}

	public bool IsRecording()
	{
		return false;
	}

	public bool IsPreviewAvailable()
	{
		return false;
	}

	public bool IsCameraEnabled()
	{
		return false;
	}

	public bool IsExistVideo(string filePath)
	{
		return false;
	}

	public void SetMicrophoneStatus(bool enable)
	{
	}

	public void SetRecordingUIVisibility(bool show)
	{
	}

	public void PrepareRecording()
	{
	}

	public void StartRecording(string video_path)
	{
	}

	private IEnumerator StartRecordingInternal(string video_path)
	{
		return null;
	}

	public void StopRecording(string sandbox_video_path)
	{
	}

	private IEnumerator StopRecordingInternal(string sandbox_video_path)
	{
		return null;
	}

	public bool Preview()
	{
		return false;
	}

	public bool Discard(string filePath)
	{
		return false;
	}

	public bool Discard()
	{
		return false;
	}

	public string GetPreviewFilePath()
	{
		return null;
	}

	public void SavePreview(string filename, string outputPath)
	{
	}

	public void SharePreview(string text = null, string subject = null)
	{
	}

	public void DiscardVideo(string filePath)
	{
	}

	public void PreviewVideo(string input)
	{
	}

	public void GetThumbnail(string input, int kind, string output)
	{
	}

	public void GetVideoInfo(string filePath)
	{
	}

	public void SetAudio(string filePath, int sampleRate, int channels)
	{
	}

	public void WriteAudio(float[] data, int channels)
	{
	}

	public void WriteRecordoPauseTime(long microsecond)
	{
	}

	public string GetDeviceHardWare()
	{
		return null;
	}

	public void PreviewVideoFinish()
	{
	}

	private void PauseAudio()
	{
	}

	private void ResumeAudio()
	{
	}

	private IEnumerator ResumeAudioInternal()
	{
		return null;
	}

	public void OnReplayKitInitialiseSuccess(string message)
	{
	}

	public void OnReplayKitInitialiseFailed(string message)
	{
	}

	public void OnReplayKitRecordingStarted(string message)
	{
	}

	public void OnReplayKitRecordingStopped(string message)
	{
	}

	public void OnReplayKitRecordingAvailable(string message)
	{
	}

	public void OnReplayKitRecordingFailed(string message)
	{
	}

	public void OnReplayKitPreviewOpened(string message)
	{
	}

	public void OnReplayKitPreviewClosed(string message)
	{
	}

	public void OnReplayKitPreviewShared(string message)
	{
	}

	public void OnReplayKitPreviewSaveSuccess(string message)
	{
	}

	public void OnReplayKitPreviewSaveFailed(string message)
	{
	}

	public void OnReplayKitPreviewVideo(string message)
	{
	}

	public void OnReplayKitDiscardVideoFinished(string message)
	{
	}

	public void OnReplayKitGetThumbnail(string message)
	{
	}

	public void OnReplayKitGetVideoInfo(string message)
	{
	}

	public void OnReplayKitMuxerStart(string message)
	{
	}

	public void OnReplayKitMuxerProgress(string message)
	{
	}

	public void OnReplayKitMuxerEnd(string message)
	{
	}

	public void OnReplayKitAudioEncodeProgress(string message)
	{
	}

	private void _003CInitialise_003Eb__4_0()
	{
	}

	private bool _003CIsRecording_003Eb__6_0()
	{
		return false;
	}

	private bool _003CIsPreviewAvailable_003Eb__7_0()
	{
		return false;
	}

	private bool _003CIsCameraEnabled_003Eb__8_0()
	{
		return false;
	}

	private void _003CPrepareRecording_003Eb__12_0()
	{
	}

	private bool _003CPreview_003Eb__17_0()
	{
		return false;
	}

	private bool _003CDiscard_003Eb__19_0()
	{
		return false;
	}

	private string _003CGetPreviewFilePath_003Eb__20_0()
	{
		return null;
	}

	private void _003Cget_Plugin_003Eb__57_0()
	{
	}
}
