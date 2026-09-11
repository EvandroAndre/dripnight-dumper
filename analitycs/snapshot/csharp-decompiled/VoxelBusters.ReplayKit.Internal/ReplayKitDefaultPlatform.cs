using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VoxelBusters.ReplayKit.Internal;

public class ReplayKitDefaultPlatform : MonoBehaviour, INativeService
{
	private sealed class _003CSavingVideo_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ReplayKitDefaultPlatform _003C_003E4__this;

		public string filename;

		private int _003Cprogress_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSavingVideo_003Ed__23(int _003C_003E1__state)
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

	private bool m_isRecording;

	private bool m_isPreviewAvailable;

	private string m_previewVideoFile;

	public void Initialise(INativeCallbackListener listener)
	{
	}

	public bool IsCameraEnabled()
	{
		return false;
	}

	public bool IsPreviewAvailable()
	{
		return false;
	}

	public bool IsRecording()
	{
		return false;
	}

	public bool IsRecordingAPIAvailable()
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

	public void SetAudio(string filePath, int sampleRate, int channels)
	{
	}

	public void WriteAudio(float[] data, int channels)
	{
	}

	public void WriteRecordoPauseTime(long microsecond)
	{
	}

	public void StopRecording(string sandbox_video_path)
	{
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

	private IEnumerator SavingVideo(string filename)
	{
		return null;
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

	public string GetDeviceHardWare()
	{
		return null;
	}

	public void PreviewVideoFinish()
	{
	}
}
