using System.Collections.Generic;
using GCommon;

namespace COW;

public class UITutorialIndicatorHandController : UIBaseController
{
	private UITutorialIndicatorHandView m_View;

	private uint DelayCallId;

	private Dictionary<int, string> m_HandAnimDict;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void PlayAnim(TutorialUIType tutoType, float delayCloseTime = 0f, float speed = 1f)
	{
	}

	public void PlayAnim(string name, float delayCloseTime = 0f, float speed = 1f)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
