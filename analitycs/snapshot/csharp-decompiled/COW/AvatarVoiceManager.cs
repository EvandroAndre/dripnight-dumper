using System;
using GCommon;

namespace COW;

public class AvatarVoiceManager : SingletonModule<AvatarVoiceManager>
{
	private IAvatarVoice m_AvatarVoice;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public bool PlayAvatarVoiceShot(uint avatarID, AvatarVoice_Trigger_Type triggerType, string language = "", bool random = false, Action audioEndCB = null)
	{
		return false;
	}

	public void StopAvatarVoiceShot()
	{
	}

	public bool AudioABIsReady(ResourceID resourceID)
	{
		return false;
	}
}
