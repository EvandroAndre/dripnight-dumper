using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay;

public class RunTimeAnimEventAddConfig : MonoBehaviour
{
	public bool m_IsPlayFootSoundByEvent;

	public List<ClipEvents> m_ListClipEvents;

	private Dictionary<string, bool> m_AddedClipNameMap;

	public Dictionary<uint, bool> InitConfigEvents(Dictionary<uint, bool> addedConfigs, uint configUID)
	{
		return null;
	}

	public void AddEventsToClip()
	{
	}

	private string GetFunctionNameByType(AnimEventType type, string functionName)
	{
		return null;
	}

	private uint GetResourceIDFromString(string strResID)
	{
		return 0u;
	}
}
