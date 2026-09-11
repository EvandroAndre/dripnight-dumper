using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UICSBanPickPresetSideController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass42_0
	{
		public int slotIndex;

		public UICSBanPickPresetSideController _003C_003E4__this;

		internal void _003CInitSkillContent_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public int indexId;

		public UICSBanPickPresetSideController _003C_003E4__this;

		internal void _003CRefreshSkillData_003Eb__0()
		{
		}
	}

	private UICSBanPickPresetSideView m_View;

	private Transform[] m_SlotCommonList;

	private List<UIAvatarSkillSlotController> m_SlotCommonCtrlList;

	private List<UICountDownLabel> m_SkillCountDownLabel;

	private List<UISprite> m_AvatarIconList;

	private List<GameObject> m_DefaultAvatarIconList;

	private List<GameObject> m_HighLightList;

	private List<UIButton> m_AvatarSkillBtnList;

	private List<GameObject> m_LockIconList;

	private List<GameObject> m_PreselectTextList;

	private UIModelLoadout m_ModelLoadout;

	private UIModelPet m_ModelPet;

	private UIModelCustomRoom m_ModelCustomRoom;

	private UIModelAvatarProfile m_AvatarProfileModel;

	private UIModelUser m_ModelUser;

	private UIModelBanPick m_ModelBanPick;

	private UIPresetSideLoadoutItemController m_LoadoutItemCtrl;

	private UILockController m_LockCtrl;

	private BuildCtrlComponent m_BuildCtrlComponent;

	private AvatarProfile m_MainAvatarProfile;

	private const int PetHighLightIndex = 4;

	private const int LoadoutHighLightIndex = 5;

	private uint m_CurrentShowAvatarID;

	private int m_ActiveSkillSlotIndex;

	private UICSBanPickPlayerItemController m_ChangeBubblePlayerItem;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override void OnUIClose()
	{
	}

	private void OnMaskClick()
	{
	}

	private void OnCountDownStart()
	{
	}

	public void CloseAllPresetSide()
	{
	}

	public bool IsPresetLeftSideOpen()
	{
		return false;
	}

	private void OnBtnCloseClick()
	{
	}

	public void RefreshChangeBubblePlayerItem(uint skillID, ulong RequestplayerID, ulong AnswerplayerID, ulong answerCd, uint targetSkillID)
	{
	}

	public void CloseChangeBubblePlayerItem()
	{
	}

	private void RefreshPetSkill()
	{
	}

	private void OnPetBtnClick()
	{
	}

	private void SetPetSkillState(bool state)
	{
	}

	private void OnPetMaskBtnClick()
	{
	}

	private void InitSkillContent()
	{
	}

	private void OnSkillSlotClick(int slotIndex)
	{
	}

	private void RefreshActiveSkillUI()
	{
	}

	private void UpdateActiveSkillBPState()
	{
	}

	private void RefreshPlan()
	{
	}

	private void RefreshSkillData()
	{
	}

	private void CloseCountDownLabel(int index)
	{
	}

	private void OnOpenSkillList(object[] data)
	{
	}

	private void OnEquipSkill(object[] data)
	{
	}

	private void RefreshLoadout()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnCloseHighLight()
	{
	}

	private void ApplyCSBPPresetPlan()
	{
	}

	private void OnBPPresetErrorCodeChange(uint errorCode)
	{
	}

	private void _003CRefreshLoadout_003Eb__51_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
