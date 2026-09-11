using GCommon;
using UnityEngine;

namespace COW;

public class UIBlackListView : UIBaseView
{
	public Transform LeftContainer;

	public UIGrid TabGrid;

	public UIButton MatchMakingBLToggle;

	public GameObject MatchMakingBLLabel;

	public GameObject MatchMakingBLUnSelected;

	public GameObject MatchMakingBLSelected;

	public UIButton ApplicationBLToggle;

	public GameObject ApplicationBLLabel;

	public GameObject ApplicationBLUnSelected;

	public GameObject ApplicationBLSelected;

	public UIScrollView BlackListScrollView;

	public UIEasyList BlackList;

	public UILabel EmptyHint;

	public UIButton ChatBLToggle;

	public GameObject ChatBLLabel;

	public GameObject ChatBLUnSelected;

	public GameObject ChatBLSelected;

	public UILabel MaxCntLabel;

	public UILabel BlackListTimeLabel;

	public UILabel TimeNotationLabel;

	public UILabel PrimeMaxCntAdditionalLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
