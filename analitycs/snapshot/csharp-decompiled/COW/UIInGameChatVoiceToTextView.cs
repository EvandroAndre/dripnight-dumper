using GCommon;
using UnityEngine;

namespace COW;

public class UIInGameChatVoiceToTextView : UIBaseView
{
	public GameObject RecordContainer;

	public UIProgressBar RecordProgress;

	public UILabel RecordCountDown;

	public UIButton ConvertBtn;

	public GameObject EnableMask;

	public GameObject LabelConvert;

	public GameObject Converting;

	public UIButton CancelBtn;

	public GameObject ErrorContainer;

	public GameObject DisableMask;

	public GameObject ProcessingContainer;

	public UILabel ErrorLabel;

	public UISprite ForeGround;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
