using System.Text;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudFloatingLandIconController : UIBaseController
{
	private UIHudFloatingLandIconView m_View;

	private int m_endTime;

	private int m_leftTime;

	private StringBuilder m_Timer;

	private int m_reviveCount;

	private LevelFloatingLand m_floatingLand;

	private Color m_normalColor;

	private Color m_warningColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Update()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnPlayerReviveCountChanged(object[] data)
	{
	}

	private void OnMatchEnd(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
