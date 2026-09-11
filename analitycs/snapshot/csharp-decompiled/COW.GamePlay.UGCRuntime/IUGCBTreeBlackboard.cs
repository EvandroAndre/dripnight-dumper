namespace COW.GamePlay.UGCRuntime;

public interface IUGCBTreeBlackboard
{
	void SetTreeAttachableEntityID(string entityID);

	void SetValue(string key, object value);

	IUGCValue GetValue(string key);
}
