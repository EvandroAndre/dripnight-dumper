using System.Collections.Generic;

namespace GCommon.Audio;

public class AudioChannel
{
	private class AudioInfo
	{
		public EAudioType InfoType;

		public AudioResWithCallBackBase OwnedResource;

		public EAudioEngineType EngineType;

		public ResourceID AudioID;

		public AudioManager.AudioEndCallBack EndCallBack;
	}

	private enum EAudioType
	{
		eOneShot,
		e2DLoop,
		e3DLoop
	}

	public bool IsSingle;

	private List<AudioInfo> m_CurPlayingAudiolist;

	public AudioChannel(bool isSingle)
	{
	}

	public void OnAudioEnd(AudioResWithCallBackBase audioResource)
	{
	}

	public void PlayOneShot(ResourceID sound, AudioManager.AudioEndCallBack callBack, float volume = 1f, EAudioEngineType targetEngine = EAudioEngineType.eUnity)
	{
	}

	public void StopChannelAudio()
	{
	}

	private void StopAudioWithInfo(AudioInfo info)
	{
	}

	public void Clean()
	{
	}
}
