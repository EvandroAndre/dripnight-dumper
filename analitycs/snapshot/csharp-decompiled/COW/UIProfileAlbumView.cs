using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileAlbumView : UIBaseView
{
	public GameObject Down;

	public UIButton BtnTips;

	public UILabel LblMemory;

	public UISprite IconMemory;

	public UISprite IconReplayMemory;

	public GameObject Empty;

	public GameObject Content;

	public UIEasyList AlbumEasyList;

	public GameObject DeleteContainer;

	public UIButton TrashBtn;

	public UIButton CancelBtn;

	public UIButton DeleteBtn;

	public UILabel DeleteLabel;

	public UILabel Label;

	public UISprite NoSelectSprite;

	public UISprite SelectSprite;

	public UIScrollView ScrollView;

	public UIToggleButtonGroup Toggle;

	public UIToggleButton NormalToggleBtn;

	public UIToggleButton HighlightToggleBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
