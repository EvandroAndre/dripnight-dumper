using GCommon;
using UnityEngine;

namespace COW;

public class UIMatchNpc_BtnItemView : UIBaseView
{
	public UIButton Btn;

	public UINetworkTexture TextureIcon;

	public UILabel LabelTitle;

	public UISprite LabelSpriteBg;

	public UISprite SpriteRedDot;

	public UINetworkTexture TextureRedDot;

	public GameObject GoBubble;

	public UILabel LabelBubble;

	public TweenScale PeakDayBubbleShake;

	public UINetworkTexture TextureBubble;

	public UINetworkTexture LabelTextureBg;

	public Transform EntranceIconEffect;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
