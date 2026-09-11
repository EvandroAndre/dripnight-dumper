using GCommon;
using UnityEngine;

namespace COW;

public class UIEvoPassTypeBtnView : UIBaseView
{
	public UIToggleButton UIEvoPassTypeBtn;

	public UILabel SelectedDayLabel;

	public UILabel SelectedPriceLabel;

	public UILabel UnSelectedDayLabel;

	public UILabel UnSelectedPriceLabel;

	public GameObject SalesTag;

	public UILabel SelectedSlashLabel;

	public GameObject SelectedDiamondLabel;

	public GameObject UnSelectedBg;

	public GameObject SelectedBg;

	public UILabel UnSelectedSlashLabel;

	public GameObject UnSelectedDiamondLabel;

	public UICenterTargetHelper UnSelectTable;

	public UICenterTargetHelper SelectedTable;

	public UILabel SelectedDiamondSubLabel;

	public UILabel UnSelectedDiamondSubLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
