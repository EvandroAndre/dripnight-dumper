using System.Collections.Generic;
using UnityEngine;

namespace GCommon.Audio;

public class AudioGameSyncManager_Unity : AudioGameSyncManager
{
	private readonly Dictionary<string, object> m_CurrentStates;

	private readonly Dictionary<string, Dictionary<int, object>> m_CurrentSwitches;

	private readonly Dictionary<uint, float> m_GlobalParameters;

	private readonly Dictionary<uint, Dictionary<int, float>> m_CurrentParameters;

	public override bool SetState<TGroupType>(TGroupType value)
	{
		return false;
	}

	public override bool SetState(string groupName, string value)
	{
		return false;
	}

	public override bool SetState(string groupName, uint value)
	{
		return false;
	}

	private bool SetStateInternal(string groupName, object value)
	{
		return false;
	}

	public override TGroupType GetState<TGroupType>()
	{
		return default(TGroupType);
	}

	public int GetState(string groupName)
	{
		return 0;
	}

	public override bool SetSwitch<TGroupType>(TGroupType value, GameObject emitter)
	{
		return false;
	}

	public override bool SetSwitch(string groupName, string value, GameObject emitter)
	{
		return false;
	}

	public override bool SetSwitch(string groupName, uint value, GameObject emitter)
	{
		return false;
	}

	private bool SetSwitchInternal(string groupName, object value, GameObject emitter)
	{
		return false;
	}

	public override TGroupType GetSwitch<TGroupType>(GameObject emitter)
	{
		return default(TGroupType);
	}

	public int GetSwitch(string groupName, GameObject emitter)
	{
		return 0;
	}

	private int GetIntValue(object value)
	{
		return 0;
	}

	public override void SetParameter(uint parameterID, float value, GameObject emitter = null)
	{
	}

	public override float GetParameter(uint parameterID, GameObject emitter)
	{
		return 0f;
	}
}
