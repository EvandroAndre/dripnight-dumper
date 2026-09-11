using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class NewBieGuildManager : SingletonModule<NewBieGuildManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<NewBieGuildBasProcessor> _003C_003E9__11_0;

		internal int _003CSortNewbieLobbyGuideList_003Eb__11_0(NewBieGuildBasProcessor a, NewBieGuildBasProcessor b)
		{
			return 0;
		}
	}

	private bool m_IsNeedGuide;

	private NewBieGuildBasProcessor m_CurretGuide;

	private List<NewBieGuildBasProcessor> m_NewBieLobbyGuideList;

	private Queue<NewBieGuildBasProcessor> m_NotCloseGuideQueue;

	private UIRightReigonClickMask m_ClickMask;

	private UIWidget m_BtnStartWidget;

	private Dictionary<int, NewPlayerGuideData> m_NewBieGuideDataDict;

	private int m_BuildGuideLoadoutId;

	public int GuideLoadoutIdByGuideId => 0;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public void ClearAtlasRefrence()
	{
	}

	public void SetProcessor(List<NewBieGuildBasProcessor> processors)
	{
	}

	private void SortNewbieLobbyGuideList()
	{
	}

	public void SetBtnStartWidget(UIWidget newWidget)
	{
	}

	public void ClearRefenceWidgets()
	{
	}

	public void OpenGuide()
	{
	}

	public bool ShowSystemGuide(NewBieGuildBasProcessor guideBarProcessor)
	{
		return false;
	}

	public bool ShowSystemGuide(NewbieGuideId guideId, UIWidget bindWidget, CommonGuideSetting guideSetting, UIAnchor.Side anchorSide, UIButton bindBtn = null, Transform openTransform = null, Action onCloseAction = null, int newDepth = -1, List<EventDelegate> guideMaskAction = null, bool needClickClose = false)
	{
		return false;
	}

	public bool ShowSystemHandGuide(NewbieGuideId guideId, Transform openTransform, TutorialUIType tutoType, float delayCloseTime = 0f)
	{
		return false;
	}

	public void UpdateGuideMaskDepth(int newDepth)
	{
	}

	public void SetGuideMaskAlpha(float alpha)
	{
	}

	public bool CheckCanGuide(NewbieGuideId guideId)
	{
		return false;
	}

	public void SetBackendOrPlayerPrefFlag(NewbieGuideId guideId, int prefValue = 1)
	{
	}

	public bool GetBackendOrPlayerPrefFlag(NewbieGuideId guideId)
	{
		return false;
	}

	public bool GetBackendOrPlayerPrefFlagContainNextStep(NewbieGuideId guideId)
	{
		return false;
	}

	public NewbieGuideId GetCurrentGuideId()
	{
		return NewbieGuideId.None;
	}

	public bool CheckIsInForceGuide()
	{
		return false;
	}

	public bool CheckCurrentGuideIdMatch(NewbieGuideId guideId)
	{
		return false;
	}

	public bool IsInHCGuide()
	{
		return false;
	}

	public void CloseMatchGuide(NewbieGuideId guideId)
	{
	}

	private bool CheckAndDoGuide(NewBieGuildBasProcessor guideBarProcessor)
	{
		return false;
	}

	private void UpdateClickMask()
	{
	}

	private void CloseGivenGuide(NewBieGuildBasProcessor guide)
	{
	}

	public void FinishCurrentForceClickFinishGuide()
	{
	}

	public void CloseClickMask()
	{
	}

	public bool CheckInGuide()
	{
		return false;
	}

	public bool CheckHasGuideCtrl()
	{
		return false;
	}

	public void CloseGuide()
	{
	}

	public void CloseAllUnCloseGuideInQueue()
	{
	}

	public void HideCurGuide()
	{
	}

	public NewPlayerGuideData GetCsvData(int guideId)
	{
		return null;
	}

	public bool GetGuideIsDefaultShowed(int guideId)
	{
		return false;
	}

	public UICommonGuideController GetCurrentGuideCtrl()
	{
		return null;
	}

	private void ChooseGuide()
	{
	}

	private void InitGuideData()
	{
	}

	private bool CheckInBuildGuide()
	{
		return false;
	}

	public bool CheckInLobbyGuideWithMaskInLevel2()
	{
		return false;
	}

	public bool CheckInLobbyGuideIsReadyToShow()
	{
		return false;
	}

	public int GetWeaponSkinCustomLastShowedStep()
	{
		return 0;
	}

	private NewbieGuideId GetWeaponSkinCustomGuideIdByStep(EWeaponSkinCustomGuildStep step)
	{
		return NewbieGuideId.None;
	}

	public NewbieGuideId GetBuildPetGuideIdByStep(EGuidePetAndLoadout step)
	{
		return NewbieGuideId.None;
	}

	public int GetHippoCrisisInventoryShowedStep(bool init = false)
	{
		return 0;
	}

	private NewbieGuideId GetHippoCrisisInventoryGuideIdByStep(EHippoCrisisInventoryGuideStep step)
	{
		return NewbieGuideId.None;
	}

	public int GetBuildPetGuideLastShowedStep()
	{
		return 0;
	}

	public int GetOB48SettingGuideLastStep()
	{
		return 0;
	}

	public NewbieGuideId GetOB48SettingGuideGuideIdByStep(EGuideOB48Setting step)
	{
		return NewbieGuideId.None;
	}

	public NewbieGuideId GetPresetGuideIdByStepV2(EGuideV2PresetNewbie step)
	{
		return NewbieGuideId.None;
	}

	public int GetPresetGuideV2LastStep()
	{
		return 0;
	}

	public NewbieGuideId GetWeaponSkinAndDetailPopGuideIdByStep(EGuideWeaponSkinAndDetailPop step)
	{
		return NewbieGuideId.None;
	}

	public int GetWeaponSkinAndDetailPopLastShowedStep()
	{
		return 0;
	}

	public NewbieGuideId GetEmoteEquipGuideIdByStep(EGuideV2EmoteEquip step)
	{
		return NewbieGuideId.None;
	}

	public int GetEmoteEquipLastShowedStep()
	{
		return 0;
	}
}
