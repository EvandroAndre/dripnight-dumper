using GCommon;
using UnityEngine;

namespace COW;

public class UIHudVehicleLevelStatsView : UIBaseView
{
	public UISprite VehicleIcon;

	public UIButton BtnVehicleIcon;

	public GameObject UIFXLevelUp;

	public UILabel PropertyDesc;

	public UILabel VehicleLevel;

	public UILabel TipsTitleLabel;

	public UILabel TipsLevel1Desc;

	public UILabel TipsLevel2Desc;

	public UILabel TipsLevel3Desc;

	public UILabel TipsLevel4Desc;

	public GameObject Tips;

	public UIWidget AlphaContentLv2;

	public GameObject FilledNodeIconLv2;

	public UIWidget AlphaContentLv3;

	public GameObject FilledNodeIconLv3;

	public UIWidget AlphaContentLv4;

	public GameObject FilledNodeIconLv4;

	public UISprite TipsBg;

	public UIWidget AlphaContentLv1;

	public GameObject FilledNodeIconLv1;

	public Animation Container;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
