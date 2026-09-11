using GCommon;
using UnityEngine;

namespace COW;

public class UIBuildAvatarSkillItemController : UIBaseController
{
	private UIBuildAvatarSkillItemView m_View;

	private int m_SlotIndex;

	private UIAvatarSkillSlotController m_SkillSlotCtrl;

	private UIModelLoadout m_ModelLoadout;

	private UIModelAvatarProfile m_AvatarProfileModel;

	private AvatarProfile m_Profile;

	private uint m_Avatarid;

	private uint m_SkillId;

	private UILabel m_SkillDesc;

	private UILabel m_SkillName;

	private Transform m_SlotPosition;

	private GameObject m_SelectSprite;

	private UILabel m_ActiveLabel;

	private GameObject m_SkillEmptyLabel;

	private Color32 Blue;

	private Color32 Green;

	public UIButton SkillGuideButton => null;

	public UIWidget ContainerGuideWidget => null;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void OnClickAvatarBtn()
	{
	}

	public void SetSlotIndex(int index)
	{
	}

	public void RefreshData()
	{
	}

	private void RefreshCharacterSprite()
	{
	}

	private void RefreshSlot()
	{
	}

	public void SetData(uint skillId = uint.MaxValue, uint avatarId = uint.MaxValue)
	{
	}

	public void SetSelectHighLight(bool state)
	{
	}

	private object GetAvatarID()
	{
		return null;
	}

	private void OnPinHoverIn()
	{
	}

	private void OnPinHoverOut()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
