using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIQRCodeScanWindowController : UIPopupWindowController, QRCodeMgr.IDecodeHandler
{
	private class CameraPermissionHandler : QRCodeMgr.PermissionHandler
	{
		public override bool? Check(bool request)
		{
			return null;
		}

		private void _003CCheck_003Eb__0_0(Dictionary<int, bool> requestResults)
		{
		}
	}

	private UIQRCodeScanWindowView m_View;

	private UIModelQRCode m_ModelQRCode;

	private QRCodeScanLogType m_FromType;

	private string m_CacheUrl;

	private bool m_IsNeedCloseDecoding;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnAlbumBtnClick()
	{
	}

	private void OnImageSelected(string path)
	{
	}

	private void ProcessImageBytes(byte[] bytes)
	{
	}

	private void ResumeDecodingIfNeeded()
	{
	}

	public void SetType(QRCodeScanLogType type)
	{
	}

	public override int MinGroupDepth()
	{
		return 0;
	}

	private void Update()
	{
	}

	void QRCodeMgr.IDecodeHandler.OnDecoding(Texture texture)
	{
	}

	bool QRCodeMgr.IDecodeHandler.OnDecoded(string text)
	{
		return false;
	}

	private bool ResultProcess(string result, bool isFromAlbum = false)
	{
		return false;
	}

	void QRCodeMgr.IDecodeHandler.OnTextureUVRectUpdated(Rect rect)
	{
	}

	private void RegisterUICameraCustomInput(UICamera.OnCustomInput handler)
	{
	}

	private void UnRegisterUICameraCustomInput(UICamera.OnCustomInput handler)
	{
	}

	private void OnUICameraCustomInput()
	{
	}

	private Vector2 ConvertToNormalizedCoord(Vector2 position)
	{
		return default(Vector2);
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public int _003C_003EiFixBaseProxy_MinGroupDepth()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
