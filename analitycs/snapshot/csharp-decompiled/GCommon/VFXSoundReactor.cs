using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class VFXSoundReactor : MonoBehaviour
{
	public enum LevelShape
	{
		Rectangle,
		Circle
	}

	public enum SegmentsType
	{
		Seg8,
		Seg16,
		Seg32
	}

	public enum ChannelType
	{
		Stereo,
		Left,
		Right
	}

	public float Strength;

	private AudioSource m_audio;

	public ChannelType Channel;

	public GameObject Level;

	public LevelShape Shape;

	public SegmentsType Segment;

	public float Spacing;

	public List<VFXSoundReactorLevel> CurLevels;

	private const int MAX_SAMPLES = 512;

	private float[] m_leftSamples;

	private float[] m_rightSamples;

	private const float STEREO_MULTIPLIER = 0.5f;

	private readonly float[] SEGMENT_MULTIPLIERS;

	private float[] _003CFreqBands_003Ek__BackingField;

	private int m_cachedLevelsCount;

	private float m_cachedSegmentMultiplier;

	private float[] m_cachedPowValues;

	public AudioSource Audio
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float[] FreqBands
	{
		get
		{
			return _003CFreqBands_003Ek__BackingField;
		}
		set
		{
			_003CFreqBands_003Ek__BackingField = value;
		}
	}

	private int GetLevelsCount()
	{
		return 0;
	}

	private float GetSegmentMultiplier()
	{
		return 0f;
	}

	private void Start()
	{
	}

	private void CacheValues()
	{
	}

	private void PrecomputePowValues()
	{
	}

	private void Update()
	{
	}

	private void GetSpectrumAudioSource()
	{
	}

	private void MakeFrequencyBands()
	{
	}
}
