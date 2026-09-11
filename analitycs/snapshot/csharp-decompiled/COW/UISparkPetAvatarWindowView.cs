using GCommon;
using UnityEngine;

namespace COW;

public class UISparkPetAvatarWindowView : UIBaseView
{
	public UIWidget ClickWidget;

	public BoxCollider ClickBoxCollider;

	public UIButton ClickBtn;

	public UISparkPetDragDropItem ClickDragDropItem;

	public UIWidget CollabClickWidget;

	public BoxCollider CollabClickBoxCollider;

	public UIButton CollabClickBtn;

	public UISparkPetDragDropItem CollabClickDragDropItem;

	public UILabel SelfDays;

	public UILabel CollabDays;

	public UIButton BubbleBtn;

	public UISprite BubbleSprite;

	public UILabel BubbleLabel;

	public GameObject AwardBubble;

	public UIPanel SparkPetPanel;

	public VFXCreateHelper FlyVFX;

	public TweenPositionArc FlyVFXTweenArc;

	public VFXCreateHelper BoomVFX;

	public GameObject RotateIcon;

	public GameObject DownLoadIcon;

	public GameObject CollabDownLoadIcon;

	public UISprite DownloadDefault;

	public UISprite CollabDownloadSparkDefault;

	public GameObject DownLoadIconContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
