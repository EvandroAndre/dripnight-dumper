using GCommon;
using UnityEngine;

namespace COW;

public class UIHudReviveNotifyView : UIBaseView
{
	public UISprite HighRankNode;

	public UILabel HighRankNameLabel;

	public GameObject Root;

	public UISprite NormalNode;

	public UILabel NormalNameLabel;

	public UISprite OtherNode;

	public UILabel OtherNameLabel;

	public GameObject GameMissionNode;

	public UILabel GameMissionNameLabel;

	public GameObject SummonerNode;

	public GameObject AdvancedRevivePointrNode;

	public UILabel AdvancedRevivePointrNameLabel;

	public GameObject IIVNode;

	public GameObject BuffRevivePointShopNode;

	public UILabel BuffRevivePointShopNameLabel;

	public GameObject EnergyDeviceNode;

	public GameObject RevivePointSoloNode;

	public UILabel RevivePointSoloLabel;

	public GameObject LandingFightProtectGroupNode;

	public UILabel LandingFightProtectGroupLabel;

	public GameObject GB_GPGulagReviveNode;

	public GameObject GB_GPGulagBattleReviveNode;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
