namespace COW.GamePlay.UGCRuntime;

public interface IUGCPhase
{
	string UGCEntityID();

	void OnStartPhase(int curTimeMs);

	void OnTick(int curTimeMs, out int switchPhaseIndex, out bool isKeepRun);

	void OnEndPhase(int curTimeMs);

	int GetPhaseIndex();

	int GetNextPhaseIndex();
}
