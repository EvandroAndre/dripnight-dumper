using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHippoCrisisBackpackBoxView : UIBaseView
{
	public UIScrollView ScrollView;

	public UITable2 Table2;

	public Transform BackpackTitleContainer;

	public Transform TemplateContainer;

	public UIWidget SafeBoxDragWidget;

	public UIHippoCrisisDragResponseContainer SafeBoxDrag;

	public UIWidget BackpackDragWidget;

	public UIHippoCrisisDragResponseContainer BackpackDrag;

	public Transform SafeBoxTopContainer;

	public Transform SafeBoxBottomContainer;

	public UICustomParamUtil CustomParamUtil;

	public UIButton StoreAllBtn;

	public UISprite enableBg;

	public UISprite disableBg;

	public UIButton DescendingBtn;

	public UIButton AscendingBtn;

	public Transform SortMenuPos;

	public UILabel StoreAllLabel;

	public UIColor BagMask;

	public UIColor SafeMask;

	public UISprite BagProgress;

	public UISprite BagProgressAdd;

	public UISprite SafeProgress;

	public UISprite SafeProgressAdd;

	public UISprite BagProgress_Ban;

	public UISprite SafeProgress_Ban;

	public UILabel BagDragCapacityLabel;

	public UILabel SafeDragCapacityLabel;

	public UILabel BagDragCapacityChangeLabel;

	public UILabel SafeDragCapacityChangeLabel;

	public UILabel BagMaskLabel;

	public UILabel SafeMaskLabel;

	public UILabel TotalWeightLabel;

	public GameObject BackpackTitle_Container;

	public GameObject TotalWeight;

	public GameObject DropInfoEffect;

	public UISprite DropAfterFill;

	public UISprite DropBeforeFill;

	public UILabel DropInfoText;

	public GameObject GuideMask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
