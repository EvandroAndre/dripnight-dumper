using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisItemBriefBoxView : UIBaseView
{
	public UISprite Bg;

	public UITable MainTable;

	public GameObject ItemContainer;

	public GameObject AttachmentContainer;

	public UIGrid WeaponPropertyGrid;

	public UILabel DescLabel;

	public UILabel ValueLabel;

	public UILabel NameLabel;

	public UILabel WeightLabel;

	public UITable AttachmentTable;

	public UIButton Mask;

	public Transform ItemRoot;

	public GameObject ItemDetailInfoContainer;

	public UITable ItemDetailInfoTable;

	public GameObject BtnsContainer;

	public UITable BtnsTable;

	public UITable NormalBtnTable;

	public UITable SmallBtnTable;

	public UIPanel ScrollViewPanel;

	public UIScrollView ScrollView;

	public UIWidget DragScrollView;

	public GameObject WeaponPropertyContainer;

	public UILabel TypeLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
