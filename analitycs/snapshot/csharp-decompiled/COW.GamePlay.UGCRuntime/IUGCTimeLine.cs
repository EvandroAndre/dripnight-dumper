namespace COW.GamePlay.UGCRuntime;

public interface IUGCTimeLine
{
	void LoadResourceByUUID(string resUUID);

	void Play();

	void Pause();

	void Reset();

	bool IsPlaying();

	void Update(float deltaTime);

	float GetProgress();

	float GetLastPlayProgress();

	void GotoProgress(float progress);

	UGCTimeLineActorLib GetActorLib();

	void Destroy();
}
