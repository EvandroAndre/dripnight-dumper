namespace COW.Audio;

public class AudioPeakNotchFilter : GAudioEffectBase
{
	public float gainOrCutDecibel;

	public float centerFrequency;

	public float bandwidthInOctaves;

	private float a0;

	private float a1;

	private float a2;

	private float b1;

	private float b2;

	private float z1;

	private float z2;

	protected override void OnAudioFilterRead(float[] data, int channels)
	{
	}

	private void UpdateCoefficients(float freq, float Q, float gainDb)
	{
	}
}
