using GCommon;
using UnityEngine;

namespace COW;

public class UIDownloadCentreSimpleDescItemView : UIBaseView
{
	public UISprite Icon;

	public UILabel Title;

	public UIButton RewardBtn;

	public UISprite RewardIcon;

	public GameObject RewardEffect;

	public UISprite ProgressBar;

	public UILabel ProgressLabel;

	public UIButton DownloadBtn;

	public UIButton PauseBtn;

	public GameObject FinishedIcon;

	public UILabel Desc;

	public UIButton InPendingBtn;

	public UISprite RecommendTips;

	public UILabel RewardNum;

	public GameObject DownloadIngEffect;

	public UIToggle DeleteToggle;

	public UILabel StorageLabel;

	public UIButton RewardTips;

	public GameObject DeleteState;

	public GameObject DownloadState;

	public GameObject Mask;

	public BoxCollider Container;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
