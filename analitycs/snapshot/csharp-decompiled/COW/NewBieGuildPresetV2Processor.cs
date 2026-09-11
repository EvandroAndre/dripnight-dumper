using UnityEngine;

namespace COW;

public class NewBieGuildPresetV2Processor : NewBieGuildCommonProcessor
{
	public NewBieGuildPresetV2Processor(NewbieGuideId guideId, UICommonGuideData guideData, Transform openTransform = null)
		: base(NewbieGuideId.None, null)
	{
	}

	public override bool CheckCanGuide()
	{
		return false;
	}

	public new bool _003C_003EiFixBaseProxy_CheckCanGuide()
	{
		return false;
	}
}
