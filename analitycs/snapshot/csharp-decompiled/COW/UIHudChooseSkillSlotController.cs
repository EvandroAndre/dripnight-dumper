using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudChooseSkillSlotController : UIBaseController
{
	private UIHudChooseSkillSlotView m_View;

	private uint m_SlotIndex;

	private uint m_SkillId;

	private IJKMLLKGDPJ m_ChooseSkillMgr;

	private UIModelAvatarProfile m_ModelAvatarProfile;

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

	public void SetSlotIndex(uint index)
	{
	}

	private void InitView()
	{
	}

	public void UpdateSelectedStatus()
	{
	}

	public void SetSkillBySkillID(uint skillId)
	{
	}

	public void SetSelectBtn(bool open)
	{
	}

	private void OnSelectBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
