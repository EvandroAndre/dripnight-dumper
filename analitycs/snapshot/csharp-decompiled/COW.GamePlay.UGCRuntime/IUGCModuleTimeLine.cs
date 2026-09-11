using message;

namespace COW.GamePlay.UGCRuntime;

public interface IUGCModuleTimeLine : IUGCModule
{
	UGCLogicEntity CreateTimeLine(string timeLineDataUUID);

	void SetTrackActor(UGCLogicEntity entity, int trackId, UGCLogicEntity actorEntity, out ADFCFJBKADI errorCode);

	bool Play(string entityID);

	bool Pause(string entityID);

	bool Reset(string entityID);
}
