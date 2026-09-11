using GCommon;
using UnityEngine;

namespace COW;

public class UIReportReplayItemView : UIBaseView
{
	public UILabel LabelDate;

	public UILabel LabelMatchId;

	public UILabel LabelMode;

	public UIButton BtnPlay;

	public UIButton BtnUpload;

	public UILabel LabelHour;

	public UIButton BtnNext;

	public UILabel MainReason;

	public UILabel SubReason;

	public UILabel OffenderName;

	public UILabel OffenderUID;

	public UIButton BtnPrev;

	public UISprite SpriteWait;

	public UILabel Duration;

	public GameObject ReviewStatus;

	public GameObject HackTag;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
