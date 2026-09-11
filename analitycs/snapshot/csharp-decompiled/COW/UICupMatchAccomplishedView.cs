using GCommon;
using UnityEngine;

namespace COW;

public class UICupMatchAccomplishedView : UIBaseView
{
	public UINetworkTexture CupCDNTexture;

	public UILabel LabelSquad;

	public UILabel LabelCup;

	public UILabel LabelTier;

	public UIButton BtnShare;

	public Transform ProfileContainer1;

	public Transform ProfileContainer2;

	public Transform ProfileContainer3;

	public Transform ProfileContainer4;

	public Transform ProfileContainer5;

	public Transform Cup;

	public Transform InfoContainer;

	public Transform InfoPosBombMode;

	public Transform CupPosBombMode;

	public GameObject InfoContainerSolo;

	public UILabel LabelChampionSolo;

	public UILabel LabelTierSolo;

	public UILabel LabelSquadSolo;

	public UINetworkTexture HeadTexture;

	public UISprite HeadIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
