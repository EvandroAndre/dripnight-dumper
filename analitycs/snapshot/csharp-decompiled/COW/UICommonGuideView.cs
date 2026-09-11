using GCommon;
using UnityEngine;

namespace COW;

public class UICommonGuideView : UIBaseView
{
	public GameObject GoHand;

	public GameObject GoCircle;

	public UISprite SpriteCircle;

	public GameObject GoRect;

	public UISprite SpriteRect;

	public GameObject GoArrow;

	public UIAnchor AnchorArrow;

	public GameObject GoHint;

	public UILabel HintLabel;

	public UISprite TipsBGWidget;

	public Transform TrRootCharacter;

	public UIWidget WidgetBound;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
