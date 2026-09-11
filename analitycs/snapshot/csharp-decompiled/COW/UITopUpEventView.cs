using GCommon;
using UnityEngine;

namespace COW;

public class UITopUpEventView : UIBaseView
{
	public UILabel TotalDiamondLabel;

	public UILabel TimeLabel;

	public UIScrollView ScrollView;

	public UIGrid ItemGrid;

	public GameObject ProgressTable;

	public UILabel TitleLabel;

	public UINetworkTexture CDNBG;

	public UIWidget PreviewBorder;

	public UIWidget PreviewBorderActivity;

	public UIButton ClaimAllBtn;

	public UIButton Hint;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
