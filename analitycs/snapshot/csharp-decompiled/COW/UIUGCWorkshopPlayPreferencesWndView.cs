using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCWorkshopPlayPreferencesWndView : UIBaseView
{
	public UIButton FullScreenBtn;

	public Animation TipAnimation;

	public UILabel PlayPreferencesTxt;

	public GameObject SelectionCon;

	public Animation SelectionAnimation;

	public UITable ProgressTable;

	public GameObject Left;

	public UINetworkTexture LeftNormalTexture;

	public UINetworkTexture LeftSelectedTexture;

	public UINetworkTexture RightNormalTexture;

	public UINetworkTexture RightSelectedTexture;

	public UILabel RightSelectedTxt;

	public UIButton RightNormalBtn;

	public UILabel RightNormalTxt;

	public UILabel LeftSelectedTxt;

	public UILabel LeftNormalTxt;

	public UIButton LeftNormalBtn;

	public UIButton SkipBtn;

	public UILabel SkipBtnLabel;

	public GameObject Leftselected;

	public GameObject Right;

	public GameObject Rightselected;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
