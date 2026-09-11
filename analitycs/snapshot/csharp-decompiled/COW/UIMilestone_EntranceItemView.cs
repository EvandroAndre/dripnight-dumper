using GCommon;
using UnityEngine;

namespace COW;

public class UIMilestone_EntranceItemView : UIBaseView
{
	public UIButton Btn;

	public UINetworkTexture TextureIcon;

	public UILabel LabelTitle;

	public UISprite SpriteRedDot;

	public GameObject GoBubble;

	public TweenScale PeakDayBubbleShake;

	public UILabel LabelBubble;

	public UINetworkTexture TextureBubble;

	public Transform Effect;

	public UINetworkTextureExt TextureRedDot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
