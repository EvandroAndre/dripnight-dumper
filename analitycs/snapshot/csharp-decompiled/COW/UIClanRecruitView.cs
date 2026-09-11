using GCommon;
using UnityEngine;

namespace COW;

public class UIClanRecruitView : UIBaseView
{
	public UIInput SearchInput;

	public UIButton BtnSearch;

	public UIButton BtnRecruit;

	public UIButton BtnCommunity;

	public UIButton BtnRefresh;

	public GameObject RandomPlayer;

	public UILabel SearchBarLabel;

	public UIEasyList RecruitPlayerList;

	public GameObject BottomBtns;

	public GameObject SearchIcon;

	public GameObject ClearIcon;

	public UIEasyList RecruitRecommendPlayerList;

	public GameObject RecommendListContainer;

	public GameObject FriendListContainer;

	public UIToggleButtonGroup ToggleBtns;

	public UIToggleButton RecruitToggleBtn;

	public UIToggleButton ApprovalToggleBtn;

	public GameObject SearchBarPosNoToggle;

	public GameObject SearchBarPosWithToggle;

	public GameObject RecruitContainer;

	public UIEasyList RecruitRecommendPlayerListSmall;

	public GameObject RecommendListContainerSmall;

	public GameObject SearchBarContainer;

	public GameObject ApplyContainer;

	public GameObject EmptyNode;

	public GameObject ApplyContent;

	public UIButton ClanPromotionBtn;

	public UIEasyList ApplyEasyList;

	public UIButton BRSortBtn;

	public UIButton CSSortBtn;

	public UISprite CSSortUp;

	public UISprite CSSortDown;

	public UISprite BRSortUp;

	public UISprite BRSortDown;

	public GameObject ScrollViewsWithApply;

	public GameObject FriendListContainerSmall;

	public GameObject ScrollViewsNoApply;

	public UIEasyList RecruitPlayerListSmall;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
