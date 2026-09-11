using GCommon;
using UnityEngine;

namespace COW;

public class UIHudAvatarAttributeBagItemView : UIBaseView
{
	public UISprite AttributeIcon;

	public UILabel AttributeName;

	public UILabel AttributeType;

	public UILabel AttributeDesc;

	public GameObject Selected;

	public GameObject Unselected;

	public GameObject Unselectable;

	public GameObject UpgradeAttributeIcon;

	public UISprite AttributeBgCurLevel;

	public UISprite AttributeBgNextLevel;

	public UISprite AttributeIconCurLevel;

	public UISprite AttributeIconNextLevel;

	public UIButton UIHudAvatarAttributeBagItem;

	public UILabel AttributeDescAdditional;

	public UITable Table;

	public GameObject IsRecommended;

	public UISprite Bg22;

	public GameObject LevelIcon1;

	public GameObject LevelIcon2;

	public GameObject LevelIcon3;

	public UILabel LevelLabel;

	public UISprite BgLine;

	public UISprite BgLight;

	public UISprite Bg11;

	public GameObject LevelGO1;

	public GameObject LevelGO2;

	public GameObject LevelGO3;

	public UIGrid LevelGo;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
