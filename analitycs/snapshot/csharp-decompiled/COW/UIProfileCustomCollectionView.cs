using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomCollectionView : UIBaseView
{
	public UIEasyList EasyList;

	public UITable2 UITable2;

	public UIWidget DragCancelArea;

	public Transform PopMenuPos1;

	public Transform PopMenuPos2;

	public UIPanel ScrollView;

	public UISprite Bg;

	public UILabel TitleLabel;

	public UILabel EmptyLabel;

	public GameObject EmptyContainer;

	public Transform GuideRoot;

	public Transform LoadingPos;

	public UIButton ClanGotoButton;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
