using System.Collections.Generic;
using GCommon;

namespace COW;

public class PausableManager : SingletonModule<PausableManager>
{
	public HashSet<IPausable> PausableSet;

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public void Register(IPausable pausable)
	{
	}

	public void UnRegister(IPausable pausable)
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}
}
