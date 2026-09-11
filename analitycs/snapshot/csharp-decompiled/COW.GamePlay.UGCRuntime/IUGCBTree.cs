namespace COW.GamePlay.UGCRuntime;

public interface IUGCBTree : IBridgingEntity
{
	bool IsEnabled();

	void OnLogicEntityDestroy();

	bool Check();

	void Tick();

	void InterruptCurrent();

	void SetBlackboardValue(string key, object value);

	IUGCValue GetBlackboardValue(string key);
}
