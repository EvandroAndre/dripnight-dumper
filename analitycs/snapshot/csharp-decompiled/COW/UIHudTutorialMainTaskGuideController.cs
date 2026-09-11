using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudTutorialMainTaskGuideController : UIBaseController
{
	public enum TutorialMainGuideType
	{
		Normal,
		HippoCrisisSearchBox,
		HippoCrisisKillEnemy,
		HippoCrisisRetreat
	}

	private UIHudTutorialMainTaskGuideView m_View;

	private Animator m_Animator;

	private uint m_delayCallID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetContent(string content, TutorialMainGuideType guideType = TutorialMainGuideType.Normal)
	{
	}

	public void DelayHide(float f = 3f)
	{
	}

	public void PlayAnim()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
