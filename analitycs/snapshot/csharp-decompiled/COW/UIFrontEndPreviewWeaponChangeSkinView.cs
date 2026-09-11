using GCommon;
using UnityEngine;

namespace COW;

public class UIFrontEndPreviewWeaponChangeSkinView : UIBaseView
{
	public UIFrontEndPreviewWeaponChangeSkinBaseView BaseView;

	public UILabel SecondLabelUnSelect;

	public UILabel SecondLabelSelect;

	public UILabel ThirdLabelSelect;

	public UILabel ThirdLabelUnSelect;

	public UILabel FirstLabelSelect;

	public UILabel FirstLabelUnSelect;

	public GameObject BgTwo;

	public GameObject BgThree;

	public Transform ChangeWeaponSkinStatsPos;

	public GameObject OldCon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
