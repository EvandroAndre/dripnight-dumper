using GCommon;
using UnityEngine;

namespace COW;

public class UIDebugJiraView : UIBaseView
{
	public GameObject UIDebugJira;

	public UIButton Close;

	public UIInput InputAccountName;

	public UIInput InputPassword;

	public UIButton CreateIssue;

	public UIButton CaptureScreenshot;

	public UIButton RecordBtn;

	public UIInput InputRecordSeconds;

	public UIButton UploadPicture;

	public UIButton UploadDebugLog;

	public UIButton UploadVideo;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
