using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIPresetSideController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public int indexId;

		public UIPresetSideController _003C_003E4__this;

		internal void _003CRefreshSkillData_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass92_0
	{
		public UIPresetSideController _003C_003E4__this;

		public List<uint> filledSkills;

		internal void _003COpenSecondConfirmBeforeClose_003Eb__0()
		{
		}

		internal void _003COpenSecondConfirmBeforeClose_003Eb__1()
		{
		}
	}

	private UIPresetSideView m_View;

	private Transform[] m_SlotCommonList;

	private UIWidget[] m_SlotNewPlayerGuideList;

	private List<UIAvatarSkillSlotController> m_SlotCommonCtrlList;

	private List<UICountDownLabel> m_SkillCountDownLabel;

	private List<UIPresetSidePlanItemController> m_LoadoutPlanItemList;

	private List<UISprite> m_AvatarIconList;

	private List<GameObject> m_DefaultAvatarIconList;

	private List<GameObject> m_HighLightList;

	private List<UIButton> m_AvatarSkillBtnList;

	private UIModelLoadout m_ModelLoadout;

	private UIModelGroup m_ModelGroup;

	private UIModelPet m_ModelPet;

	private UIModelMapOpeningInfo m_ModelMap;

	private UIModelUser m_ModelUser;

	private UIModelCustomRoom m_ModelCustomRoom;

	private UIModelAvatarProfile m_AvatarProfileModel;

	private UIModelInventory m_ModelInventory;

	private UIModelVeteran m_ModelVeteran;

	private UICommonGuideController m_LoadoutSideGuide;

	private UICommonGuideController m_SkillGuideCtrl;

	private UICommonGuideController m_EmptySlotGuide;

	private UILimitedCardPrivilegeWndController m_LimitedPrivilegeWndCtrl;

	private UIPresetSideLoadoutItemController m_LoadoutItemCtrl;

	private UILockController m_LockCtrl;

	private BuildCtrlComponent m_BuildCtrlComponent;

	private AvatarProfile m_MainAvatarProfile;

	private MapModeData m_SelectedMapData;

	private UITipsNormalController m_TipsCtrl;

	private const uint DefaultPlanId = 0u;

	private const int PetHighLightIndex = 4;

	private const int LoadoutHighLightIndex = 5;

	private const int m_PlanItemSize = 64;

	private const int HeightFix = 6;

	private uint m_CurrentShowAvatarID;

	private int m_CurrentPlanIndex;

	private bool m_HasOpenCopyWindows;

	private bool m_ShouldShowEmptySlotGuide;

	private uint m_DelayShowGuideId;

	private float m_DelayShowGuideTime;

	public MapModeData SelectedMapData
	{
		set
		{
		}
	}

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

	private void OnBtnCloseClick()
	{
	}

	private void RefreshPlan()
	{
	}

	private void ApplyPlan(bool needBlock = false, bool forceApply = false, bool needTips = false)
	{
	}

	private void RefreshPlanCount()
	{
	}

	private void OnPlanBtnClick(object[] data)
	{
	}

	private void RefreshPlanName(int planIndex)
	{
	}

	private void OnRecommendBtnCLick()
	{
	}

	private void OnStrategyBtnClick()
	{
	}

	private void RefreshPetSkill()
	{
	}

	private void OnBtnPetClick()
	{
	}

	private void OnPetBtnClick()
	{
	}

	private void SetPetSkillState(bool state)
	{
	}

	private void InitSkillContent()
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

	private void OnPlanApply(object[] data)
	{
	}

	private void GotoAvatarProfile()
	{
	}

	private void RefreshCharacterSprite()
	{
	}

	private void RefreshPasteBtn(bool forceRefresh = false)
	{
	}

	private void SetCopyCode()
	{
	}

	private void OnLoadoutInfoBtnClick()
	{
	}

	private void UpdateLoadoutAndPetStatus()
	{
	}

	private void SetLoadoutBannedStatus(bool isShow)
	{
	}

	private void RefreshLoadoutBannedStatus()
	{
	}

	private void RefreshPetBannedStatus()
	{
	}

	private bool IsLoadoutEnable(uint gameMode)
	{
		return false;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void SwitchCurIndex(bool closeSide = true)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshLoadout()
	{
	}

	private void OnLimitedPrivilegeBtnClick()
	{
	}

	private void OnPetMaskBtnClick()
	{
	}

	private void RefreshLimitedCardBtn()
	{
	}

	private void OnCloseHighLight()
	{
	}

	private void OnQuicMessageBtnClick()
	{
	}

	private void RefreshMsgSettingEntryRedTips(uint groupId)
	{
	}

	private void ShowNewPlayerEmptySkillGuide()
	{
	}

	private void ShowAvatarAppearanceGuide()
	{
	}

	private void TryShowLoadout3TutorialsStep2()
	{
	}

	private void OnPlanAvatarAppearanceGuideBtnClick()
	{
	}

	private void DelayShowNewbieGuide()
	{
	}

	private void OpenSecondConfirmBeforeClose()
	{
	}

	public void CheckAndShowPresetEmptySlotGuide()
	{
	}

	public void EnableEmptySlotGuide()
	{
	}

	private void _003COnUIInit_003Eb__41_0()
	{
	}

	private void _003CRefreshLoadout_003Eb__78_0()
	{
	}

	private void _003CShowAvatarAppearanceGuide_003Eb__86_0()
	{
	}

	private void _003CDelayShowNewbieGuide_003Eb__91_0()
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
