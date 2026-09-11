using UnityEngine;

namespace COW;

public abstract class PausableHelperBase : MonoBehaviour, IPausable
{
	public abstract void Pause();

	public abstract void Resume();

	protected virtual void Register()
	{
	}

	protected virtual void UnRegister()
	{
	}
}
