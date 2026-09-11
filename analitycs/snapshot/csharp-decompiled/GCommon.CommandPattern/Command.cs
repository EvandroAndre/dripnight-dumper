namespace GCommon.CommandPattern;

public abstract class Command : CommandPoolCallback, ICommand
{
	public abstract void Execute();

	public abstract void UnExecute();

	public virtual void Clear()
	{
	}
}
