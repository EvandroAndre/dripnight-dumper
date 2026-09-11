using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class AudioConfigDataManager : SingletonModule<AudioConfigDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<TimeLineAudio, string> _003C_003E9__10_0;

		internal string _003COnInit_003Eb__10_0(TimeLineAudio value)
		{
			return null;
		}
	}

	public const string DEFAULT_INGAME_CONFIGNAME = "default_ingame";

	private HashSet<ResourceID> m_AllKillSound;

	private Dictionary<uint, List<AssistantAudioData>> m_AssistAudioConfigMap;

	private Dictionary<uint, Dictionary<string, List<AssistantAudioData>>> m_multiLanguageAssistAudioConfigMap;

	private Dictionary<ResourceID, ResourceID> m_HDAnimSoundMap;

	private CSVAsyncDataMap<string, TimeLineAudio> m_CSVtimeLineAudiDic;

	private Dictionary<string, TimeLineAudio> m_TimelineAudioData;

	private Dictionary<string, TimeLineAudio> TimelineAudioData => null;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public bool IsKillSound(ResourceID resourceID)
	{
		return false;
	}

	public List<AssistantAudioData> GetAssistantAudioDataByAvatarID(uint avatarID)
	{
		return null;
	}

	public List<AssistantAudioData> GetAssistantAudioDataByAvatarIDAndLanguage(uint avatarID, string laguage, bool needCheck = false)
	{
		return null;
	}

	public TimeLineAudio GetTimelineAudioDataByName(string name)
	{
		return null;
	}

	public bool GetHDAnimSoundByAudioRes(ResourceID audio_res, out ResourceID hd_sound_res)
	{
		hd_sound_res = default(ResourceID);
		return false;
	}

	public void SetHDAnimSoundMapping(ResourceID normal_sound, ResourceID hd_sound)
	{
	}

	public void ClearHDAnimSoundMapping()
	{
	}
}
