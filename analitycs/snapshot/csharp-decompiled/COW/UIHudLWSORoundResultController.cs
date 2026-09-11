using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudLWSORoundResultController : UIBaseController
{
	private UIHudLWSORoundResultView m_View;

	private UIModelMatch m_ModelMatch;

	private byte m_MyTeamID;

	private bool m_LocalPlayerWin;

	private CIBDABGDGOM m_Game;

	private List<UISprite> m_MyTeamHP;

	private List<Animation> m_MyTeamHPAnim;

	private List<UISprite> m_OppoTeamHP;

	private List<Animation> m_OppoTeamHPAnim;

	private bool m_Inited;

	private bool m_LoseTeamIsEliminate;

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

	public void SetResultInfo(GHHKHNIGNGM res)
	{
	}

	private void SetTeamInfo()
	{
	}

	private void SetTeamName(byte teamID, UILabel teamNameLabel)
	{
	}

	private void SetTeamFactionIcon(UISprite sprite, LMBJKJCPKHG identity, bool isSelf)
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

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
