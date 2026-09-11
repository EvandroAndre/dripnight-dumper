using UnityEngine;

namespace COW;

public class NewBieGuideSquadTreasureFastJoinProcessor : NewBieGuildBasProcessor
{
	private int m_Depth;

	public NewBieGuideSquadTreasureFastJoinProcessor(NewbieGuideId guideId, UICommonGuideData guideData, int depth, Transform openTransform = null)
	{
	}

	public override void DoGuild()
	{
	}

	public override bool CheckCanGuide()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_DoGuild()
	{
	}

	public bool _003C_003EiFixBaseProxy_CheckCanGuide()
	{
		return false;
	}
}
