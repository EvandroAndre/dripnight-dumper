using GCommon;
using UnityEngine;

namespace COW;

public class UITutorialIndicatorView : UIBaseView
{
	public UIPanel MainPanel;

	public GameObject GoCircle;

	public UISprite SpriteCircle;

	public TweenScale SpriteCircleTweenScale;

	public GameObject GoArrow;

	public UIAnchor AnchorArrow;

	public GameObject GoRect;

	public UISprite SpriteRect;

	public TweenScale SpriteRectTweenScale;

	public GameObject GoHint;

	public UILabel HintLabel;

	public UISprite TipsBGWidget;

	public Transform TrRootCharacter;

	public GameObject GoHand;

	public Transform TrHandVisualAngle;

	public Transform TrHandMoveRound;

	public Transform TrHandDragInBag;

	public GameObject MaskAll;

	public UIButton MaskBtnUIButton;

	public UIWidget MaskBtnUIWidget;

	public BoxCollider MaskBtnBoxCollider;

	public Transform TrHandHintAbove;

	public TweenScale CircleEnhancedShrink;

	public TweenScale RectEnhancedShrink;

	public Transform TrHandCircleDrag;

	public Transform TrHandDragGraph;

	public Transform TrHandClickGround;

	public Transform TrHandDragGround;

	public Transform TrHandClickZeroPos;

	public Transform TrHandCircleDragMove;

	public GameObject CircleDefault;

	public GameObject CircleThinner;

	public UISprite SpriteCircleThinner;

	public GameObject CircleThinnerEffect;

	public TweenScale CircleThinnerTween;

	public GameObject NoGraphicRectGo;

	public UIWidget NoGraphicRectWidget;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
