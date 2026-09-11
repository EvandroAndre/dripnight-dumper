using GCommon;
using UnityEngine;

namespace COW;

public class UIRecommendLoadoutWindowView : UIBaseView
{
	public UIPanel UIRecommendLoadoutWindow;

	public UITable TabTable;

	public UIPanel TopTabScrollView;

	public GameObject PlanContainer;

	public UIScrollView PlanItemScrollView;

	public UIEasyList PlanItemEasyList;

	public GameObject DownArrow;

	public GameObject RecommendPanel;

	public GameObject SearchEntrenceGO;

	public UIButton SearchEntrenceBtn;

	public GameObject SearchTable;

	public UIInput SearchInput;

	public UIButton SearchButton;

	public UIScrollView OfficialModeTabScrollView;

	public UITable OfficialModeTabTable;

	public GameObject EditPanel;

	public UIScrollView PlanListScrollView;

	public UIEasyList EditPlanItemEasyList;

	public UIInput NameInput;

	public UIButton NameInputBtn;

	public UIInput DescriptionInput;

	public UILabel WordCountLabel;

	public UIButton AddTagBtn;

	public UIScrollView TagListScrollView;

	public UIButton EnabledPostBtn;

	public GameObject NoResultIcon;

	public UIButton ClearButton;

	public UITable RecommenderTabTable;

	public GameObject RecommenderTabScrollView;

	public Transform OfficialRoleFilterDropdownRoot;

	public UIButton BackButton;

	public UIButton SelectPlanMask;

	public GameObject LoadoutContainer;

	public GameObject RoleDropdownRoot;

	public GameObject ModeDropdownRoot;

	public UITable TagsTable;

	public GameObject NameEditIcon;

	public GameObject DescriptionEditIcon;

	public UIButton LoadoutEditBtn;

	public UILabel SearchResultLabel;

	public GameObject InValidContainer;

	public GameObject CheckingContainer;

	public UILabel CheckingLabel;

	public UIButton DeletePlanBtn;

	public UIButton DisabledPostBtn;

	public Transform KolRoleFilterDropdownRoot;

	public UILabel SearchCDLabel;

	public GameObject SearchSprite;

	public UIScrollView SearchedPlanItemScrollView;

	public UIScrollView KOLModeTabScrollView;

	public UITable KOLModeTabTable;

	public UIButton EditTagBtn;

	public GameObject LoadoutEditIcon;

	public GameObject DescDownArrow;

	public UIScrollView DescScrollView;

	public UILabel InValidLabel;

	public UIButton EditPlanBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
