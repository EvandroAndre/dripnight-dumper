using GCommon;
using UnityEngine;
using UnityEngine.Video;

namespace COW;

public class UIHudTutorialSniperScopeTypeView : UIBaseView
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

	public UITexture VideoType2Texture;

	public VideoPlayer VideoType2Player;

	public UITexture VideoType1Texture;

	public VideoPlayer VideoType1Player;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
