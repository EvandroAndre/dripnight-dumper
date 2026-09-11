using GCommon;
using UnityEngine;

namespace COW;

public class UIBuildChooseAvatarSkillSideItemController : UIBaseController, UITable2.IUITable2Item
{
	private bool m_isActiveSkill;

	private int m_Index;

	private SkillInfo m_Data;

	private UIBuildChooseAvatarSkillSideItemView m_View;

	private UIAvatarSkillSlotController m_AvatarSkillSlotCtrl;

	private UIChangeStatusController m_ChangeStatusCtrl;

	private AvatarSkillData m_SkillData;

	private AvatarProfile m_Profile;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private UIModelLoadout m_ModelLoadout;

	private bool m_IsCSBPMode;

	public bool IsCSBPMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool CanGuide => false;

	public bool IsSelected => false;

	public bool IsEquiped => false;

	public UIWidget AvatarSkillItemGuideWidget => null;

	public UIButton AvatarSkillItemGuideButton => null;

	public UIWidget AvatarSkillItemBuyGuideWidget => null;

	public UIButton AvatarSkillItemBuyGuideButton => null;

	private void OnTagTableReposition()
	{
	}

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

	private void OnTipsClick()
	{
	}

	private void OnBuyClick()
	{
	}

	private void OnGoposClick()
	{
	}

	private void OnItemBtnSelect()
	{
	}

	private void ShowCloseFriendName()
	{
	}

	private object GetAvatarId()
	{
		return null;
	}

	private void GainAvatar(uint avatarId)
	{
	}

	private void SetViewData(object data, int data_index)
	{
	}

	private void CloseCountDownLabel()
	{
	}

	private void OnSpringClickback()
	{
	}

	private void RefreshChooseSkillWnd()
	{
	}

	private uint GetAvatarIdBySkillId(uint _skillid)
	{
		return 0u;
	}

	public void SetBaseDepth(int depth)
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public void SetSelect(bool state)
	{
	}

	public void SetEquip(bool state)
	{
	}

	public SkillInfo GetSkillInfo()
	{
		return null;
	}

	public bool IsGuideAvatar(uint avatarId)
	{
		return false;
	}

	private void OnPinHoverIn()
	{
	}

	private void OnPinHoverOut()
	{
	}

	private void OnNewCharacterGuide(uint data)
	{
	}

	private void CheckNewCharacterGuide()
	{
	}

	private void ShowNewCharacterVFX()
	{
	}

	private void SetNewCharacterIcon(bool isFemale)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
