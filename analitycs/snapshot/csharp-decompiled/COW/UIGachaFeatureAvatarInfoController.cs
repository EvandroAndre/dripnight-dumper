using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaFeatureAvatarInfoController : UIBaseController
{
	private UIGachaFeatureAvatarInfoView m_View;

	private uint m_CurrentShowAvatarId;

	private AvatarProfile m_AvatarProfile;

	private UIAvatarSkillSlotController m_SkillSlotCtrl;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private Color32 Blue;

	private Color32 Green;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshData(uint CurrentShowAvatarId)
	{
	}

	private void RefreshNameContainer()
	{
	}

	private void RefreshSkillContainer()
	{
	}

	private void SetEmptySkillAvatar()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
