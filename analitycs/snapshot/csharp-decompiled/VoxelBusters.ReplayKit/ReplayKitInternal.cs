using System;
using VoxelBusters.ReplayKit.Common.DesignPatterns;
using VoxelBusters.ReplayKit.Internal;

namespace VoxelBusters.ReplayKit;

internal class ReplayKitInternal : SingletonPattern<ReplayKitInternal>, INativeCallbackListener
{
	private sealed class _003C_003Ec__DisplayClass52_0
	{
		public ReplayKitInternal _003C_003E4__this;

		public string message;

		internal void _003COnInitialiseFailed_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public ReplayKitInternal _003C_003E4__this;

		public string message;

		internal void _003COnRecordingFailed_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass56_0
	{
		public ReplayKitInternal _003C_003E4__this;

		public string message;

		internal void _003COnRecordingAvailable_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass61_0
	{
		public ReplayKitInternal _003C_003E4__this;

		public string filePath;

		internal void _003COnPreviewSaveScuessed_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass62_0
	{
		public ReplayKitInternal _003C_003E4__this;

		public string error;

		internal void _003COnPreviewSaveFailed_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass63_0
	{
		public ReplayKitInternal _003C_003E4__this;

		public string filePath;

		internal void _003COnPreviewVideo_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass64_0
	{
		public ReplayKitInternal _003C_003E4__this;

		public string filePath;

		internal void _003COnDiscardVideo_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass65_0
	{
		public ReplayKitInternal _003C_003E4__this;

		public string input;

		public string output;

		internal void _003COnThumbnail_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass66_0
	{
		public ReplayKitInternal _003C_003E4__this;

		public string filePath;

		public string size;

		public string duration;

		internal void _003COnVideoInfo_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass68_0
	{
		public ReplayKitInternal _003C_003E4__this;

		public int iValue;

		internal void _003COnVideoMuxerProgress_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass70_0
	{
		public ReplayKitInternal _003C_003E4__this;

		public int iValue;

		internal void _003COnAudioEncodeProgress_003Eb__0()
		{
		}
	}

	private INativeService m_service;

	private ReplayKitDelegates.OnRecordActionCallback m_InitialiseCallback;

	private ReplayKitDelegates.OnRecordActionCallback m_startRecordCallback;

	private ReplayKitDelegates.OnRecordActionCallback m_stopRecordCallback;

	private ReplayKitDelegates.OnRecordActionCallback m_stopRecordAvailableCallback;

	private ReplayKitDelegates.OnRecordActionCallback m_saveVideoCallback;

	private ReplayKitDelegates.OnRecordActionCallback m_discardVideoCallback;

	private ReplayKitDelegates.OnRecordActionCallback m_previewVideoCallback;

	private ReplayKitDelegates.OnVideoMuxerActionCallback m_muxerVideoCallback;

	private ReplayKitDelegates.OnThumbnailCallback m_thumbnailCallback;

	private ReplayKitDelegates.OnVideoInfoCallback m_videoInfoCallback;

	private ReplayKitDelegates.OnAudioEncodeProgressCallback m_audioEncodeProgressCallback;

	private bool m_audioListenerStatus;

	private bool m_isInitialised;

	private ReplayKitRecordingState _003CrecordingState_003Ek__BackingField;

	public ReplayKitRecordingState recordingState
	{
		get
		{
			return _003CrecordingState_003Ek__BackingField;
		}
		set
		{
			_003CrecordingState_003Ek__BackingField = value;
		}
	}

	public void RegisterMuxerAction(ReplayKitDelegates.OnVideoMuxerActionCallback callback)
	{
	}

	public void UnregisterMuxerAction(ReplayKitDelegates.OnVideoMuxerActionCallback callback)
	{
	}

	public void RegisterAudioEncodeAction(ReplayKitDelegates.OnAudioEncodeProgressCallback callback)
	{
	}

	public void UnregisterAudioEncodeAction(ReplayKitDelegates.OnAudioEncodeProgressCallback callback)
	{
	}

	public void Initialise(ReplayKitDelegates.OnRecordActionCallback callback)
	{
	}

	public bool IsInitialised()
	{
		return false;
	}

	public bool IsRecordingAPIAvailable()
	{
		return false;
	}

	public bool IsCameraEnabled()
	{
		return false;
	}

	public bool IsRecording()
	{
		return false;
	}

	public bool IsMicrophoneEnabled()
	{
		return false;
	}

	public bool IsPreviewAvailable()
	{
		return false;
	}

	public bool IsExistVideo(string filePath)
	{
		return false;
	}

	public void SetRecordingUIVisibility(bool visible)
	{
	}

	public void PrepareRecording()
	{
	}

	public void StartRecording(string video_path, ReplayKitDelegates.OnRecordActionCallback callback)
	{
	}

	public void StopRecording(string sandbox_video_path, ReplayKitDelegates.OnRecordActionCallback stopCallback, ReplayKitDelegates.OnRecordActionCallback recordAvailableCallback)
	{
	}

	public bool Preview()
	{
		return false;
	}

	public string GetPreviewFilePath()
	{
		return null;
	}

	public bool Discard(string filePath)
	{
		return false;
	}

	public void SavePreview(string filename, string outputPath, ReplayKitDelegates.OnRecordActionCallback callback)
	{
	}

	public void SharePreview(string text = null, string subject = null)
	{
	}

	public void SetVideoQuality(VideoQuality quality)
	{
	}

	public void GetVideoInfo(string filePath, ReplayKitDelegates.OnVideoInfoCallback callback)
	{
	}

	public void DiscardVideo(string filePath, ReplayKitDelegates.OnRecordActionCallback callback)
	{
	}

	public void PreviewVideo(string filePath, ReplayKitDelegates.OnRecordActionCallback callback)
	{
	}

	public void PreviewVideoFinish()
	{
	}

	public void GetThumbnail(string input, int kind, string output, ReplayKitDelegates.OnThumbnailCallback callback)
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

	protected override void Init()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	public void OnInitialiseSuccess()
	{
	}

	public void OnInitialiseFailed(string message)
	{
	}

	public void OnRecordingStarted()
	{
	}

	public void OnRecordingStopped()
	{
	}

	public void OnRecordingFailed(string message)
	{
	}

	public void OnRecordingAvailable(string message)
	{
	}

	public void OnPreviewOpened()
	{
	}

	public void OnPreviewClosed()
	{
	}

	public void OnPreviewPlayed()
	{
	}

	public void OnPreviewShared()
	{
	}

	public void OnPreviewSaveScuessed(string filePath)
	{
	}

	public void OnPreviewSaveFailed(string error)
	{
	}

	public void OnPreviewVideo(string filePath)
	{
	}

	public void OnDiscardVideo(string filePath)
	{
	}

	public void OnThumbnail(string input, string output)
	{
	}

	public void OnVideoInfo(string filePath, string size, string duration)
	{
	}

	public void OnVideoMuxerStart()
	{
	}

	public void OnVideoMuxerProgress(int iValue)
	{
	}

	public void OnVideoMuxerEnd()
	{
	}

	public void OnAudioEncodeProgress(int iValue)
	{
	}

	private void Dispatch(Action action)
	{
	}

	private void _003COnInitialiseSuccess_003Eb__51_0()
	{
	}

	private void _003COnRecordingStarted_003Eb__53_0()
	{
	}

	private void _003COnRecordingStopped_003Eb__54_0()
	{
	}

	private void _003COnVideoMuxerStart_003Eb__67_0()
	{
	}

	private void _003COnVideoMuxerEnd_003Eb__69_0()
	{
	}
}
