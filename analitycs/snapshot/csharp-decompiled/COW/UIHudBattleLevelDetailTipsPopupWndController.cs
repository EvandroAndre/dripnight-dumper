using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBattleLevelDetailTipsPopupWndController : UIPopupWindowController
{
	private int m_OwnedAbilityCount;

	private UIHudBattleLevelDetailTipsPopupView m_View;

	private Rect m_BgWorldCornerRect;

	private TweenAlpha m_TweenAlphaComp;

	private TweenScale m_TweenScaleComp;

	private NKDHFJHPEFL m_BattleLevelModule;

	private readonly List<UIHudBattleLevelSelectBuildDetailedAbilityController> m_OpenedAbilityCtrlList;

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

	private void RefreshDetailedAbilities(JHNCAGHNHAK playerModule, BattleLevelBuildConfigData battleLevelBuildConfigData)
	{
	}

	private void RefreshContent(JHNCAGHNHAK playerModule, bool showBuildDesc, bool enableClickMask)
	{
	}

	private void RebuildLayout()
	{
	}

	private void ResetPosition(Vector3 targetWorldPosition)
	{
	}

	private void BindGuideTarget(UIWidget guideTargetWidget)
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

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
