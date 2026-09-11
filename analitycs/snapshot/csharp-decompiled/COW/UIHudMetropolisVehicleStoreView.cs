using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisVehicleStoreView : UIBaseView
{
	public UIEasyList ItemList;

	public UIScrollView ItemListScrollView;

	public UIButton VehicleTab;

	public UIButton FlightTab;

	public UILabel ResetTimeTxt;

	public UIButton ActionBtn;

	public UILabel ActionTxt;

	public GameObject ActionDisableBG;

	public GameObject ActionEnableBG;

	public UIButton BtnCloseMask;

	public UILabel CoinTxt;

	public GameObject DetailContent;

	public UILabel DetailVehicleName;

	public UILabel DetailProperty1Name;

	public UILabel DetailProperty2Name;

	public UISlider DetailProperty1Slider;

	public UISprite DetailProperty1Value;

	public UISlider DetailProperty2Slider;

	public UISprite DetailProperty2Value;

	public UILabel DetailDesc;

	public GameObject VehicleTabSelect;

	public GameObject VehicleTabNormal;

	public GameObject FlightTabSelect;

	public GameObject FlightTabNormal;

	public UITable ActionInfoTable;

	public UIButton BtnCloseMaskLeft;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
