using GCommon;
using UnityEngine;

namespace COW;

public class UIHudVoiceToTextView : UIBaseView
{
	public GameObject Top;

	public GameObject RecordingView;

	public GameObject DisPlayView;

	public UILabel DisplayLabel;

	public GameObject RecordingIconContainer;

	public UISprite CDProgress;

	public GameObject RecordingBtnGroup;

	public UIButton FinishRecordBtn;

	public GameObject DisplayBtnGroup;

	public UIButton RerecordBtn;

	public UIButton SendBtn;

	public GameObject SendBtnActive;

	public GameObject SendBtnGray;

	public UIButton CloseBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
