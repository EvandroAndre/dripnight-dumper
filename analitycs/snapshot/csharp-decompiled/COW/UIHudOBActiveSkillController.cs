using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudOBActiveSkillController : UIBaseController
{
	private UIHudOBActiveSkillView m_View;

	private bool m_IsActiveSkill;

	private CEKLEBBHLIG m_Skill;

	private Player m_Player;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(CEKLEBBHLIG skill)
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

	protected void Update()
	{
	}

	private void OnUpdateSkillIcon(object[] param)
	{
	}

	private void UpdateIcon(object[] param)
	{
	}

	private void OnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
