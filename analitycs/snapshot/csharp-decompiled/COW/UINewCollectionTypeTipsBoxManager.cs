using System.Collections.Generic;

namespace COW;

public class UINewCollectionTypeTipsBoxManager
{
	private readonly Queue<CollectionGuideData> m_NewCollectionTypeShowJob;

	private int m_TipsBoxDepth;

	private uint m_JobLoopDelayCallID;

	private int m_UILayerNum;

	private bool m_FirstCreate;

	private const float NEW_COLLECTION_FIRST_POPUP_DELAY_TIME = 0.5f;

	public int Layer;

	public void AddJob(uint itemID)
	{
	}

	private bool TryStartJobLoop()
	{
		return false;
	}

	private bool TryEndJobLoop()
	{
		return false;
	}

	private void CreateController()
	{
	}

	private void _003CAddJob_003Eb__7_0()
	{
	}
}
