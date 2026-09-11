using System.Collections.Generic;
using System.Text;
using GCommon;

namespace COW;

public class UIHudMVPSkillItemController : UIBaseController
{
	private UIHudMVPSkillItemView m_View;

	private StringBuilder m_SkillText;

	private int m_ParentDepth;

	private UIDetailTipsController m_SkillTipsController;

	private List<ResourceID> m_AwakeningIcon;

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

	public void SetData(AvatarSkillData skillData, int parentDepth)
	{
	}

	private void OnClickSkillBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
