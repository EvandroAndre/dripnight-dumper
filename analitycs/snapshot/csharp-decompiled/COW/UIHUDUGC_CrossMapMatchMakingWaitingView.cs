using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_CrossMapMatchMakingWaitingView : UIBaseView
{
	public GameObject OtherViewContent;

	public UILabel OtherTime;

	public UIButton OtherCancelBtn;

	public UISprite OtherCancelBtnIcon;

	public UISprite OtherCancelBtnBG;

	public GameObject OtherEstimateContent;

	public UILabel EstimateNumber;

	public Transform DownloadContainer;

	public UILabel ProgressTxt;

	public GameObject Txt;

	public GameObject ReadyStatus;

	public GameObject CountDown;

	public GameObject NotAllReadyBG;

	public GameObject AllReadyBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
