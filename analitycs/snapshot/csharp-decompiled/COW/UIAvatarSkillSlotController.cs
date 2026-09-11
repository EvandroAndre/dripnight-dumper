using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIAvatarSkillSlotController : UIBaseController, IUIModelDataChangeObserver
{
	private uint m_AvatarID;

	private int m_SlotIndex;

	private bool m_IsSharedSkill;

	private UIAvatarSkillSlotView m_View;

	private UIModelAvatarProfile m_Model;

	private AvatarProfile m_AvatarProfile;

	private UIModelBanPick m_ModelBanPick;

	private uint m_DelayCallID;

	private AvatarSkillData m_Skilldata;

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

	protected override void OnUIInit()
	{
	}

	public List<EventDelegate> SlotBtnOnClickDelegates()
	{
		return null;
	}

	public void SetEmptySkillIcon()
	{
	}

	public void SetData(uint skillID, int slotindex, bool isLocked, uint avatarid, bool isUnReachLv = false, bool isSharedSkill = false)
	{
	}

	private void SetSharedSkillView(uint skillId, bool isSharedSkill)
	{
	}

	private void RefreshSharedSkillViewAfterRequest()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void SetBgColor(char type)
	{
	}

	public void SetNotOwnIcon()
	{
	}

	public void OnSlotClick()
	{
	}

	private void OnSkillWindowClose()
	{
	}

	public void DisableSlotBtn()
	{
	}

	public void ClearData()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void ChangeLoadoutPlan()
	{
	}

	public void SetEmptyIconVisible(bool visible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
