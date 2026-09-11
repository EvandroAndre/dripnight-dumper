using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudCSChooseSkillConfirmController : UIBaseController
{
	private UIHudCSChooseSkillConfirmView m_View;

	private IJKMLLKGDPJ m_ChooseSkillMgr;

	private BHGGAEEHJCO m_PlayerId;

	private int m_MaxPlayerNum;

	private List<UIHudShowPlayerDualSkillController> m_TeammateSkills;

	private List<UIHudShowPlayerDualSkillController> m_EnemySkills;

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

	private void InitStatus()
	{
	}

	public void OnConfirmUpdate()
	{
	}

	private bool NeedShowPlayerDualSkill()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
