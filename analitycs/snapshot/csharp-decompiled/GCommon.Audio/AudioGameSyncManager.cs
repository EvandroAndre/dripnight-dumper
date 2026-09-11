using UnityEngine;

namespace GCommon.Audio;

public abstract class AudioGameSyncManager
{
	public abstract bool SetState<TGroupType>(TGroupType value);

	public abstract bool SetState(string groupName, string value);

	public abstract bool SetState(string groupName, uint value);

	public abstract TGroupType GetState<TGroupType>();

	public abstract bool SetSwitch<TGroupType>(TGroupType value, GameObject emitter);

	public abstract bool SetSwitch(string groupName, string value, GameObject emitter);

	public abstract bool SetSwitch(string groupName, uint value, GameObject emitter);

	public abstract TGroupType GetSwitch<TGroupType>(GameObject emitter);

	public abstract void SetParameter(uint parameterID, float value, GameObject emitter = null);

	public abstract float GetParameter(uint parameterID, GameObject emitter);
}
