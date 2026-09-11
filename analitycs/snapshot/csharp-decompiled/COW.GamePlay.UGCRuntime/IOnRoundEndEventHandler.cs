namespace COW.GamePlay.UGCRuntime;

public interface IOnRoundEndEventHandler
{
	void OnRoundEndEventHandle(IUGCPhase phase, int curTimeMs);
}
