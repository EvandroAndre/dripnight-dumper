using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBattleStyleDetailTipsPopupWndController : UIPopupWindowController
{
	private GKNHKOFFCPG m_BindPlayerModule;

	private int m_OwnedAbilityCount;

	private int m_OpenAbilityCount;

	private UIHudBattleStyleDetailTipsPopupView m_View;

	private Rect m_BgWorldCornerRect;

	private TweenAlpha m_TweenAlphaComp;

	private TweenScale m_TweenScaleComp;

	private UIModelLoadout m_ModelLoadout;

	private bool m_ScrollViewSet;

	private UIClickMask m_PopupClickMask;

	private Action m_HideAction;

	private readonly List<UIHudBattleStyleDetailedAbilityController> m_OpenedAbilityCtrlList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	private void SaveBgWorldCornerRect()
	{
	}

	private void SetupDefaultState()
	{
	}

	private void RefreshDetailedAbilities(GKNHKOFFCPG playerModule, IngameBattleStyleLoadoutData battleLevelBuildConfigData)
	{
	}

	private void RefreshContent(GKNHKOFFCPG playerModule)
	{
	}

	private void RebuildLayout()
	{
	}

	private void SetArrowPanel(bool isShow)
	{
	}

	private float GetExpProcess()
	{
		return 0f;
	}

	private void OnPlayerLevelChange(uint playerID)
	{
	}

	private void OnPlayerExpChange(uint playerID)
	{
	}

	private void SetProcess(bool shadowSet)
	{
	}

	private void ResetPosition(Vector3 targetWorldPosition)
	{
	}

	private void PlayTween()
	{
	}

	private void SetTweenToEnd()
	{
	}

	public void SetViewData(BHGGAEEHJCO playerID, bool showBuildDesc, bool enableClickMask, Vector3 targetWorldPosition, UIWidget guideTargetWidget)
	{
	}

	public Rect GetBgWorldCornerRect()
	{
		return default(Rect);
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void AddVisibility(Action onClickMaskTriggered)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
