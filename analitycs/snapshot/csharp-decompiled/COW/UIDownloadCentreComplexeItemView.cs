using GCommon;
using UnityEngine;

namespace COW;

public class UIDownloadCentreComplexeItemView : UIBaseView
{
	public UINetworkTexture CDNSprite;

	public UILabel Desc;

	public UILabel Title;

	public UILabel ProgressLabel;

	public UISprite ProgressBar;

	public UIButton InPendingBtn;

	public UIButton DownloadBtn;

	public UIButton pauseBtn;

	public UIButton ActivityBtn;

	public UISprite ActivityIcon;

	public GameObject ActivityEffect;

	public UILabel ActivityNum;

	public GameObject DownloadIngEffect;

	public GameObject ProgressBarBack;

	public GameObject DownloadState;

	public GameObject DeleteState;

	public UIToggle DeleteToggle;

	public UIButton RewardTips;

	public GameObject FinishIcon;

	public GameObject RecommendTips;

	public UILabel DeleteStroage;

	public GameObject Mask;

	public BoxCollider Container;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
