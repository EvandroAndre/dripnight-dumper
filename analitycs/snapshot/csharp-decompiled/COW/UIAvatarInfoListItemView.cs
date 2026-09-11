using GCommon;
using UnityEngine;

namespace COW;

public class UIAvatarInfoListItemView : UIBaseView
{
	public UIButton AvatarBtn;

	public UIWidget AvatarBtnWidget;

	public UISprite SelectIcon;

	public UIGrid SmallIconGrid;

	public UISprite LockIcon;

	public UISprite StarIcon;

	public UISprite AvatarIcon;

	public VFXCreateHelper AwakenIconGray;

	public UILabel AvatarName;

	public UISprite IpTag;

	public GameObject LockBg;

	public VFXCreateHelper AwakenIconNormal;

	public VFXCreateHelper VFX_awaken;

	public UISprite Tips;

	public UILabel TagNew;

	public VFXCreateHelper NewVFX;

	public GameObject VFX_SetLove;

	public GameObject GiftTips;

	public GameObject ChangeStatusPos;

	public UITable TopRight;

	public Transform DownloadContainer;

	public GameObject EvoPassIcon;

	public UICountDownLabel AvatarCountDownLabel;

	public UIWidget Widget;

	public UISprite NewCharacterIcon;

	public GameObject NewCharacterVFX;

	public VFXCreateHelper NewCharacterVFXHelper;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
