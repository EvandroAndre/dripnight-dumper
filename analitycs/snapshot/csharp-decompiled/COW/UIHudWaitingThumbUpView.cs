using GCommon;
using UnityEngine;

namespace COW;

public class UIHudWaitingThumbUpView : UIBaseView
{
	public Animator UIHudWaitingThumbUp;

	public UIButton ThumbUpBtn;

	public UILabel ThumbLabelNormal;

	public UILabel ThumbLabelSpecial;

	public GameObject ThumbUpIconSpecial;

	public UISprite TeamIndex1Icon;

	public UISprite TeamIndex2Icon;

	public UISprite TeamIndex3Icon;

	public UISprite TeamIndex4Icon;

	public UILabel TeamIndex1Text;

	public UILabel TeamIndex2Text;

	public UILabel TeamIndex3Text;

	public UILabel TeamIndex4Text;

	public Transform ThumbNum2VFX;

	public Transform ThumbNum3VFX;

	public Transform ThumbNum4VFX;

	public Transform ThumbNum5VFX;

	public Transform ThumbNum1234VFX;

	public Transform ThumbNum234VFX;

	public Transform ThumbNum34VFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
