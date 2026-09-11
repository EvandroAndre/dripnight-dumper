using GCommon;
using UnityEngine;

namespace COW;

public class UIAchievementMainView : UIBaseView
{
	public UIEasyList AchievementList;

	public UIButton BtnShare;

	public UILabel LabelType;

	public UILabel LabelAchievementValue;

	public GameObject Bar;

	public Transform Detail;

	public GameObject Content;

	public UIButton BtnAward;

	public UILabel LabelTypeShadow;

	public Animation MainAnim;

	public GameObject AwardTipsIcon;

	public GameObject AwardTipsIcon02;

	public GameObject RankingContainer;

	public UILabel RankingLabel;

	public GameObject BOX;

	public GameObject Right;

	public UICountDownLabel CountDownLabel;

	public GameObject TimeContainer;

	public UIButton GoToBtn;

	public GameObject AchievementValue;

	public Transform AchievementNumTrans;

	public GameObject StateMenuContainer;

	public GameObject StateMenuSrcPos;

	public Transform SeasonYearStateMenu;

	public GameObject SeasonYearToggleContainer;

	public UIToggleButton CurSeasonYearToggle;

	public UIToggleButton PastSeasonYearToggle;

	public UIToggleButtonGroup ToggleBtnGroup;

	public GameObject CommonAchievementContainer;

	public GameObject BigEventContainer;

	public GameObject Title;

	public UILabel BigEventLabelType;

	public UILabel CollectedNum;

	public UILabel CollectedNumShadow;

	public UILabel BigEventLabelTypeShadow;

	public UIEasyList BigEventList;

	public GameObject BigEventContent;

	public UIButton CheckBox;

	public GameObject SpriteToggleBg;

	public GameObject SpriteSelect;

	public GameObject CompletedOnlyLabel;

	public GameObject BigEventEmptyNode;

	public Transform BigEventStateMenu;

	public GameObject All;

	public UIButton AllNormal;

	public GameObject Battle;

	public UIButton BattleNormal;

	public GameObject Collection;

	public UIButton CollectionNormal;

	public GameObject AllSelect;

	public GameObject BattleSelect;

	public GameObject CollectionSelect;

	public GameObject Career;

	public UIButton CareerNormal;

	public GameObject CareerSelect;

	public GameObject Year;

	public UIButton YearNormal;

	public GameObject YearSelect;

	public GameObject Event;

	public UIButton EventNormal;

	public GameObject EventSelect;

	public GameObject TypeTab;

	public GameObject Arrow;

	public GameObject BattleColor;

	public GameObject CollectionColor;

	public GameObject CareerColor;

	public GameObject YearColor;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
