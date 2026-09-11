using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomCard_BtnItemView : UIBaseView
{
	public UIButton Btn;

	public UINetworkTexture TextureIcon;

	public UILabel LabelTitle;

	public UISprite SpriteRedDot;

	public GameObject GoBubble;

	public UILabel LabelBubble;

	public TweenScale PeakDayBubbleShake;

	public UINetworkTexture TextureBubble;

	public Transform Effect;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
