using System.Collections.Generic;

namespace GCommon.CommandPattern;

public class CommandFactory
{
	private Dictionary<string, CommandPool> m_CommandPoolMap;

	public T CreateCommand<T>() where T : Command, new()
	{
		return null;
	}

	public void ReleaseCommand<T>(T command) where T : Command
	{
	}

	public void Clear(string typeFullName)
	{
	}

	public void ClearAll()
	{
	}
}
