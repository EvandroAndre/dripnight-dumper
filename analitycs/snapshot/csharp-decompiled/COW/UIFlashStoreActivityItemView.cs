using GCommon;
using UnityEngine;

namespace COW;

public class UIFlashStoreActivityItemView : UIBaseView
{
	public UILabel DescriptionLabel;

	public UILabel ProgressLabel;

	public UIButton GoBtn;

	public UIButton ClaimBtn;

	public GameObject ClaimedGroup;

	public Animation OnStartAnim;

	public UIGrid AwardItemGrid;

	public UILabel GoBtnLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
