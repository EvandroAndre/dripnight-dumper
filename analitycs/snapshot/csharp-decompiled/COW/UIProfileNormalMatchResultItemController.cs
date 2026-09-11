using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIProfileNormalMatchResultItemController : UIHudMatchResultItemBaseController
{
	protected UIProfileNormalMatchResultItemView m_View;

	private ulong m_PlayerId;

	private string m_Region;

	private TeammateStats m_PlayerStats;

	private Color BarlColor;

	private Color Bar2Color;

	private Color Bar3Color;

	private Color Bar4Color;

	private Color Bar5Color;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetMatchInfo(MatchStats mMatchStats)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnClickAddFriendBtn()
	{
	}

	protected override void OnSetPlayerData(TeammateStats data, bool single)
	{
	}

	public override void OnChangePageType(EMatchResultPageType pageType)
	{
	}

	protected override void OnClickShowAvatarAttribute()
	{
	}

	private void UpdatePlayerData(TeammateStats player)
	{
	}

	private void OnBtnHeadClick()
	{
	}

	private void OnPlatformHeadpicGetted()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetPlayerData(TeammateStats P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnClickAddFriendBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnChangePageType(EMatchResultPageType P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnClickShowAvatarAttribute()
	{
	}
}
