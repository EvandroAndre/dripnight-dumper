namespace COW.GamePlay.UGCRuntime;

public interface IIterator : IUGCObjectPoolItem
{
	bool Next();

	bool IsDone();
}
