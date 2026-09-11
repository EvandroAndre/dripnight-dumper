namespace GCommon;

public interface IObjectPoolCallback
{
	void OnAllocated();

	void OnCollected();

	bool IsInPool();
}
