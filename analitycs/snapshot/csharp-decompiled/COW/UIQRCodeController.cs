using GCommon;
using UnityEngine;

namespace COW;

public class UIQRCodeController : UIBaseController
{
	private UIQRCodeView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetQRCodeData(Texture2D codeData)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetSize(int w, int h)
	{
	}

	public void SetQRCodeDepth(int depth)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
