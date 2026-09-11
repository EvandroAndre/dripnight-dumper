using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudADSBonusCountdownController : UIBaseController
{
	private UIHudADSBonusCountdownView m_View;

	private UITimeLabelHelper m_TimeHelper;

	private float m_EndTime;

	private Color winStyleColorBg;

	private Color winStyleColorFor;

	private Color loseStyleColorBg;

	private Color loseStyleColorFor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ShowBonusCountdown(float bonusEndTime)
	{
	}

	public void SetUIStyle(bool isWinStyle)
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
