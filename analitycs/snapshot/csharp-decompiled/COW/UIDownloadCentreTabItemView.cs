using GCommon;
using UnityEngine;

namespace COW;

public class UIDownloadCentreTabItemView : UIBaseView
{
	public UILabel TitleLabel;

	public UIButton RewardBtn;

	public UISprite RewardIcon;

	public UILabel ProgressLabel;

	public UIButton DownloadBtn;

	public UISprite FinishIcon;

	public UIButton InpendingBtn;

	public UIButton DownloadIngBtn;

	public UISprite DownloadingProgressBar;

	public GameObject Select;

	public UIButton TabBtn;

	public UISprite PendingIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
