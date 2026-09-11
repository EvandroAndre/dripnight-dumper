using GCommon;
using UnityEngine;

namespace COW;

public class UIHyperBookContentPageItemView : UIBaseView
{
	public GameObject PageProgressGO;

	public UISlider PageProgressSlider;

	public UISprite PageCollectionBG;

	public BaseItemView2 PageCollectionItemView;

	public UILabel PageIdxLabel;

	public GameObject PageSelecedFrameIcon;

	public GameObject PageLockedIcon;

	public GameObject PageTipsIcon;

	public UIButton SelectBtn;

	public GameObject ProgressSliderBgVFX;

	public UISprite PageCollectionIcon;

	public GameObject HiddenPageHeadBubble;

	public UILabel PageHeadLable;

	public GameObject HiddenPageVFXRoot;

	public GameObject PageCollectionBGMask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
