using UnityEngine;
using UnityEngine.Audio;

namespace GCommon;

public class AudioFFT : MonoBehaviour
{
	public enum _channel
	{
		Stereo,
		Left,
		Right
	}

	private AudioSource _audioSource;

	private AudioMixer _audioMixer;

	public AudioClip _audioClip;

	public static float[] _samplesLeft;

	public static float[] _samplesRight;

	public static float[] _freqBand;

	public static float[] _bandBuffer;

	private float[] _bufferDecrease;

	private float[] _freqBandHightest;

	public static float[] _freqBand64;

	public static float[] _bandBuffer64;

	private float[] _bufferDecrease64;

	private float[] _freqBandHightest64;

	public static float[] _audioBand;

	public static float[] _audioBandBuffer;

	public static float[] _audioBand64;

	public static float[] _audioBandBuffer64;

	public static float _Amplitude;

	public static float _AmplitudeBuffer;

	private float _AmplitudeHighest;

	private float _baseAudioVolume;

	public float _audioProfile;

	public _channel channel;

	private bool m_Inited;

	private static AudioFFT m_Instance;

	public static AudioFFT instance => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void SetAudioClip(AudioClip clip)
	{
	}

	public void PlayMusic(float playStartTime = 0f)
	{
	}

	public void OnMusiceVolumeChange()
	{
	}

	private void SetVolume(float volume)
	{
	}

	public AudioSource GetCurMusic()
	{
		return null;
	}

	private void Update()
	{
	}

	private void AudioProfile(float audioProfile)
	{
	}

	private void GetAmplitude()
	{
	}

	private void CreateAudioBands()
	{
	}

	private void CreateAudioBands64()
	{
	}

	private void GetSpectrumAudioSource()
	{
	}

	private void BandBuffer()
	{
	}

	private void BandBuffer64()
	{
	}

	private void MakeFrequencyBands()
	{
	}

	private void MakeFrequencyBands64()
	{
	}
}
