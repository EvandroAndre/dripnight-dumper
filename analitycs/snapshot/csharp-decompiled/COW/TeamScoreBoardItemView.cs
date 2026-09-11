using GCommon;
using UnityEngine;

namespace COW;

public class TeamScoreBoardItemView : UIBaseView
{
	public UISprite TeamColor;

	public GameObject SelfBG;

	public GameObject MVPGrade;

	public UILabel NormalGrade;

	public UISprite SpecialIcon;

	public GameObject MaxRankNode;

	public UISprite MaxRankIcon;

	public UILabel MaxRankTxt;

	public UIEffectSprite BannerBg;

	public UIEffectSprite HeadIcon;

	public UILabel Nickname;

	public UILabel ClanName;

	public UILabel Info1Txt;

	public UILabel Info2Txt;

	public UILabel Info3Txt;

	public GameObject BGGray;

	public UIButton ReportBtn;

	public GameObject GoKDA;

	public GameObject GoSkill;

	public Transform TrSkillRoot1;

	public Transform TrSkillRoot2;

	public Transform TrSkillRoot3;

	public Transform TrSkillRoot4;

	public UIGrid TrKdaPanelSkillRoot;

	public UICenterOnChild GradeWrapContent;

	public UILabel StreakTxt;

	public UIScrollView GradeIconSroll;

	public GameObject StreakIconContainer;

	public GameObject RankIconContainer;

	public UISprite IndexBG;

	public UILabel IndexLabel;

	public GameObject Index;

	public UISprite StreakIcon;

	public Transform AdditionalSlotRoot5;

	public UIGrid SkillGrid;

	public UIWidget posLeft;

	public UIWidget posRight;

	public Transform TeamAceVFX;

	public Transform TrSkillRoot5;

	public UIEventListener PetSkillBtn;

	public UISprite PetSkillBtnSprite;

	public GameObject PetLineExt;

	public UIButton AddFriendBtn;

	public GameObject PrivilegeIcon;

	public Transform AvatarFramePos;

	public GameObject PetSkillNormalViewContainer;

	public GameObject PetSkillPresetPickHideContainer;

	public UIButton PetSkillPresetPickHideBtn;

	public GameObject GoAbility;

	public UITable AbilityTable;

	public GameObject ConnectLineContainer;

	public UISprite LoadOutIcon;

	public UISprite AbilityLineFinish;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
