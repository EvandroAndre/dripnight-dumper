using GCommon;
using UnityEngine;

namespace COW;

public class UILocationSettingView : UIBaseView
{
	public UIButton ConfirmBtn;

	public GameObject CanSetCon;

	public GameObject CountryFilter;

	public GameObject RegionFilter;

	public UIButton CountryTipsButton;

	public UIPanel CountryTipsPanel;

	public UIButton ProvinceTipsButton;

	public UIPanel ProvinceTipsPanel;

	public GameObject CanClickSprite;

	public GameObject CanNotClickSprite;

	public GameObject CityFilter;

	public UIButton CityTipsButton;

	public UIPanel CityTipsPanel;

	public UILabel TipLabel;

	public UILabel ConfirmBtnLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
