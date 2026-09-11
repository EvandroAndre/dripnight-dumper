using GCommon;
using GCommon.Audio;

namespace COW.Audio;

public class VFXAudioComponent : GAudioEmitterBase
{
	public enum PlaySoundType
	{
		SoundType_OneShot,
		SoundType_3DShot,
		SoundType_2DLoop,
		SoundType_3DLoop,
		SoundType_Emote,
		SoundType_EmoteLoop
	}

	public enum PlaySoundScene
	{
		SoundScene_All,
		SoundScene_FrontEnd,
		SoundScene_Ingame
	}

	public PlaySoundType PlayType;

	public PlaySoundScene PlayScene;

	public string SourceResID;

	public string ClipResID;

	public bool IsAsyncPlay;

	public bool stopOnDisable;

	private ResourceID m_SourceResID;

	private uint m_LoopPlayingID;

	private AudioPlaybackParams_Unity m_PlayParam;

	private uint m_EmoteSoundPlayingID;

	protected override void Awake()
	{
	}

	protected override void OnDisable()
	{
	}

	public override void PlaySound()
	{
	}

	private uint PlaySound3D()
	{
		return 0u;
	}

	private bool CanPlaySoundByScene()
	{
		return false;
	}

	private void StopSound()
	{
	}

	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDisable()
	{
	}
}
