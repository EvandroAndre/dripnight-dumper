using GCommon;
using UnityEngine;

namespace COW;

public class UIChatMessageItemView : UIBaseView
{
	public BaseChatMessageView RightView;

	public UIButton headbtn;

	public UIButton RightContentBtn;

	public BaseChatMessageView LeftView;

	public UIButton headbtnleft;

	public UIButton LeftContentBtn;

	public GameObject RightLuckyBuffContainer;

	public Transform RightWeaponPower;

	public Transform LeftWeaponPower;

	public Transform RightLayoutBottomTrans;

	public Transform LeftLayoutBottomTrans;

	public GameObject LeftLuckyBuffContainer;

	public GameObject RightLayoutBottomSrcPos;

	public GameObject LeftLayoutBottomSrcPos;

	public Transform TipsTrans;

	public Transform RightFastMsgTrans;

	public Transform LeftFastMsgTrans;

	public UISprite LeftCorner;

	public UISprite RightCorner;

	public UISprite LeftNormalBanner;

	public UISprite RightNormalBanner;

	public UIColor LeftColorBG;

	public UIColor RightColorBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
