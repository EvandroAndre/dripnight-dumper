using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudPocketReviveSelectPopupWndController : UIPopupWindowController
{
	private Action m_ClickMaskTriggerHandler;

	private UIClickMask m_ClickMask;

	private UIHudPocketReviveSelectPopupWndView m_View;

	private UIHudPocketReviveSelectPopupWndViewData m_ViewData;

	private readonly List<UIHudPocketReviveSelectCandidateItemController> m_CandidateItemControllers;

	private bool IsSingleSelection => false;

	private uint LevelObjectID => 0u;

	private int MaxReviveTargets => 0;

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

	protected override void OnVisibilityChanged()
	{
	}

	private void AddEventDelegates()
	{
	}

	private void OnCancelBtnClick()
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	private void OnClickMaskTriggered()
	{
	}

	public void SetViewData(UIHudPocketReviveSelectPopupWndViewData viewData)
	{
	}

	public void UpdateCandidatesState(UIHudPocketReviveSelectCandidateItemController itemCtrl, bool selected)
	{
	}

	private void SetupDefaultState()
	{
	}

	private void SetupClickMask()
	{
	}

	private void TryDestroyClickMask()
	{
	}

	private void SetReviveCandidatesTitle()
	{
	}

	private void PopulateReviveCandidates(UIHudPocketReviveSelectCandidateItemViewData[] candidatesViewData)
	{
	}

	private void RefreshLayout()
	{
	}

	private void HandleCandidateSelection(UIHudPocketReviveSelectCandidateItemController itemCtrl)
	{
	}

	private void HandleSingleSelection(UIHudPocketReviveSelectCandidateItemController targetItem)
	{
	}

	private void HandleMultiSelection(UIHudPocketReviveSelectCandidateItemController targetItem)
	{
	}

	private void HandleCandidateCancelSelection(UIHudPocketReviveSelectCandidateItemController itemCtrl)
	{
	}

	private void UpdateConfirmButtonState()
	{
	}

	private int GetSelectedCandidatesCount()
	{
		return 0;
	}

	private List<BHGGAEEHJCO> GetSelectedCandidates()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
