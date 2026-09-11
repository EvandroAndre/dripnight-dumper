using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomCollectionWeaponProficiencyItemView : UIBaseView
{
	public UISprite WeaponSprite;

	public GameObject WeaponProfiency;

	public UILabel RankLabel;

	public UILabel WeaponLabel;

	public UISprite LevelIcon;

	public UIButton RemoveBtn;

	public UIButton Button;

	public ProfileCustomDragDropItem DragItem;

	public GameObject Selected;

	public GameObject Icon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
