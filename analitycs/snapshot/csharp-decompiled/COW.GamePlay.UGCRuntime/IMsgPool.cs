namespace COW.GamePlay.UGCRuntime;

public interface IMsgPool
{
	object Get();

	void Put(object x);
}
