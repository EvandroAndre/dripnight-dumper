using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UINinthSYSGameplayPowerCharacterRuleController : UINinthSYSGameplaySubRuleController
{
	private UINinthSYSGameplayPowerCharacterRuleView m_View;

	private NinthSysGamePlayDesc m_Desc;

	private UIModelNinthSYS.INinthSYSGamePlayContext m_Context;

	private List<NinthSysSkillDesc> m_SkillDescList;

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

	private void LogClick(string posfix)
	{
	}

	public void SetViewData(NinthSysGamePlayDesc desc, List<NinthSysSkillDesc> skillDescList, UIModelNinthSYS.INinthSYSGamePlayContext context)
	{
	}

	private void ShowCharacter(int index, NinthSysSkillDesc skillDesc)
	{
	}

	private void OnClickBRGoposBtn()
	{
	}

	private void OnClickCSGoposBtn()
	{
	}

	private void OnClickSkillIcon1_1Btn()
	{
	}

	private void OnClickSkillIcon1_2Btn()
	{
	}

	private void OnClickSkillIcon2_1Btn()
	{
	}

	private void OnClickSkillIcon2_2Btn()
	{
	}

	private void OnClickSkillIcon3_1Btn()
	{
	}

	private void OnClickSkillIcon3_2Btn()
	{
	}

	private void OnClickSkillIcon4_1Btn()
	{
	}

	private void OnClickSkillIcon4_2Btn()
	{
	}

	private void OnClickSkillIcon5_1Btn()
	{
	}

	private void OnClickSkillIcon5_2Btn()
	{
	}

	private void OnClickSkillIcon6_1Btn()
	{
	}

	private void OnClickSkillIcon6_2Btn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
