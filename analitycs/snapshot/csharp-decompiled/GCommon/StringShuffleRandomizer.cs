using System.Collections.Generic;

namespace GCommon;

public class StringShuffleRandomizer : ShuffleRandomizerBase
{
	private IList<string> m_List;

	public StringShuffleRandomizer(IList<string> list)
		: base(0)
	{
	}

	public string GetNext()
	{
		return null;
	}
}
