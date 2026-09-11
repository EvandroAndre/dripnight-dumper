using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPresetPickSkillItemController : UIBaseController
{
	private UIHudPresetPickSkillItemView m_View;

	private uint m_SkillID;

	private Color m_GreenNormalBGColor;

	private Color m_YellowNormalBGColor;

	private Color m_RedNormalBGColor;

	private Color m_WhiteNormalBGColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetEmptyView(bool isPetSkill = false, bool isTeammateSkill = false)
	{
	}

	public void SetViewData(uint SkillID, bool isPetSkill, bool skillBtnEnable = false, bool isTeammateSkill = false, bool isActiveSkill = false)
	{
	}

	private void OnSkillBtnClick()
	{
	}

	private void SetNormalBGColor(char type)
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
