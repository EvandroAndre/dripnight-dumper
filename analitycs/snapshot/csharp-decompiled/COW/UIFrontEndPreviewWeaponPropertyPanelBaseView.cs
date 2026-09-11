using UnityEngine;

namespace COW;

public class UIFrontEndPreviewWeaponPropertyPanelBaseView : UIFrontEndPreviewUIComponentBaseView
{
	public UIGrid ScoreGrid;

	public UIButton WeaponSkillBtn;

	public UISprite SpriteWeaponSkillIcon;

	public UILabel PropertyTitle;

	public UIGrid BtnGrid;

	public UIGrid BtnGridPve;

	public UIButton DetailBtn;

	public UIButton DetailBtnPve;

	public UIButton DetailBtnPvpPve;

	public Transform PvpRoot;

	public UIGrid PVE_ScoreGrid;

	public UILabel PVE_PropertyTitle;

	public UIButton PVE_DetailBtn;

	public Transform PveRoot;

	public UICenterOnChild CenterOnChildCtrl;

	public GameObject PropertyTypeScrollTable;

	public UIPanel ScrollViewPanel;

	public GameObject ShowPvpToggle;

	public GameObject ShowPveToggle;

	public GameObject PvpToggleSelected;

	public GameObject PveToggleSelected;

	public UIButton ExpandBtn;

	public UIButton PveExpandBtn;

	public GameObject ExpandBtnSprite;

	public GameObject ExpandBtnBg;

	public GameObject PveExpandBtnSprite;

	public GameObject PveExpandBtnBg;

	public UIWidget PvpBgContainer;

	public UIWidget PveBgContainer;

	public GameObject PvpTitleContainer;

	public GameObject PveTitleContainer;

	public GameObject PvpLine;

	public GameObject PveLine;

	public UITable BtnTable;

	public UITable PveBtnTable;

	public UITable WeaponTable;

	public UITable PveWeaponTable;

	public UISprite WeaponIcon;

	public UISprite PveWeaponIcon;

	public GameObject SeparateIcon;

	public GameObject PveSeparateIcon;

	public UISprite WeaponBg;

	public UISprite PveWeaponBg;
}
