namespace COW.Audio;

public abstract class GAudioEffectBase : GAudioComponentBase
{
	public float fadeInTime;

	protected float SampleRate;

	private double m_FadeStartTime;

	protected bool IsFadingIn;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	protected float GetFadeMultiplier()
	{
		return 0f;
	}

	protected abstract void OnAudioFilterRead(float[] data, int channels);
}
