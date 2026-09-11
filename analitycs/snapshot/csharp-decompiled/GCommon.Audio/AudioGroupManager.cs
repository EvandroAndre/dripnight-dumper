using System.Collections.Generic;
using COW;
using UnityEngine;

namespace GCommon.Audio;

public class AudioGroupManager
{
	private readonly Dictionary<uint, AudioGroup> m_GroupIDInstanceMap;

	private readonly Dictionary<ResourceID, SoundGroupAssignmentData> m_SoundIDGroupMap;

	private readonly Dictionary<uint, SoundGroupDesignData> m_GroupIDDesignDataMap;

	private void ReadCSVData()
	{
	}

	public void RunOneFrame()
	{
	}

	public AudioGroup FindAudioGroup(ResourceID soundID)
	{
		return null;
	}

	public AudioGroup FindAndApplyAudioGroupInfo(GameObject emitter, bool is3D, ResourceID soundID, ref AudioPlaybackParams_Unity playbackParams)
	{
		return null;
	}

	private uint GetGroupID(ResourceID soundID)
	{
		return 0u;
	}

	public void ClearAudioGroupMap()
	{
	}

	public void CreateAudioGroup(uint groupID, int limitCount, int maxRange = 25)
	{
	}

	private AudioGroup GetAudioGroupInfo(uint groupID)
	{
		return null;
	}

	private SoundGroupDesignData GetSoundGroupDesignData(uint groupID)
	{
		return null;
	}
}
