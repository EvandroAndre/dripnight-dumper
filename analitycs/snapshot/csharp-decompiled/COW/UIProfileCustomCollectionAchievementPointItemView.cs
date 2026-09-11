using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomCollectionAchievementPointItemView : UIBaseView
{
	public UIButton RemoveBtn;

	public GameObject Selected;

	public UIButton Button;

	public ProfileCustomDragDropItem DragItem;

	public UILabel time;

	public GameObject Icon;

	public UITable TableContainer;

	public UILabel LabelType;

	public UILabel LabelTypeShadow;

	public GameObject AchievementValue;

	public UILabel LabelAchievementValue;

	public GameObject RankingContainer;

	public UILabel RankingLabel;

	public GameObject AchievementIconContainer;

	public UINetworkTexture Texture;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
