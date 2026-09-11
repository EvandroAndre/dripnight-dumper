namespace GCommon.CommandPattern;

public class CommandManager
{
	internal class RingStack<T>
	{
		protected T[] m_Datas;

		protected int m_Capacity;

		protected bool m_AllowOverflow;

		protected int m_Size;

		protected int m_Head;

		protected int m_Tail;

		public int Count => 0;

		public bool AllowOverflow => false;

		public RingStack(int capacity, bool allowOverflow)
		{
		}

		public T Pop()
		{
			return default(T);
		}

		public void Push(T item)
		{
		}

		public void Clear()
		{
		}

		protected void Add(T item, bool overflow)
		{
		}
	}

	private readonly RingStack<Command> m_ExecuteStack;

	private readonly RingStack<Command> m_UnExecuteStack;

	public CommandManager(int cacheCount)
	{
	}

	public bool CanUndo()
	{
		return false;
	}

	public bool CanRedo()
	{
		return false;
	}

	public virtual void ExecuteCommand(Command command)
	{
	}

	public void PushCommand(Command command)
	{
	}

	public void Clear()
	{
	}

	public void Undo()
	{
	}

	public void Redo()
	{
	}

	private void ClearStack(RingStack<Command> stack)
	{
	}
}
