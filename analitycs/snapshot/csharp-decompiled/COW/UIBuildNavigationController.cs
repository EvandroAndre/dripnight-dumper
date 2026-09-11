using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBuildNavigationController : UIPreviewNavigationController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<Item, CommonRewardItemInfo> _003C_003E9__65_0;

		public static Predicate<AvatarSuit> _003C_003E9__84_0;

		internal CommonRewardItemInfo _003CShowClaimNewAwakenAvatarCfg_003Eb__65_0(Item temp)
		{
			return null;
		}

		internal bool _003CRefreshAvatarModel_003Eb__84_0(AvatarSuit x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass145_0
	{
		public int targetPlanIndex;

		internal bool _003CPlayNewbiePresetEquipEffect_003Eb__0(UIBuildItemController x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass66_0
	{
		public UIBuildNavigationController _003C_003E4__this;

		public List<uint> filledSkills;

		internal void _003COpenSecondConfirmBeforeClose_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass79_0
	{
		public int index;

		internal bool _003CRefreshPlanName_003Eb__0(UIBuildItemController x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass99_0
	{
		public UIBuildNavigationController _003C_003E4__this;

		public CSSharedItemData item_data;

		public List<ResourceID> res_list;

		internal void _003CRefreshDownLoadInfo_003Eb__0()
		{
		}
	}

	private sealed class _003CInitDelay_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool firstInit;

		public UIBuildNavigationController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInitDelay_003Ed__41(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private int m_CurrentPlanIndex;

	private uint m_CurrentAutoMode;

	private uint m_CurrentShowAvatarID;

	private bool m_HasOpenChooseSide;

	private bool m_HasOpenCopyWindows;

	private static readonly Vector3 PetModelPos;

	private static readonly int PopMenuWidth;

	private List<UIBuildAvatarSkillItemController> m_AvatarSkillItemList;

	private List<UIBuildItemController> m_BuildItemList;

	private UIBuildNavigationView m_View;

	private UIModelLoadout m_ModelLoadout;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private UIModelPet m_ModelPet;

	private UIModelUser m_ModelUser;

	private UIModelCollectionCustom m_ModelCollectionCustom;

	private UIPetAvatar m_PetPreview;

	private UIPopMenuSmallControler m_PickModePopMenu;

	private UIBuildPetSkillItemController m_PetSkillCtrl;

	private UIBuildLoadoutController m_LoadoutCtrl;

	private BuildCtrlComponent m_BuildCtrlComponent;

	private List<PopMenuData> m_PopMenuDataList;

	private UINewDownloadInfoController m_DownloadCtrl;

	private UILockController m_LockCtrl;

	private UILimitedCardPrivilegeWndController m_LimitedPrivilegeWndCtrl;

	private bool m_FirstInit;

	private const uint AVATAR_UPDATE_GOPOS_ID = 1010u;

	private bool m_IsInitDelayDone;

	private bool m_NeedSwitchToApplyPlan;

	private uint m_AsyncLoadPetTicket;

	private int m_NextGuideStep;

	private bool m_TopNaviState;

	private UIPresetAgentController m_PresetAgentCtrl;

	private const int COMMON_PRESET_AGENT_DEPTH = 21;

	private const int SPECIAL_PRESET_AGENT_DEPTH_OFFSET = 3;

	private HashSet<Type> m_SpecialDepthControllers;

	private UITipsNormalController m_NewbiePresetGiftTipsCtrl;

	private UIWidget m_GuideWidget;

	private UIButton m_GuideButton;

	private UICommonGuideController m_GuideCtrl;

	private uint m_DelayShowGuideId;

	private float m_DelayShowGuideTime;

	private bool m_ShowGuide;

	private bool m_ForbidEsc;

	private const string AVATAR_ENTRANCE_CLICK = "AVATAR_ENTRANCE_CLICK";

	private const string PET_ENTRANCE_CLICK = "PET_ENTRANCE_CLICK";

	private bool m_ShowAvatarTips;

	private bool m_ShowPetTips;

	private bool m_BuildGuideDelayProtect;

	private const int NewbieSkillCount = 4;

	private uint m_CheckPresetAgentAutoPromptDelayCall;

	public bool ForbidEsc
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

	protected override void OnUIOpen()
	{
	}

	private void OnPatchChangeBtnClick()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected override void OnPopupWindowListChange()
	{
	}

	private IEnumerator InitDelay(bool firstInit)
	{
		return null;
	}

	protected override void OnUIDestroy()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	private void OnCloseAction()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void OnBtnPetClick()
	{
	}

	private void OnBtnAvatarClick()
	{
	}

	private void OnPowerSkillNavigationClick()
	{
	}

	private void RefreshPowerSkillNavigation()
	{
	}

	private bool IsSkillMightyPowerTagOpen()
	{
		return false;
	}

	private void OnClickLeftItem(object[] data)
	{
	}

	private void OnAvatarEquipSkill(object[] data)
	{
	}

	private void OnOpenChoosePetSkillSide()
	{
	}

	private void OnOpenChooseLoadoutSide()
	{
	}

	private void OnCloseChooseSideByEvent()
	{
	}

	private void OnOpenChooseSide()
	{
	}

	public void SetCopyCode()
	{
	}

	private void OnCloseHighLight()
	{
	}

	private void OnBgCloseBtnClick()
	{
	}

	private void OnLimitedPrivilegeBtnClick()
	{
	}

	public void ShowClaimNewAwakenAvatarCfg(List<Item> avatarList)
	{
	}

	private bool OpenSecondConfirmBeforeClose()
	{
		return false;
	}

	private void CloseNavigation()
	{
	}

	private void ApplyPlan(bool needBlock = false, bool forceApply = false, bool needTips = false)
	{
	}

	private void OnRecommendBtnCLick()
	{
	}

	private void OnNewbieRecommendBtnClick()
	{
	}

	private void RefreshNewbieRecommendBtnVisibility()
	{
	}

	private void RefreshLeftItem(bool refreshAllModel = true)
	{
	}

	private void InitPopMenuDataList()
	{
	}

	private void RefreshPopMenuSelect()
	{
	}

	private void InitPopMenu()
	{
	}

	private void GenerateGameModeMenuData()
	{
	}

	private void RefreshTypePopMenu()
	{
	}

	private void OnTypeSelected(uint popMenuType)
	{
	}

	private void RefreshPlanName(int index)
	{
	}

	private void SwitchCurIndex(bool refreshAllModel)
	{
	}

	private void OnOpenChooseAvatarSkillSide(object[] data)
	{
	}

	private void RefreshTopLeftContent()
	{
	}

	private void RefreshAllModel(bool force = false)
	{
	}

	private void RefreshAvatarModel(bool force = false)
	{
	}

	private void RefreshAvatarTips()
	{
	}

	private void RefreshPetTips()
	{
	}

	private void RefreshNewbiePresetGiftTips()
	{
	}

	private void ShowNewbiePresetRecommendWindowAuto()
	{
	}

	private bool TryShowNewbiePresetRecommendWindow()
	{
		return false;
	}

	private void RefreshPetModel(bool force = false)
	{
	}

	private void CancelLoadPetRes()
	{
	}

	private void OnPetAvatarCreated(uint ticket, UIPetAvatar petAvatar)
	{
	}

	private void RefreshAvatarModelState()
	{
	}

	private void RefreshRightContent()
	{
	}

	private void RefreshPetSkillData()
	{
	}

	private void RefreshLoadoutData()
	{
	}

	private void RefreshAvatarSkillData()
	{
	}

	private void SetTopNavi(bool state)
	{
	}

	private void RefreshDownLoadInfo()
	{
	}

	private void RefreshShowLeftItemData()
	{
	}

	private void RefreshAllLeftItemData()
	{
	}

	private void RefreshPasteBtn(bool forceRefresh = false)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void StartNewbieGuideV2()
	{
	}

	public void StartNewSkillGuideV2()
	{
	}

	private void CloseGuideV2Btn()
	{
	}

	public void StartAvatarEntrenceGuide()
	{
	}

	private void StartPetLoadoutGuide()
	{
	}

	private void DelayShowNewbieGuideV2()
	{
	}

	private void DelayShowNewSkillGuide()
	{
	}

	private void ShowGuide()
	{
	}

	private bool CheckHasNewSkill()
	{
		return false;
	}

	private void InitGuide()
	{
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	private void ChangeForbidEscState(bool isForbid)
	{
	}

	private void OnGuideBtnMainSkillClick()
	{
	}

	private void OnGuideBtnGuideAllSkillClick()
	{
	}

	private void OnBuildGuideChooseWndClose()
	{
	}

	private void MoveToNextStep()
	{
	}

	private void OnGuideBtnCloseClick()
	{
	}

	private void DelayShowPresetSystemGuide()
	{
	}

	private void DelayShowPresetAgentGuide()
	{
	}

	private void StartPresetSystemGuide()
	{
	}

	private void OnGuideBtnSkillAreaClick()
	{
	}

	private void OnGuideBtnAppearanceClick()
	{
	}

	private void ShowLoadoutTutorialStep1()
	{
	}

	private void CheckAndTriggerNewbiePresetEntranceEffect()
	{
	}

	public void PlayNewbiePresetEquipEffect(int targetPlanIndex)
	{
	}

	public void PlayTrailEffectToEntrance()
	{
	}

	private void OnTrailEffectFinished()
	{
	}

	private void RefreshPresetAgent()
	{
	}

	private void CheckPresetAgentAutoPrompt()
	{
	}

	private void _003CInitPopMenuDataList_003Eb__73_0(object obj)
	{
	}

	private bool _003CRefreshTypePopMenu_003Eb__77_0(PopMenuData x)
	{
		return false;
	}

	private bool _003CRefreshShowLeftItemData_003Eb__100_0(UIBuildItemController x)
	{
		return false;
	}

	private void _003CStartNewbieGuideV2_003Eb__117_0()
	{
	}

	private void _003CStartPetLoadoutGuide_003Eb__121_0()
	{
	}

	private void _003CDelayShowNewbieGuideV2_003Eb__122_0()
	{
	}

	private void _003CDelayShowNewSkillGuide_003Eb__123_0()
	{
	}

	private void _003CDelayShowPresetSystemGuide_003Eb__138_0()
	{
	}

	private void _003CDelayShowPresetAgentGuide_003Eb__139_0()
	{
	}

	private void _003CCheckPresetAgentAutoPrompt_003Eb__150_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}
}
