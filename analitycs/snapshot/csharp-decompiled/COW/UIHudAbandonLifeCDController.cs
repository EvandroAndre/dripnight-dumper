using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudAbandonLifeCDController : UIBaseController
{
	private UIHudAbandonLifeCDView m_View;

	private bool m_AbandonStarted;

	private float m_CoolDownTime;

	private float m_TotalTime;

	private Color m_BgOriColor;

	private Color m_IconOriColor;

	private Color m_ProgressOriColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnAbandonLifeClick(object[] data)
	{
	}

	private void Update()
	{
	}

	private void ReqAbandonLife()
	{
	}

	private void OnBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
