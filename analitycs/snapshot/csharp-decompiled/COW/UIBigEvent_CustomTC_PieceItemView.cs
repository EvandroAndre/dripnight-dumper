using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomTC_PieceItemView : UIBaseView
{
	public UINetworkTexture PieceItemIcon;

	public UIButton PieceItemBtn;

	public UINetworkTexture ProgreseIcon;

	public UIButton ProgreseBtn;

	public UILabel ProgressLabel;

	public Transform RewardEffect;

	public UIWidget UIBigEvent_CustomTC_PieceItem;

	public UINetworkTexture PieceItemSelected;

	public UINetworkTexture LockIcon;

	public GameObject Main;

	public Animation MainAnimation;

	public Transform ProgressEffect;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
