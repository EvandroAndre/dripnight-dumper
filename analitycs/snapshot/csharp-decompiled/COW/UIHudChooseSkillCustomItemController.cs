using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudChooseSkillCustomItemController : UIBaseController
{
	private UIHudChooseSkillCustomItemView m_View;

	private uint m_SkillID;

	private IJKMLLKGDPJ m_ChooseSkillMgr;

	private uint m_OrderMark;

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

	public void SetData(CSChooseSkillCustomData data)
	{
	}

	private void OnSelectBtnClick()
	{
	}

	public void UpdateSelectedStatus()
	{
	}

	public void OnDetailBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
