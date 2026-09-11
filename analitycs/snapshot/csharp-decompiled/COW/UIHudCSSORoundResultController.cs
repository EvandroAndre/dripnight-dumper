using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudCSSORoundResultController : UIBaseController
{
	private UIHudCSSORoundResultView m_View;

	private UIModelMatch m_ModelMatch;

	private List<GameObject> m_BonusItemList;

	private byte m_MyTeamID;

	private byte m_CurrRoundOppoTeamID;

	private const string BONUESCOINSKEY = "${0}";

	private bool m_LocalPlayerWin;

	private bool m_IsSpecial;

	private bool m_HasMVP;

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

	private void OnEarnedCoinChanged(object[] data)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void SetBonusDetailsView(BCBBLNKLKFF res)
	{
	}

	private string GetDescriptionOfBonusType(NALFNCKIBNP bonusType)
	{
		return null;
	}

	private void SetTeamInfo()
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
