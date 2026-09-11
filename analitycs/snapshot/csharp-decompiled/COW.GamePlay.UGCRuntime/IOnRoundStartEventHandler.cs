namespace COW.GamePlay.UGCRuntime;

public interface IOnRoundStartEventHandler
{
	void OnRoundStartEventHandle(IUGCPhase phase, int curTimeMs);
}
