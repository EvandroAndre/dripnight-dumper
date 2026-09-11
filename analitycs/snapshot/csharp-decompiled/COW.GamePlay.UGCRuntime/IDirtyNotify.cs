namespace COW.GamePlay.UGCRuntime;

public interface IDirtyNotify
{
	void SetDirtyNotify(EntityIndex target, long propID, DirtyNotifyHandle handler);

	void CleanDirtyNotify();

	void NotifyDirty(object value);
}
