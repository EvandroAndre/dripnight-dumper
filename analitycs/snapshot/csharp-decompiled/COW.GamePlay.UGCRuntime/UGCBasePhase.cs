using System;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCBasePhase : IUGCPhase, IBridgingEntity
{
	protected MHJLOKOOGNB m_EntityType;

	protected string m_EntityID;

	protected UGCRuntime m_UGCRuntime;

	protected UGCLogicEntity m_LogicEntity;

	protected int m_PhaseIndex;

	protected Action m_OnTickEvent;

	public int BridgingTypeID()
	{
		return 0;
	}

	public string UGCEntityID()
	{
		return null;
	}

	public UGCLogicEntity ToUGCLogicEntity()
	{
		return null;
	}

	public virtual IUGCValue BridgingPropGetter(long bridgingProp)
	{
		return null;
	}

	public virtual bool BridgingPropSetter(long bridgingProp, UGCSimpleValue value)
	{
		return false;
	}

	public virtual void OnLogicEntityCreated(string entityID)
	{
	}

	public virtual void OnStartPhase(int curTimeMs)
	{
	}

	public virtual void OnTick(int curTimeMs, out int switchPhaseIndex, out bool isKeepRun)
	{
		switchPhaseIndex = default(int);
		isKeepRun = default(bool);
	}

	public virtual void OnEndPhase(int curTimeMs)
	{
	}

	public virtual int GetPhaseIndex()
	{
		return 0;
	}

	public virtual int GetNextPhaseIndex()
	{
		return 0;
	}
}
