using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomCardReceiveWndView : UIBaseView
{
	public UINetworkTexture TopBackground;

	public UINetworkTexture BottomBackground;

	public UILabel BottomLabelTitle;

	public UILabel WishCardCountLabel;

	public UIEasyList TopUIEasyList;

	public Transform TopUIEasyListTrans;

	public UIEasyList BottomEasyList;

	public Transform BottomEasyListTrans;

	public Transform ProfileInfoContainer;

	public UIPanel BottomScrollView;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
