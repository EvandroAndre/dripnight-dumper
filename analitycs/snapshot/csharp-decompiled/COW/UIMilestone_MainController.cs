using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIMilestone_MainController : UINavigationController, IUIModelDataChangeObserver, IBigEventTemplateIdentifier, UIModelBigEvent_Milestone.IProgressAnimation
{
	private enum EViewStatus
	{
		Null,
		FirstInAnim,
		Enter,
		Normal
	}

	private enum EStageStatus
	{
		Null,
		Info,
		Animation,
		Finish
	}

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	private UIMilestone_MainView m_View;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private UIModelBigEvent_Milestone m_UIModelMilestone;

	private UIMilestone_TokeBtnController m_TokenCtrl;

	private List<UIBaseController> m_LeftBtnControllers;

	private List<MilestoneProgressView> m_ProgressViews;

	private UIMilestone_BaseCorePlayController m_CorePlayController;

	private bool m_hasInitTemplateUI;

	private bool _003CisPlaying_003Ek__BackingField;

	private EViewStatus m_ViewStatus;

	private UIRamadan24BFirstInAnimController m_FirstInAnimCtrl;

	private uint m_FirstInAnimDelayCall;

	private uint m_PlayEnterAnimDelayCall;

	private uint m_FirstInAnimDelayCall2;

	private bool m_LoadingMaskStatus;

	private EStageStatus m_StageStatus;

	private GameObject m_TitleEnterVFXGo;

	private GameObject m_AccBtnEnterVFXGo;

	private GameObject m_AccBtnClaimableVFXGo;

	private GameObject m_RightProgressMaskEnterVFXGo;

	private GameObject m_AddMileageVFXGo;

	protected const float PROMPT_EFFECT_START_TIME = 5f;

	private int m_OldIndex;

	private int m_NewIndex;

	private int m_CurIndex;

	private uint m_AddMileage;

	private uint m_MileageAnimKey;

	private uint m_MileageAnimKey1;

	private ResourceID m_FlyEffectVFXResID;

	private GameObject m_FlyEffectVFXGO;

	public EBigEventTemplateUseType TemplateUseType
	{
		get
		{
			return _003CTemplateUseType_003Ek__BackingField;
		}
		set
		{
			_003CTemplateUseType_003Ek__BackingField = value;
		}
	}

	public bool isPlaying
	{
		get
		{
			return _003CisPlaying_003Ek__BackingField;
		}
		private set
		{
			_003CisPlaying_003Ek__BackingField = value;
		}
	}

	private bool isVaild => false;

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

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

	public override bool IsVisible()
	{
		return false;
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	private void ClearAnimDelayKey()
	{
	}

	protected override void OnPopupWindowListChange()
	{
	}

	private void ExecuteGotoNavigation()
	{
	}

	private void InitTokenOwnedShowState()
	{
	}

	private void InitCloseBtnShowState()
	{
	}

	private void InitLeftTopTitleCDNAndOpenTime()
	{
	}

	private void InitCdn()
	{
	}

	private void InitCorePlaySetting()
	{
	}

	private void InitCorePlayInfo()
	{
	}

	private void RefershMileagePrompt()
	{
	}

	private void RefreshGridLeftBtns()
	{
	}

	private void RefershMileageToken()
	{
	}

	private void ShowPeakDayPopWnd()
	{
	}

	private void OnRuleBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnTutorialBtnClick()
	{
	}

	private void OnClickMileageAccBtn()
	{
	}

	private void OnClickSkipAnimBtn()
	{
	}

	protected void OnLoadingMaskWndCloseCallback(object[] data)
	{
	}

	private MilestoneProgressView GetProgressView(int index)
	{
		return null;
	}

	private int GetProgressViewIndex(uint stage_id)
	{
		return 0;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void OnGotoNavigation(uint entranceType)
	{
	}

	private bool IsNeedPlayFirstInAnim()
	{
		return false;
	}

	private bool PlayAnim(Animation anim, string strAnim, out float length)
	{
		length = default(float);
		return false;
	}

	public void PlayAnimation(uint old_stage_id, uint cur_stage_id, uint add_mileage)
	{
	}

	private void OnCorePlayAnimCallback()
	{
	}

	private void PlayPromptEffect()
	{
	}

	private float PlayMileageAddEffect(out float event_time)
	{
		event_time = default(float);
		return 0f;
	}

	private void OnAddMileagePromptAnimCallback()
	{
	}

	private bool CreateFlyEffect(Vector3 position)
	{
		return false;
	}

	private void OnFlyEffectTweenFinished()
	{
	}

	private void OnFlyEffectCompleteCallback()
	{
	}

	private void OnStageProgressAnimCallback(uint stage_id)
	{
	}

	private void OnRepeatedPlayStageProgressAnim()
	{
	}

	private void OnPlayStageProgressFinish()
	{
	}

	private void TryPlayFirstInAnim()
	{
	}

	private void PlayEnterAnim()
	{
	}

	private void PlayStageUnlockEffect()
	{
	}

	private void OnProgressStageEnterAnimationCallback(uint id)
	{
	}

	private void _003COnDataChanged_003Eb__63_0()
	{
	}

	private void _003COnCorePlayAnimCallback_003Eb__76_0()
	{
	}

	private void _003COnCorePlayAnimCallback_003Eb__76_1()
	{
	}

	private void _003COnFlyEffectTweenFinished_003Eb__81_0()
	{
	}

	private void _003CTryPlayFirstInAnim_003Eb__86_0()
	{
	}

	private void _003CTryPlayFirstInAnim_003Eb__86_1()
	{
	}

	private void _003CTryPlayFirstInAnim_003Eb__86_2()
	{
	}

	private void _003CPlayEnterAnim_003Eb__87_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsVisible()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
