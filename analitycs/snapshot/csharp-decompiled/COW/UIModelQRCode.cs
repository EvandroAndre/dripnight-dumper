using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIModelQRCode : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public UICommonCountDownBoxController ctrl;

		internal void _003CShowDenailTips_003Eb__0()
		{
		}

		internal void _003CShowDenailTips_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public QRCodeScanLogType type;

		public UIModelQRCode _003C_003E4__this;

		internal void _003CTryOpenScanWindow_003Eb__0(Dictionary<int, bool> requestResults)
		{
		}
	}

	private bool isCameraPermissionRequesting;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public Texture2D CreateQRCode(QRCodeType type, string deeplink)
	{
		return null;
	}

	public void ScanQRCode(QRCodeType type)
	{
	}

	public void TryOpenScanWindow(QRCodeScanLogType type)
	{
	}

	public bool ProcessScanResult(string deepLink, QRCodeScanLogType fromType = QRCodeScanLogType.None, uint isFromAlbum = 0u)
	{
		return false;
	}

	public bool ShowTipsForRoomInvite(ref string tips)
	{
		return false;
	}

	public string GenerateQRCodeNotifyDeepLink(QRCodeType type, string[] data)
	{
		return null;
	}

	public string GenerateQRCodeNotifyDeepLink(QRCodeType type, QRCodeGenerationChannel qRCodeGenerationChannel, string[] data)
	{
		return null;
	}

	private string MakeQRCodeUrl(string urlTemplate, QRCodeType type, string[] data, QRCodeGenerationChannel qRCodeGenerationChannel = QRCodeGenerationChannel.None)
	{
		return null;
	}

	private void ShowDenailTips()
	{
	}

	private GroupAndRoomState GetCurrentState()
	{
		return GroupAndRoomState.None;
	}

	private void OnQRCodeCheckVersionFailed()
	{
	}

	private bool OnQRCodeWillProcessFailed(string url)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
