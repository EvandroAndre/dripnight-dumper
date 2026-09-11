namespace GCommon;

public interface ISingletonModule
{
	void Init();

	void Cleanup();

	bool NeedResetCleanup();
}
