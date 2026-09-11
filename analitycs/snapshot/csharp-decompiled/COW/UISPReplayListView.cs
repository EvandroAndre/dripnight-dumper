using GCommon;
using UnityEngine;

namespace COW;

internal class UISPReplayListView : UIBaseView
{
	public GameObject Content;

	public UIScrollView ListScrollView;

	public UIEasyList ListGrid;

	public UILabel Result;

	public GameObject SearchBarContainer;

	public UIInput SearchInput;

	public UIButton SearchBtn;

	public UISprite SearchBtnSprite;

	public UIButton ClearBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
