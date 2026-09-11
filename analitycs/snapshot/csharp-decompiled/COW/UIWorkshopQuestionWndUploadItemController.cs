using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIWorkshopQuestionWndUploadItemController : UIBaseController
{
	private enum EUploadItemState
	{
		Empty,
		Loading,
		Filled,
		Error
	}

	private const string LOC_KEY_ERR_FILE_SIZE = "T_54_GT_UGC_FEEDBACK_ERROR_FILE_SIZE";

	private UIWorkshopQuestionWndUploadItemView m_View;

	private UIModelSceneEdit m_Model;

	private EUploadItemState m_State;

	private string m_DownloadUrl;

	private byte[] m_PendingBytes;

	private Texture2D m_ThumbnailTex;

	private bool m_Aborted;

	private Action<UIWorkshopQuestionWndUploadItemController> m_OnStateChanged;

	private Action<UIWorkshopQuestionWndUploadItemController> m_OnRequestDelete;

	public bool HasUploadedContent => false;

	public bool IsPendingOrFailed => false;

	public bool IsUploadLoading => false;

	public event Action<UIWorkshopQuestionWndUploadItemController> OnStateChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<UIWorkshopQuestionWndUploadItemController> OnRequestDelete
	{
		add
		{
		}
		remove
		{
		}
	}

	public string GetDownloadUrl()
	{
		return null;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnClickUpload()
	{
	}

	private void OnPickedImage(string path)
	{
	}

	private static bool IsPickedImageTypeAllowedByFeedbackFormat(UIUtils.ImageType imgType)
	{
		return false;
	}

	private void BeginUpload(byte[] bytes, string ext)
	{
	}

	private void OnUploadDone(bool success, string downloadUrl, string err)
	{
	}

	private void OnClickDelete()
	{
	}

	private void ApplyThumbnailFromPendingBytes()
	{
	}

	private void ReleaseThumbnail()
	{
	}

	private void SetState(EUploadItemState state)
	{
	}

	private void _003COnClickUpload_003Eb__25_0(string path)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
