using UnityEngine;

namespace COW;

public class NewBieGuideAreaNameHudProcessor : NewBieGuildCommonProcessor
{
	public NewBieGuideAreaNameHudProcessor(NewbieGuideId guideId, UICommonGuideData guideData, Transform openTransform = null)
		: base(NewbieGuideId.None, null)
	{
	}

	public override void DoGuild()
	{
	}

	public new void _003C_003EiFixBaseProxy_DoGuild()
	{
	}
}
