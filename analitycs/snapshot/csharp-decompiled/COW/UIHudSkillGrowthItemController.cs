using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudSkillGrowthItemController : UIBaseController
{
	private UIHudSkillGrowthItemView m_View;

	private AvatarSkillData m_Data;

	private uint m_Skill2Learn;

	private bool m_IsNewSkill;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetView(uint skillID, bool isRecommended)
	{
	}

	public void SetView(CEKLEBBHLIG skill)
	{
	}

	private void SetViewInternal(bool newSkill)
	{
	}

	private void OnSkillClick()
	{
	}

	private void OnDragScrollClick()
	{
	}

	private void OnItemSelect(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
