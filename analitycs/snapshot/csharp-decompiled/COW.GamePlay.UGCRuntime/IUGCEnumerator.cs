namespace COW.GamePlay.UGCRuntime;

public interface IUGCEnumerator : IUGCObjectPoolItem
{
	IUGCEnumerator InitEnumerator(IGameBridge game, uint value);

	EUGCFuncState State();

	void SetState(EUGCFuncState value);

	IUGCValue Value();

	bool Next();

	bool IsDone();
}
