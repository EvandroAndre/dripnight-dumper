namespace COW.GamePlay.UGCRuntime;

public interface IUGCWorkflowModule : IUGCModule
{
	void OnTickEventHandle();

	void OnPostTickEventHandle();

	void AddRoundStartEventHandler(IOnRoundStartEventHandler handler);

	void AddRoundEndEventHandler(IOnRoundEndEventHandler handler);

	void AddPhaseStartEventHandler(IOnPhaseStartEventHandler handler);

	void AddPhaseEndEventHandler(IOnPhaseEndEventHandler handler);

	IUGCPhase FindPhaseEntity(string entityID);

	int GetCurrPhaseIndex();

	void EndCurrentPhase();

	void SetNextPhase(int phaseIndex);

	void StartMatch(int curTimeMs);

	void EndMatch(int curTimeMs);
}
