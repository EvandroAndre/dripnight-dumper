using UnityEngine;

namespace GCommon.Audio;

public class MultiSound_Random : MultiSound
{
	public int lowMemoryVariations;

	public bool avoidRepeat;

	public override ResourceID ChooseResource(GameObject emitter, bool isLowMemory = false)
	{
		return default(ResourceID);
	}

	public override void ResetChoice(GameObject emitter)
	{
	}
}
