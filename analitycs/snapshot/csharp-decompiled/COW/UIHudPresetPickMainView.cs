using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPresetPickMainView : UIBaseView
{
	public GameObject TeammateInfoContainer;

	public UIGrid TeammateInfoGrid;

	public UILabel SelfName;

	public UILabel TeamIndex;

	public UISprite TeamIndexBG;

	public UIButton CloseBtn;

	public Transform SkillContainer;

	public GameObject LoadoutContainer;

	public Transform LoadoutIconContainer;

	public GameObject LoadoutCanChangeContainer;

	public UIButton LoadoutCanChangeBtn;

	public GameObject LoadoutBanChangeContainer;

	public UIButton LoadoutBanChangeBtn;

	public UIButton ChangeSkillBtn;

	public GameObject NormalViewSkillContainer;

	public GameObject ChangeViewSkillContainer;

	public UIGrid ChangeViewSkillGrid;

	public GameObject LoadoutChangingContainer;

	public UIButton LoadoutChangingBtn;

	public UIGrid LoadoutChangingGrid;

	public UIButton CloseChangeSkillBtn;

	public UIButton bgBtn;

	public UIWidget TeammateInfoTutorialWidget;

	public UIWidget SelfInfoTutorialWidget;

	public Transform SkillChangingSuccessUIFX;

	public UISprite EmptyLoadoutIcon;

	public Transform LoadoutChangingSuccessUIFX;

	public UIColor LoadoutChangingBG;

	public UITable LoadoutChangingTable;

	public UIColor ChangeViewSkillBG;

	public GameObject EmptySkillContainer;

	public UITable ChangeViewSkillTable;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
