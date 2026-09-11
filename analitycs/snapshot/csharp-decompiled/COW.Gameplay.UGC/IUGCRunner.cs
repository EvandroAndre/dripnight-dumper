namespace COW.Gameplay.UGC;

public interface IUGCRunner<T>
{
	bool LoadRuntimeData(T runtimeData);

	bool UnloadRuntimeData();
}
