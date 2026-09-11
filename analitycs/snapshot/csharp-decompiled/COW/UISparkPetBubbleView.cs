using GCommon;
using UnityEngine;

namespace COW;

public class UISparkPetBubbleView : UIBaseView
{
	public UIButton BubbleBtn;

	public UISprite BubbleSprite;

	public UILabel BubbleLabel;

	public UILabel BubbleCornerLabelNumber;

	public GameObject BubbleCorner;

	public BaseItemView2 ItemCon;

	public GameObject Main_Special;

	public UIWidget SpecialBubbleWidget;

	public GameObject Main_Normal;

	public UIButton SpecialBubbleBtn;

	public UILabel LevelUpLabel;

	public UINetworkTexture BubbleItemCDN;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
