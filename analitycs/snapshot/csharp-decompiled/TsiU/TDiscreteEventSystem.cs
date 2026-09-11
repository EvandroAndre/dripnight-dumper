using System.Collections.Generic;

namespace TsiU;

internal class TDiscreteEventSystem
{
	private LinkedList<TDiscreteEvent> _events;

	public void Clear()
	{
	}

	public void ClearAfter(TTimeAbs gameTime)
	{
	}

	public EDiscreteEventSystemState Process(TTimeAbs gameTime, TAny workingData)
	{
		return EDiscreteEventSystemState.Empty;
	}

	public bool PushEvent(TTimeAbs occurredTime, TDiscreteEvent.DiscreteEventAction action, int priority = 0)
	{
		return false;
	}

	public bool PushEvent(TTimeAbs currentTime, TTimeRel timeAfter, TDiscreteEvent.DiscreteEventAction action, int priority = 0)
	{
		return false;
	}
}
