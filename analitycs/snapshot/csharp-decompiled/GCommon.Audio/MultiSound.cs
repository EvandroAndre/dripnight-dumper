using System.Collections.Generic;
using UnityEngine;

namespace GCommon.Audio;

public abstract class MultiSound : ScriptableObject
{
	public string[] childSounds;

	protected List<ResourceID> m_ChildSounds;

	protected int m_LastChoiceGlobal;

	protected readonly Dictionary<int, int> m_LastChoiceByEmitter;

	public ResourceID DefaultResource => default(ResourceID);

	public virtual void OnLoaded()
	{
	}

	protected virtual bool IsValid()
	{
		return false;
	}

	public abstract ResourceID ChooseResource(GameObject emitter, bool isLowMemory = false);

	public abstract void ResetChoice(GameObject emitter);

	protected ResourceID CheckChoice(int choice, GameObject emitter, bool isLowMemory)
	{
		return default(ResourceID);
	}
}
