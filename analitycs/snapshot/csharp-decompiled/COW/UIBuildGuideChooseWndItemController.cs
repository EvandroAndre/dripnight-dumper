using GCommon;
using proto;

namespace COW;

public class UIBuildGuideChooseWndItemController : UIBaseController
{
	private UIBuildGuideChooseWndItemView m_View;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private bool m_IsNewbie;

	private int m_Index;

	private NewbiePresetDesc m_Data;

	private UIAvatarSkillSlotController m_MainSkillSlot;

	private UIAvatarSkillSlotController m_SubSkillSlot1;

	private UIAvatarSkillSlotController m_SubSkillSlot2;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(bool isNewbie, int index, NewbiePresetDesc data)
	{
	}

	private void Refresh()
	{
	}

	private void OnBtnClick()
	{
	}

	private void SetAvatarIcon(uint avatarId, UISprite characterSprite)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
