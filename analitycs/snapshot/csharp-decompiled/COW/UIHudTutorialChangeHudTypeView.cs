using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTutorialChangeHudTypeView : UIBaseView
{
	public UILabel TitleMain;

	public UILabel TitleSub;

	public UIButton BtnType1;

	public GameObject CheckedType1;

	public UIButton BtnType2;

	public GameObject CheckedType2;

	public UIButton ConfirmBtn;

	public GameObject EnableSprite;

	public GameObject DisableSprite;

	public UILabel CountDownLabel;

	public UINetworkTextureExt HudType2;

	public UINetworkTextureExt HudType1;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
