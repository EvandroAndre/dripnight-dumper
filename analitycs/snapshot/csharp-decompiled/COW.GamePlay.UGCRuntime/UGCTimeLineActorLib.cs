using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCTimeLineActorLib
{
	private PAEHKPKMJKN m_res;

	private UGCRuntime m_ugcRuntime;

	private Dictionary<string, UGCLogicEntity> m_ActorMap;

	private Dictionary<int, UGCLogicEntity> m_TrackActorCustomMap;

	public bool Init(PAEHKPKMJKN res, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public void Destroy()
	{
	}

	private CEDBLAICIBJ GetResSlotData(string slotName)
	{
		return null;
	}

	public void ClearActorCache(UGCTimelineEntityTrack track)
	{
	}

	public void ClearActorCache(string slotName)
	{
	}

	public UGCLogicEntity GetActor(UGCTimelineEntityTrack track)
	{
		return null;
	}

	public UGCLogicEntity GetActorBySlotName(string slotName)
	{
		return null;
	}

	public void SetTrackActor(IUGCTimelineTrack track, CEDBLAICIBJ slotData)
	{
	}

	private UGCLogicEntity GetUGCLogicEntity(string entityId)
	{
		return null;
	}

	private UGCLogicEntity GetCurrentSkyBoxEntity()
	{
		return null;
	}
}
