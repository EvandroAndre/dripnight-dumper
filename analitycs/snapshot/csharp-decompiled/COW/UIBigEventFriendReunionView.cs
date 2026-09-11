using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEventFriendReunionView : UIBaseView
{
	public UIScrollView ScrollView;

	public UITable ContentTable;

	public UIDragScrollView DragArea;

	public UINetworkTexture ADMini;

	public GameObject IntroBG;

	public UISprite IntroBGSprite;

	public UITable IntroRoot;

	public UILabel Introduction;

	public UILabel Time;

	public GameObject Progress;

	public UILabel ProgressNum;

	public UIProgressBar ProgressBar;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
