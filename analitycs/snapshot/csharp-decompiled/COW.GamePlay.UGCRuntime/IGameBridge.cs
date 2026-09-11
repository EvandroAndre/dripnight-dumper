using message;

namespace COW.GamePlay.UGCRuntime;

public interface IGameBridge
{
	UGCRuntime Runtime { get; }

	IModeConfig ModeConfig();

	void InitUGCRuntime();

	void UnInitUGCRuntime();

	bool LoadGameData(JOEANMPIFAB runtimeData);

	bool UnloadGameData();

	uint GetTickCount();

	uint GetGameTimeMs();

	float GetDeltaTime();

	float GetFixedDeltaTime();

	uint GetUniqueReplicationEntityID();

	string GetLocalPlayer();

	string GetLocalObserver();

	IUGCPlayer GetPlayer(uint playerID, bool isIncludePendingRevivePlayer = false);

	void DebugPauseGame(bool isPaused);

	IUGCWorkflowModule NewModuleWorkflow(OHCGHBFNOFA workflowData);
}
