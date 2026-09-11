using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGameModeCSRankSpecialPlayController : UIBaseController, IUIModelDataChangeObserver, IGuideQueueContainer
{
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public bool flag;

		public TweenPosition target1;

		public Transform pos2;

		public Transform pos1;

		public TweenPosition target2;

		public Transform pos3;

		internal void _003CStartTween_003Eb__0()
		{
		}
	}

	private UIGameModeCSRankSpecialPlayView m_View;

	private UIModelMapOpeningInfo m_ModelMapOpeningInfo;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private SpecialModeOpeningInfoDesc m_Desc;

	private GuideQueue m_GuideQueue;

	private const string CSSpecialMatchPlayerPrefKey1 = "CSSpecialGuide_1";

	private bool m_Collapsed;

	private uint m_ProtectTimes;

	private bool m_IsSelected;

	private bool m_IsSelectedOri;

	private uint m_DalayCall;

	private readonly List<UIGameModeGameplayAffixDetailsDropdownItemController> m_DropdownItems;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnDisable()
	{
	}

	public void SetData(SpecialModeOpeningInfoDesc desc)
	{
	}

	public void AdjustPanelDepthWithBase(int dropdownBaseDepth)
	{
	}

	public void CollapseDropdown()
	{
	}

	private void SetupDefaultState()
	{
	}

	private void RefreshUI()
	{
	}

	private void RefreshSelectToggleState(bool displayNoInteract)
	{
	}

	private void UpdateDropdownBtnWithDisplayState(bool displayNoInteract)
	{
	}

	private void RepopulateDropdownItems()
	{
	}

	private void StartTween(TweenPosition target1, TweenPosition target2, Transform pos1, Transform pos2, Transform pos3)
	{
	}

	private void RefreshProtectTimes()
	{
	}

	private void RefreshScrollViewDragRegion()
	{
	}

	private void CollapseExpandDropdownInternal(bool collapse)
	{
	}

	private void SpecialPlayBtnClick()
	{
	}

	private void OnDropdownBtnClick()
	{
	}

	private void OnScrollViewDragRegionBtnClick()
	{
	}

	private void AddEventDelegates()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void StartGuide()
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

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
