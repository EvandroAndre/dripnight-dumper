using UnityEngine;

namespace COW;

public class NewBieGuildCommonProcessor : NewBieGuildBasProcessor
{
	public NewBieGuildCommonProcessor(NewbieGuideId guideId, UICommonGuideData guideData, Transform openTransform = null)
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
