using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponSkinPokedexView : UIBaseView
{
	public UIEasyList QualityMenuGrid;

	public UIButton PokedexShareBtn;

	public GameObject TypeFilter;

	public GameObject Left;

	public GameObject Filter;

	public GameObject ShareInfo;

	public UILabel TotalCount;

	public GameObject NullData;

	public UIEasyList ShareGrid;

	public UIButton ModelFilterTipsBtn;

	public GameObject EnablePokedexShare;

	public UIWidget ModelFilterInfo;

	public UITable2 PokedexTable;

	public UITable2Item LimitedSplitLine;

	public UITable2Item ExpiredSplitLine;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
