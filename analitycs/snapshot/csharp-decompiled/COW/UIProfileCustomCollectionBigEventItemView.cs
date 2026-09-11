using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomCollectionBigEventItemView : UIBaseView
{
	public UIButton Button;

	public ProfileCustomDragDropItem DragItem;

	public UIButton RemoveBtn;

	public GameObject Selected;

	public GameObject Icon;

	public UITable TableContainer;

	public UINetworkTexture FrameCDN;

	public UISprite Background;

	public UILabel EventGalleryLabel;

	public UILabel CollectionNum;

	public GameObject Line;

	public UIButton BigEventPreviewBtn;

	public UINetworkTexture BigEventCDN;

	public UINetworkTexture LogoCDN;

	public UIButton EditBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
