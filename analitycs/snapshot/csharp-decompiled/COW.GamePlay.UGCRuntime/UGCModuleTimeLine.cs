using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCModuleTimeLine : IUGCModuleTimeLine, IUGCModule
{
	private UGCRuntime m_ugcRuntime;

	private Dictionary<string, UGCTimeLine> m_UGCTimeLineMap;

	private List<UGCTimeLine> m_UpdateList;

	private uint lastTickGameTime;

	private bool m_HideUI;

	public void Init(object[] args)
	{
	}

	public void LoadParameters(Dictionary<object, object> parameters)
	{
	}

	public void Destroy()
	{
	}

	public UGCModuleTimeLine Create(UGCRuntime ugcRuntime)
	{
		return null;
	}

	private void OnTickEventHandle()
	{
	}

	private void OnAddTimeLineEntity(string entityID)
	{
	}

	private void OnRemoveTimeLineEntity(string entityID)
	{
	}

	public UGCLogicEntity CreateTimeLine(string timeLineDataUUID)
	{
		return null;
	}

	public void SetTrackActor(UGCLogicEntity entity, int trackId, UGCLogicEntity actorEntity, out ADFCFJBKADI errorCode)
	{
		errorCode = default(ADFCFJBKADI);
	}

	public bool Play(string entityID)
	{
		return false;
	}

	public bool Pause(string entityID)
	{
		return false;
	}

	public bool Reset(string entityID)
	{
		return false;
	}
}
