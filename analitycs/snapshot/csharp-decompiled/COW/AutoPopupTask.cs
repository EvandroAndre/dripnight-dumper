namespace COW;

public abstract class AutoPopupTask
{
	public abstract int[] NeedHttpRequests();

	public abstract bool Do();

	public abstract bool IsDone();
}
