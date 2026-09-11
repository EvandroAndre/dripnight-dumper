using System.Collections.Generic;

namespace GCommon.CommandPattern;

public class MacroCommand : Command
{
	private List<Command> m_ChildCommands;

	public int ChildCount => 0;

	public void AddCommand(Command command)
	{
	}

	public override void Clear()
	{
	}

	public override void Execute()
	{
	}

	public override void UnExecute()
	{
	}

	public void ExecuteMacro()
	{
	}
}
