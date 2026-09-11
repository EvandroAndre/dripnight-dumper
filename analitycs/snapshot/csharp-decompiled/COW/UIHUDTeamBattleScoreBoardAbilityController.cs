using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDTeamBattleScoreBoardAbilityController : UIBaseController
{
	protected TeamScoreBoardAbilityView m_View;

	private HENEHAGJCLI m_AbilityItem;

	private bool m_NeedUpdate;

	private Player m_Player;

	private string m_ActiveBGStr;

	private string m_DeactiveBGStr;

	private string m_DefaultDesc;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public static bool KillCamDontDestroy()
	{
		return false;
	}

	public override bool KillCamRecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void RecordDefaultSkinInfo()
	{
	}

	private void SetSkin(bool resetToDefault = false)
	{
	}

	public void RefreshSkin()
	{
	}

	public void SetViewData(HENEHAGJCLI item, bool needUpdate = false)
	{
	}

	public void SetPlayerData(Player player)
	{
	}

	private void RefreshView()
	{
	}

	public void SetDefaultState(ResourceID resId, string desc)
	{
	}

	private void OnSkillBtnPress(GameObject go)
	{
	}

	private AvatarSkillData GetPowerUpSkillData(HENEHAGJCLI itemData)
	{
		return null;
	}

	protected void Update()
	{
	}

	public bool _003C_003EiFixBaseProxy_KillCamRecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
