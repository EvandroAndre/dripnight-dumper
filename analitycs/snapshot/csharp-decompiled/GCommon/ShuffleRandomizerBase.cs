using System.Collections.Generic;

namespace GCommon;

public abstract class ShuffleRandomizerBase
{
	protected List<int> m_ShuffledIndices;

	protected int m_CurrentIndex;

	protected int m_ArrayLength;

	protected ShuffleRandomizerBase(int arrayLength)
	{
	}

	private void Shuffle()
	{
	}

	protected int GetNextIndex()
	{
		return 0;
	}
}
