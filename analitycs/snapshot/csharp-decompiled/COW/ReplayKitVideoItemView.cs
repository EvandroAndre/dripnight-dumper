using GCommon;
using UnityEngine;

namespace COW;

public class ReplayKitVideoItemView : UIBaseView
{
	public UITexture video;

	public UIButton delBtn;

	public UIButton PlayBtn;

	public UILabel duration;

	public UILabel memorySize;

	public UILabel time;

	public UILabel name;

	public GameObject Faultpicture;

	public GameObject HighlightLabelContainer;

	public UINetworkTexture HighlightCover;

	public UILabel HighlightLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
