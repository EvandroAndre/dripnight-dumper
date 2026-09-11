using GCommon;
using UnityEngine;

namespace COW;

public class UILuckyBagItemView : UIBaseView
{
	public Animator Anim;

	public UIWidget widget;

	public UIButton DrawBtn;

	public UICountDownLabel ExpiredTime;

	public UILabel RemainNum;

	public UILabel TotalNum;

	public GameObject BlueQuality;

	public GameObject PurpleQuality;

	public GameObject GoldQuality;

	public UILabel LuckyBagMessage;

	public UIButton MessageBtn;

	public GameObject Claimed;

	public GameObject Claimable;

	public GameObject Expired;

	public UIButton LuckyBagBtn;

	public UISprite LuckyBagSprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
