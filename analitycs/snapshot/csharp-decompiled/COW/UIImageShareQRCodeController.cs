using GCommon;
using UnityEngine;

namespace COW;

public class UIImageShareQRCodeController : UIBaseController
{
	private UIImageShareQRCodeView m_View;

	private UIQRCodeController m_QRCodeCtrl;

	private UIModelUser m_ModelUser;

	private UIModelQRCode m_ModelQRCode;

	private uint m_CurQRCodeType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void CreateQRCode(Transform transform, Texture2D texture, int depth = 100)
	{
	}

	public void SetProfileData(int depth = 100, uint qrCodeType = 1u)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
