using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDTeamBattleScoreBoardSkillController : UIBaseController
{
	protected TeamScoreBoardSkillView m_View;

	private bool m_IsActiveSkill;

	private CEKLEBBHLIG m_Skill;

	private bool m_NeedUpdate;

	private Player m_Player;

	private bool m_IsPresetPickHide;

	private AvatarSkillData m_SamoActiveSkillData;

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

	public void SetPresetPickHideView(bool isPresetPickSkill)
	{
	}

	public void SetViewData(CEKLEBBHLIG skill, bool needUpdate = false)
	{
	}

	public void SetPlayerData(Player player)
	{
	}

	public void SetStaticData(AvatarSkillData data)
	{
	}

	private void RefreshView()
	{
	}

	private void OnSkillBtnPress(GameObject go)
	{
	}

	private void OnEmptyBtnClick()
	{
	}

	protected void Update()
	{
	}

	private void OnUpdateSkillIcon(object[] param)
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
