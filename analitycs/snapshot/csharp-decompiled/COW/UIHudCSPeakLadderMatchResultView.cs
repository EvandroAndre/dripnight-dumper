using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSPeakLadderMatchResultView : UIBaseView
{
	public Animation RankInfoAnim;

	public UISprite RankAfterSprite;

	public UISprite RankBeforeSprite;

	public GameObject ScoreInfoContainer;

	public UIButton BackMaskBtn;

	public UIButton WeaponPowerTitleTip;

	public UITable WeaponPowerContentTable;

	public Transform WeaponPowerContentTableTransform;

	public Animation MainContainerAnim;

	public Transform EnergyConsumeVFXPos;

	public UILabel MatchModeTypeLabel;

	public GameObject WeaponPowerContainer;

	public Transform FirstSpecialBouns;

	public Transform SecondSpecialBonus;

	public Transform FirstReachRankContainer;

	public GameObject InvalidMatch;

	public GameObject OccupationUpdateContainer;

	public UIButton OccupationUpdateTitleTipBtn;

	public UITable OccupationUpdateContentTable;

	public UITable RightTable;

	public UIButton CSPeakEnergyTitleTip;

	public UILabel CSPeakEnergyBefore1;

	public UILabel CSPeakEnergyDeltaDecrease;

	public GameObject CSPeakEnergyChangeCon;

	public GameObject CSPeakEnergyFreezeCon;

	public Transform CSPeakEnergyFirstFreeze;

	public UILabel CSPeakEnergyFreezeLabel;

	public GameObject CSPeakEnergyCon;

	public UIGrid CSPeakGrid;

	public GameObject CSPeakWinStat;

	public GameObject CSPeakEnergyStat;

	public GameObject CSPeakPointsChangeStat;

	public UILabel CSPeakWinStatTitle;

	public UILabel CSPeakWinStatValue;

	public UILabel CSPeakEnergyStatTitle;

	public UILabel CSPeakEnergyStatValue;

	public UILabel CSPeakPointsChangeStatTitle;

	public UILabel CSPeakPointsChangeStatValueDecrease;

	public UILabel CSPeakEnergyFreezeBefore;

	public UILabel CSPeakEnergyAddDetailValue;

	public UILabel CSPeakEnergyDecreaseDetailValue;

	public GameObject CSPeakRankCon;

	public UILabel CSPeakCurRank;

	public UILabel CSPeakDeltaRank;

	public UILabel CSPeakPointsChangeStatValueAdd;

	public GameObject CSPeakEnergyIcon;

	public UILabel CSPeakCurScore;

	public GameObject CSPeakRankArrowUp;

	public GameObject CSPeakRankArrowDown;

	public UILabel CSPeakEnergyEmptyLabel;

	public GameObject CSPeakEnergyDecreaseDetail;

	public GameObject CSPeakEnergyAddDetail;

	public UIGrid CSPeakEnergyDetailGrid;

	public UINetworkTextureExt CDNBg;

	public GameObject ProtectionCompensationTip;

	public GameObject CSPeakPunishStat;

	public UILabel CSPeakPunishStatTitle;

	public UILabel CSPeakPunishStatValue;

	public UILabel CSPeakEnergyDeltaAdd;

	public UIButton CSPeakWinStatTip;

	public UILabel CSPeakEnergyBefore2;

	public UICenterTargetHelper CSPeakEnergyCenterAdd;

	public UICenterTargetHelper CSPeakEnergyCenterDecrease;

	public Transform RankMiddleVfx;

	public Transform BurstVfxTransform;

	public GameObject CSPeakMvpBonusStat;

	public UILabel CSPeakMvpBonusTitle;

	public UILabel CSPeakMvpBonusValue;

	public GameObject CSPeakDailyTaskStat;

	public UILabel CSPeakDailyTaskTitle;

	public UILabel CSPeakDailyTaskValue;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
