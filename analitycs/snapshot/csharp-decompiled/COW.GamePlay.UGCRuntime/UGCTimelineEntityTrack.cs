using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCTimelineEntityTrack : UGCTimeLineTrackBase
{
	protected string m_ActorSlotName;

	public override bool Init(IUGCTimeLine timeLine, HPKDGEHKENL res)
	{
		return false;
	}

	public virtual string GetActorSlotName()
	{
		return null;
	}

	public UGCLogicEntity GetActorEntity()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_Init(IUGCTimeLine P0, HPKDGEHKENL P1)
	{
		return false;
	}
}
