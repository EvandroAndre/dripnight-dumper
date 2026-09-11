using UnityEngine;

namespace GCommon.Audio;

public class MultiSound_Switch : MultiSound
{
	public string switchGroupName;

	public bool useDefaultOnLowMemory;

	public override ResourceID ChooseResource(GameObject emitter, bool isLowMemory = false)
	{
		return default(ResourceID);
	}

	public override void ResetChoice(GameObject emitter)
	{
	}
}
