using GCommon;
using UnityEngine;

namespace COW;

public class UITrainMapSlotItemView : UIBaseView
{
	public Transform BtnDownload;

	public UIColor DifficultyTag;

	public UILabel TitleLabel;

	public UIButton BtnClick;

	public UINetworkTexture CdnSlotIcon;

	public GameObject NotComplete;

	public GameObject HasComplete;

	public GameObject SelectedBorder;

	public UISprite BGSprite;

	public UILabel DifficultyLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
