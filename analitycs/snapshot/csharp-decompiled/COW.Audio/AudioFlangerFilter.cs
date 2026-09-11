namespace COW.Audio;

public class AudioFlangerFilter : GAudioEffectBase
{
	public float dryMix;

	public float wetMix;

	public float maxDelayTimeMs;

	public float rate;

	private float[] m_DelayBuffer;

	private int m_WritePos;

	private float m_Phase;

	private int m_Channels;

	private void InitDelayBuffer(int channels)
	{
	}

	protected override void OnAudioFilterRead(float[] data, int channels)
	{
	}
}
