using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIAchievementShowController : UIBaseController, IEasyList, IGuideQueueContainer
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static EventDelegate.Callback _003C_003E9__22_0;

		internal void _003CInitEventDelegate_003Eb__22_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public uint id;

		internal bool _003CInitAchievementSelectContainer_003Eb__0(AchievementProfileItemData info)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public AchievementProfileItemData item;

		internal bool _003CUpdateEquippedAchievement_003Eb__0(EquipAchInfo e)
		{
			return false;
		}
	}

	private UIAchievementShowView m_View;

	private readonly int m_MaxAchievementShowNum;

	private List<UIAchievementCommonController> m_UIAchievementCommonCtrlList;

	private UIModelAchievement m_ModelAchievement;

	private List<AchievementProfileItemData> m_AchievementProfileItemList;

	private List<uint> m_CompletedAchievement;

	private uint m_SelectedAchievementId;

	private AchievementProfileItemData m_SelectedInfo;

	private bool m_HasPreInfo;

	private bool m_HasAchChanged;

	private List<AchievementProfileItemData> m_CurSelectAchievementList;

	private const string GUIDE_STEP1_KEY = "AchievementShow_Step1_Account{0}";

	private const string GUIDE_STEP2_KEY = "AchievementShow_Step2_Account{0}";

	private const string GUIDE_STEP3_KEY = "AchievementShow_Step3_Account{0}";

	private const string GUIDE_STEP4_KEY = "AchievementShow_Step4_Account{0}";

	private GuideQueue m_GuideQueue;

	private bool m_HasDoneGuide;

	public AchievementProfileItemData SelectedInfo => null;

	public List<AchievementProfileItemData> CurSelectAchievementList => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void InitAchievementDisplayContainer()
	{
	}

	private void InitAchievementSelectContainer()
	{
	}

	private void InitEventDelegate()
	{
	}

	public void UnSelectAllAchievement()
	{
	}

	public void UnSelectEasyListItem()
	{
	}

	public void SelectAndScrollToEasyListItem()
	{
	}

	private void ComputeScrollViewPosition(UIEasyList grid)
	{
	}

	private int GetSelectedController()
	{
		return 0;
	}

	public void OnAchievementItemClick(AchievementProfileItemData info)
	{
	}

	public void RefreshAchievementDesc(uint achievementId)
	{
	}

	public void RefreshAchievementBtnState(EAchievementBtnState state)
	{
	}

	public void RefreshAchievementDisplay()
	{
	}

	private void OnAchievementBtnClick()
	{
	}

	private void UpdateEquippedAchievement()
	{
	}

	private void HighLightItem(int itemIndex)
	{
	}

	private void InitGuideQueue()
	{
	}

	private void StartAchievementShowGuide()
	{
	}

	private void AddGuideQueueSteps()
	{
	}

	public bool IsAvailable()
	{
		return false;
	}

	public bool IsStepAvailable(string stepKey, out UIWidget targetWidget, out UIButton finishButton)
	{
		targetWidget = null;
		finishButton = null;
		return false;
	}

	public GameObject GetGuideMask()
	{
		return null;
	}

	public UICommonGuideController OpenGuideController(string stepKey)
	{
		return null;
	}

	private bool _003CSelectAndScrollToEasyListItem_003Eb__25_0(uint id)
	{
		return false;
	}

	private bool _003COnAchievementBtnClick_003Eb__32_0(AchievementProfileItemData info)
	{
		return false;
	}

	private bool _003COnAchievementBtnClick_003Eb__32_1(AchievementProfileItemData info)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
