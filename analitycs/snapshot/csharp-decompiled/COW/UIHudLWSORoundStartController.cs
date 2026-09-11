using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using message;

namespace COW;

internal class UIHudLWSORoundStartController : UIBaseController
{
	private UIHudLWSORoundStartView m_View;

	private UIModelMatch m_ModelMatch;

	private CIBDABGDGOM m_Game;

	private byte m_MyTeamID;

	private List<UISprite> m_MyTeamHP;

	private List<UISprite> m_OppoTeamHP;

	private bool m_Inited;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void SetCurrRound()
	{
	}

	private void SetGameZoneInfo()
	{
	}

	private void SetTeamInfo()
	{
	}

	private void SetTeamFactionIcon(UISprite sprite, LMBJKJCPKHG identity, bool isSelf)
	{
	}

	private void SetTeamName(byte teamID, UILabel teamNameLabel)
	{
	}

	private void InitTeamHP()
	{
	}

	private void ProcessAnimEvt(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
