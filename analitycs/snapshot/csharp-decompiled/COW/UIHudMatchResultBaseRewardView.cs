using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMatchResultBaseRewardView : UIBaseView
{
	public UITable ItemTable;

	public GameObject GoldIcon;

	public UILabel GoldCount;

	public TweenColor GoldColor;

	public TweenScale GoldScale;

	public UISprite ExpIcon;

	public UILabel ExpCount;

	public TweenColor ExpColor;

	public TweenScale ExpScale;

	public UISprite PetExpIcon;

	public UILabel PetExpCount;

	public TweenColor PetExpColor;

	public TweenScale PetExpScale;

	public UIButton DetailBtn;

	public UIButton DetailMaskBtn;

	public GameObject ClanActivenessIcon;

	public UILabel ClanActivenessCount;

	public TweenScale ClanActivenessTweenScale;

	public TweenColor ClanActivenessTweenColor;

	public GameObject ClanActivenessIconVFX;

	public GameObject GoldIconVFX;

	public GameObject ExpIconVFX;

	public GameObject PetExpIconVFX;

	public Transform DetailTrans;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
