using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisInventoryItemView : UIBaseView
{
	public GameObject NonDragGO;

	public UILabel ValueLabel;

	public UISprite SpriteBg;

	public GameObject Selected;

	public UISprite ItemIcon;

	public GameObject MultiSelect;

	public GameObject MultiSelected;

	public GameObject MultiUnSelected;

	public UILabel WeightLabel;

	public UIColor QualityBG;

	public UISprite LightBG;

	public UILabel CountLabel;

	public UIButton Button;

	public UIHippoCrisisInventoryDragDropItem DragDropItem;

	public UILabel MaterialNumLabel;

	public UILabel NeedNumLabel;

	public GameObject MaterialNum;

	public UILabel Owned;

	public GameObject EquipAttch;

	public UISprite Red;

	public TweenScale UIHippoCrisisInventoryItem;

	public UIWidget GuideWidget;

	public Transform MarketTipsPos;

	public GameObject MatUseContainer;

	public UIButton ShowTipsButton;

	public UISprite QualityBG_NEW;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
