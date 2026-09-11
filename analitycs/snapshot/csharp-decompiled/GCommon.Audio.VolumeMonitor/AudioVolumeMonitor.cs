using System;
using UnityEngine;

namespace GCommon.Audio.VolumeMonitor;

public class AudioVolumeMonitor : MonoBehaviour
{
	public delegate void VolumeAlertDelegate(float volume, float volumeDb);

	public delegate void VolumeAlertEndDelegate();

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<float, float> _003C_003E9__23_0;

		internal float _003CFixedUpdate_003Eb__23_0(float v)
		{
			return 0f;
		}
	}

	public AudioListener audioListener;

	private int m_FrameSampleNumber;

	private int m_ChannelNum;

	private float[][] m_CurrSampleData;

	private const float MIN_VOLUME_DB = -120f;

	private readonly float MIN_VOLUME_PCM;

	private float m_VolumeAlertThreshold;

	public VolumeAlertDelegate volumeAlertCallback;

	public VolumeAlertEndDelegate volumeAlertEndCallback;

	private const float ALERT_TIME = 1f;

	private const float VOLUME_EPSILON = 0.005f;

	private float m_CurrAlertTimeCount;

	private float m_CurrAlertPCMVolume;

	private bool CurrListenerAvailable => false;

	public float VolumeAlertThreshold
	{
		set
		{
		}
	}

	public float VolumeAlertThresholdDb => 0f;

	public float VolumePCM2Db(float pcmValue)
	{
		return 0f;
	}

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	private bool GetCurrentListener()
	{
		return false;
	}

	private void UpdateSampleSettings()
	{
	}

	private void AlertUpdate(float? alertVolume = null)
	{
	}
}
