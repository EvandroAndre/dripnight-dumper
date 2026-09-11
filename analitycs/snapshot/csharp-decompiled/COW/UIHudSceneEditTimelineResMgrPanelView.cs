using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditTimelineResMgrPanelView : UIBaseView
{
	public TweenPosition TweenPos;

	public UITable Table;

	public Transform RecycleBin;

	public UIScrollView ScrollView;

	public UIPanel ScrollViewPanel;

	public UISprite DragFrame;

	public Transform SelectedFrame;

	public Transform SceneObjSortFliterMenu;

	public UIButton BtnClose;

	public UIButton FliterToggle;

	public GameObject FliterArrUp;

	public GameObject FliterArrDown;

	public Transform FliterPosition;

	public UIInput SearchInput;

	public UIButton BtnSearch;

	public UIButton BtnClear;

	public GameObject Empty;

	public UIPanel UIHudSceneEditTimelineResMgrPanel;

	public UIPanel EmptyNode;

	public UIButton BtnConfirm;

	public UIButton HintBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
