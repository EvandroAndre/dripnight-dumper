using System;
using System.Collections.Generic;

namespace COW;

public class PlayAvatarVoiceWithChannel : IAvatarVoice
{
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public AvatarVoice_Trigger_Type triggerType;

		internal bool _003CPlayAvatarVoiceShot_003Eb__0(AssistantAudioData a)
		{
			return false;
		}
	}

	private int m_VoiceTicket;

	private uint m_LastAvatarId;

	private Dictionary<uint, uint> m_RunningVoice;

	public bool PlayAvatarVoiceShot(uint avatarID, AvatarVoice_Trigger_Type triggerType, string language = "", bool random = false, Action audioEndCB = null)
	{
		return false;
	}

	private bool CanPlayShot(uint avatarID)
	{
		return false;
	}

	public void StopAvatarVoiceShot()
	{
	}
}
