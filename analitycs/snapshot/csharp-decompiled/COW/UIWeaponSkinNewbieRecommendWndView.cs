using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponSkinNewbieRecommendWndView : UIBaseView
{
	public UIButton CloseBtn;

	public UITable RecommendTypes;

	public Transform NewbieRecommend;

	public Transform AllWeapenTypes;

	public UITable TypeTable;

	public GameObject Scrollable;

	public UIScrollView ScrollView;

	public UICenterOnChild WrapContent;

	public GameObject NewbieRecommendPageSelect;

	public GameObject WeaponTypesPageSelect;

	public GameObject NewbieRecommendPage;

	public GameObject WeaponTypesPage;

	public UIButton ToWeaponTypesBtn;

	public UIButton ToNewbieRecommendBtn;

	public Transform GuidePos;

	public UIWidget GuideWidget;

	public GameObject RecommendTitle;

	public GameObject WeaponTypeTitle;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
