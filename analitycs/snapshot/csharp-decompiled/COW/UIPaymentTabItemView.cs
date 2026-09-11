using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentTabItemView : UIBaseView
{
	public UIButton Button;

	public UISprite NoteSprite;

	public UILabel NoteLabel;

	public UISprite RedDot;

	public UILabel NormalLabel;

	public UIGrid SubTypeGrid;

	public GameObject SubTabArrow;

	public UISprite ArrowDown;

	public UISprite ArrowUp;

	public GameObject Selected;

	public UISprite SelectedSprite;

	public UILabel SelectedLabel;

	public GameObject UnFolded;

	public UILabel UnFoldedLabel;

	public UISprite SubTabBg;

	public Animation Anim;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
