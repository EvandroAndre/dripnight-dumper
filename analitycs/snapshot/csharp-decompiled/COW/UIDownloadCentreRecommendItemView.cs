using GCommon;
using UnityEngine;

namespace COW;

public class UIDownloadCentreRecommendItemView : UIBaseView
{
	public GameObject UIDownloadCentreRecommendItem;

	public UILabel Title;

	public UILabel Desc;

	public UINetworkTexture CDNTexture;

	public UILabel StorageLabel;

	public UIToggle DeleteToggle;

	public GameObject DeleteContainer;

	public GameObject DownloadContainer;

	public UIButton WaitForDownloadIcon;

	public UISprite RewardIcon;

	public GameObject DownloadFinished;

	public UIButton Downloading;

	public UISprite DownloadingBar;

	public UILabel DownloadProgressLabel;

	public UIButton RewardBtn;

	public UIButton DownloadInQueueBtn;

	public GameObject Mask;

	public UILabel RewardNum;

	public UILabel DetailLabel;

	public UIButton ReturnToCommonBtn;

	public UIButton DetailBtn;

	public GameObject DetailContainer;

	public TweenAlpha MaskAlpha;

	public TweenScale MaskScale;

	public TweenAlpha LabelScrollView;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
