using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudVerticleMatchInfoController : UIBaseController
{
	private UIHudVerticleMatchInfoView m_View;

	private int mSeconds;

	private StringBuilder m_Timer;

	private uint min;

	private uint sec;

	private List<UIHudCSPlayerStateInfoView> m_MyTeamViews;

	private List<UIHudCSPlayerStateInfoView> m_OppoTeamViews;

	private GIFGAGAGFLA m_Game;

	private int m_BaseTeamCount;

	private uint m_BaseItemSize;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnBtnLeaderboardClick()
	{
	}

	private void OnPlayerCountChanged(object[] data)
	{
	}

	private void OnKillCountChange(object[] data)
	{
	}

	public void SetMainUIData()
	{
	}

	private void Update()
	{
	}

	private void SetTeamStatesUI(List<BHGGAEEHJCO> pids, List<UIHudCSPlayerStateInfoView> views, bool ascending = true)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
