using GCommon;
using UnityEngine;

namespace COW;

public class UIDownloadCentreSimpleItemView : UIBaseView
{
	public UISprite Icon;

	public UILabel Title;

	public UIButton RewardBtn;

	public UISprite RewardIcon;

	public GameObject RewardEffect;

	public UISprite ProgressBar;

	public UILabel ProgressLabel;

	public UIButton DownloadBtn;

	public UIButton InPendingBtn;

	public UIButton PauseBtn;

	public GameObject FinishedIcon;

	public UISprite RecommendTagTip;

	public UILabel RewardNum;

	public GameObject DownloadIngEffect;

	public UIButton RewardTips;

	public GameObject DownloadState;

	public GameObject DeleteState;

	public UIToggle DeleteToggle;

	public UILabel StorageLabel;

	public GameObject Mask;

	public BoxCollider Container;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
