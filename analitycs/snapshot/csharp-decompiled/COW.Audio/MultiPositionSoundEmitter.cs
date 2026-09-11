namespace COW.Audio;

public class MultiPositionSoundEmitter : GAudioEmitterBase
{
	public float maxAttenuation;

	public int mixerGroupID;

	public float updateInterval;

	private uint _003CPlayingID_003Ek__BackingField;

	public uint PlayingID
	{
		get
		{
			return _003CPlayingID_003Ek__BackingField;
		}
		private set
		{
			_003CPlayingID_003Ek__BackingField = value;
		}
	}

	public override void PlaySound()
	{
	}

	protected override void OnDisable()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDisable()
	{
	}
}
