using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponProficiencyView : UIBaseView
{
	public UISprite SpriteProficiency;

	public UILabel LabelName;

	public UIButton BtnPin;

	public UISprite SpritePinned;

	public UISprite SpriteToPin;

	public UIEasyList GridWeapon;

	public Transform TrRootPickScreen;

	public UIButton BtnJmpToArmory;

	public UILabel LabelHeadShotsVal;

	public UILabel LabelKillVal;

	public UILabel LabelDamageVal;

	public UILabel LabelCureVal;

	public UILabel LabelProgress;

	public UIButton BtnShare;

	public GameObject GoLevel1;

	public GameObject GoLevel2;

	public GameObject GoLevel3;

	public GameObject GoLevel4;

	public GameObject GoLevel5;

	public GameObject GoHeadShot;

	public GameObject GoKill;

	public GameObject GoDamage;

	public GameObject GoCure;

	public UIWidget WidgetPreview;

	public GameObject EventTrigger;

	public UIGrid GridProgressBar;

	public UILabel LabelName2;

	public GameObject GoVfxUpgrade1;

	public GameObject GoVfxUpgrade2;

	public GameObject GoVfxUpgrade3;

	public GameObject GoVfxUpgrade4;

	public GameObject GoPick;

	public GameObject Bottom;

	public GameObject GoShare;

	public UILabel LabelNameShare;

	public UILabel LabelNameShare2;

	public UILabel LabelShareKey;

	public UISprite SpriteProficiencyShare;

	public GameObject ICON;

	public UILabel LabelTrial;

	public UIScrollView ScrollViewPick;

	public UIButton BtnJmpToWeaponLeaderboard;

	public GameObject JmpToWeaponLeaderboardGameObject;

	public GameObject LadderLeaderboardGuidContainer;

	public UILabel LadderLeaderboardGuid;

	public Transform WeaponPowerTrans;

	public GameObject WeaponPower;

	public Transform WeaponPowerShare;

	public GameObject RankLabelGameObject;

	public UILabel RankLabel;

	public GameObject LevelUpBtnGameObject;

	public UIButton LevelUpBtn;

	public GameObject ProgressBarV2;

	public GameObject ProgressBarV1;

	public GameObject LevelUpBarUIFX;

	public UIGrid Grid;

	public GameObject GoVfxUpgradeV2;

	public UIGrid ShareGrid;

	public UILabel WeaponProficiencyRankLabel;

	public GameObject WeaponProficiencyRankLabelGameObject;

	public GameObject RankLabelContainer;

	public GameObject LabelProficiencyShareGameObject;

	public UILabel LabelProficiencyShare;

	public GameObject WeaponProficiencyRankShareContainer;

	public Transform WeaponPowerShareWithRank;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
