using UnityEngine;

namespace GCommon.Audio;

public class MultiSound_Sequence : MultiSound
{
	public bool isGlobal;

	public bool restartFromTop;

	public override ResourceID ChooseResource(GameObject emitter, bool isLowMemory = false)
	{
		return default(ResourceID);
	}

	public override void ResetChoice(GameObject emitter)
	{
	}

	private void GetNextChoice(ref int choice)
	{
	}
}
