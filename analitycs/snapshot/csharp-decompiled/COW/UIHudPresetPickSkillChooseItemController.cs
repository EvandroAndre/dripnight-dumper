using GCommon;
using message;

namespace COW;

public class UIHudPresetPickSkillChooseItemController : UIBaseController
{
	private UIHudPresetPickSkillChooseItemView m_View;

	private EADOMEKFHBE m_PresetInfo;

	private UIHudPresetPickSkillInfoController m_SkillInfoCtrl;

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

	public void SetViewData(EADOMEKFHBE presetInfo)
	{
	}

	private void OnSkillChooseBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
