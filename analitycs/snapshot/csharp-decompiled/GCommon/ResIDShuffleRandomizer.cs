using System.Collections.Generic;

namespace GCommon;

public class ResIDShuffleRandomizer : ShuffleRandomizerBase
{
	private IList<ResourceID> m_List;

	public ResIDShuffleRandomizer(IList<ResourceID> list)
		: base(0)
	{
	}

	public ResourceID GetNext()
	{
		return default(ResourceID);
	}
}
