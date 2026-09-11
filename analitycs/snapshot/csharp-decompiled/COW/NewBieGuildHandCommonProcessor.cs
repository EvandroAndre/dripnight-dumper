using UnityEngine;

namespace COW;

public class NewBieGuildHandCommonProcessor : NewBieGuildBasProcessor
{
	private TutorialUIType m_TutoType;

	private float m_DelayCloseTime;

	public NewBieGuildHandCommonProcessor(NewbieGuideId guideId, Transform openTransform, TutorialUIType tutoType, float delayCloseTime = 0f)
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
