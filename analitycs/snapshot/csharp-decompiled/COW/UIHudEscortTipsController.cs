using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudEscortTipsController : UIBaseController
{
	private UIHudEscortTipsView m_View;

	private TweenAlpha m_FadeInAlpha;

	private TweenAlpha m_FadeOutAlpha;

	private uint m_ShowDelayCallID;

	private uint m_HideDelayCallID;

	private float m_ShowTime;

	private Color Team1Color;

	private Color Team2Color;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void ShowTips()
	{
	}

	private void HideTips()
	{
	}

	public void SetData(string content, BHGGAEEHJCO playerid)
	{
	}

	private void SetTeamColor(BHGGAEEHJCO playerid)
	{
	}

	public void ClearData()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
