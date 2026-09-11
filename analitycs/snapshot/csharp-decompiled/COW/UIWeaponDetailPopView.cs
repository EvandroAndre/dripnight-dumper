using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponDetailPopView : UIBaseView
{
	public UISprite Bg;

	public UIButton MaskClose;

	public UITable RightTable;

	public GameObject TopBtnContainer;

	public GameObject InformationContainer;

	public GameObject UpdateRecordContainer;

	public UIButton GotoBtn;

	public UITable UpdateRecordTable;

	public UITable LeftTable;

	public UIGrid WeaponPropertyToggleGrid;

	public UIGrid scoreGrid;

	public UIButton MasteryBtn;

	public UIButton GloryLeaderBoardBtn;

	public UILabel InformationDesc;

	public UILabel CSPriceLabel;

	public GameObject CSPriceContainer;

	public Transform WeaponPower;

	public UISprite SpecialIcon;

	public UILabel CSPriceDesc;

	public UILabel SpecialPropertyLabel;

	public UISprite Line1;

	public UISprite Line2;

	public GameObject GotoBtnContainer;

	public UISprite ToggleBg;

	public Transform Main;

	public UITable TopBtnTable;

	public UITable InformationTable;

	public UITable TableTag;

	public GameObject LeftLine;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
