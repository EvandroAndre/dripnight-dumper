using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponSkinLobbyMainShareView : UIBaseView
{
	public UISprite ShareLine;

	public UIColor ShareDotColor;

	public UILabel SHareNameLabel;

	public GameObject ShareLevelObj;

	public UILabel ShareLevelLabel;

	public UISprite ShareLevelIcon;

	public Transform ShareLevelLeftLabelTr;

	public Transform ShareLevelCommonLabelTr;

	public UILabel ShareDesc;

	public Transform ShareLowPoint;

	public Transform ShareHighPoint;

	public GameObject KillCountContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
