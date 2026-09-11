using GCommon;
using UnityEngine;

namespace COW;

public class UIPrimeShareClothesBubbleView : UIBaseView
{
	public GameObject RequestingShareClothesState;

	public GameObject NormalState;

	public UILabel LabelRequestingShare;

	public UICountDownLabel CountDownLabelRequestingShare;

	public GameObject RequestingShareAccept;

	public UILabel LabelRequestingShareAccept;

	public UIButton ButtonRequestingShareAccept;

	public UILabel LabelNormal;

	public UICountDownLabel CountDownLabelNormal;

	public UILabel LabelActivelySharing;

	public UICountDownLabel CountDownLabelActivelySharing;

	public GameObject ActivelySharingAccept;

	public UILabel LabelActivelySharingAccept;

	public UIButton ButtonActivelySharingAccept;

	public GameObject ActivelySharingClothesState;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
