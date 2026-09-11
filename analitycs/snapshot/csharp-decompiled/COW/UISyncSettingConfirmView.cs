using GCommon;
using UnityEngine;

namespace COW;

public class UISyncSettingConfirmView : UIBaseView
{
	public GameObject UploadCoverContainer;

	public UIButton BtnUploadCoverConfirm;

	public UIButton BtnUploadCoverCancel;

	public GameObject DownloadCoverContainer;

	public UIButton BtnDownloadCoverConfirm;

	public UIButton BtnDownloadCoverCancel;

	public GameObject DownloadNotFoundContainer;

	public UIButton BtnDownloadNotFoundConfirm;

	public GameObject ConflictResloveContainer;

	public UIButton BtnConflictUpload;

	public UIButton BtnConflictDownload;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
