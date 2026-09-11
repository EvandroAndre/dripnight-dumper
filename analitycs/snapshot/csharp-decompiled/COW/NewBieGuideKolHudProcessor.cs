using UnityEngine;

namespace COW;

public class NewBieGuideKolHudProcessor : NewBieGuildCommonProcessor
{
	public NewBieGuideKolHudProcessor(NewbieGuideId guideId, UICommonGuideData guideData, Transform openTransform = null)
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
