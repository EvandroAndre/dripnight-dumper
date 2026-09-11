using GCommon;
using UnityEngine;

namespace COW;

public class UIRelayMartItemMidView : UIBaseView
{
	public UIButton ItemBtn;

	public UIWidget ItemWidget;

	public Animation Animation;

	public GameObject GreyBg;

	public GameObject HighLightBG;

	public UISprite QualityBG;

	public UISprite SpriteQualityPlus;

	public UISprite QualityNameBG01;

	public BaseItemView2 BaseItemView;

	public GameObject ClaimedTitle;

	public UISprite Descargar;

	public UISprite IPTag;

	public UISprite SpriteOrangeQualityPlus;

	public UILabel NotReadyLabel;

	public GameObject Lock;

	public UILabel Name;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
