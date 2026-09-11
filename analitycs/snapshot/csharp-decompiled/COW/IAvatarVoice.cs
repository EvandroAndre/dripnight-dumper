using System;

namespace COW;

internal interface IAvatarVoice
{
	bool PlayAvatarVoiceShot(uint avatarID, AvatarVoice_Trigger_Type triggerType, string language = "", bool random = false, Action audioEndCB = null);

	void StopAvatarVoiceShot();
}
