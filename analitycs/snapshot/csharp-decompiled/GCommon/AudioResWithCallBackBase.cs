namespace GCommon;

public class AudioResWithCallBackBase : ObjectPoolCallbackBase
{
	public ResourceID AudioID;

	public float TargetVolume;

	public AudioEndInternalCallBack EndCallBack;

	private bool m_IsFromStop;

	public override void OnCollected()
	{
	}

	protected virtual void OnOnCollected()
	{
	}

	public void MarkIsFromStop()
	{
	}

	public virtual void ReturnToPool()
	{
	}
}
