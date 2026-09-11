using System;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon.Audio;

public class AudioPlayingInfoMonitor : MonoBehaviour
{
	public delegate void PlayingInfoUpdateCallbackDelegate(Dictionary<int, PlayingAudioInfo> playingAudioInfoList, float volumePCM);

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<float, float> _003C_003E9__22_0;

		internal float _003CGetCurrentVolume_003Eb__22_0(float v)
		{
			return 0f;
		}
	}

	private const int UPDATE_FRAME_INTERVAL = 1;

	private const int MAX_SHOWING_FRAME_COUNT = 30;

	private int m_CurrUpdateFrameCount;

	private Dictionary<int, PlayingAudioInfo> m_PlayingAudioInfoDict;

	public PlayingInfoUpdateCallbackDelegate playingInfoUpdateCallback;

	public const float MIN_VOLUME_DB = -120f;

	public static readonly float MIN_VOLUME_PCM;

	private int m_FrameSampleNumber;

	private int m_ChannelNum;

	private float[][] m_CurrSampleData;

	private AudioListener m_AudioListener;

	private float m_CurrVolumePCM;

	private bool CurrListenerAvailable => false;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void FixedUpdate()
	{
	}

	public static string GetAudioName(ResourceID resID)
	{
		return null;
	}

	public void UpdatePlayingInfo()
	{
	}

	private void UpdateSampleSettings()
	{
	}

	private bool GetCurrentListener()
	{
		return false;
	}

	private float GetCurrentVolume()
	{
		return 0f;
	}
}
