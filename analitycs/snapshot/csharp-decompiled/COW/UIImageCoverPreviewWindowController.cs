using System;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIImageCoverPreviewWindowController : UIPopupWindowController
{
	public Action OnClose;

	public Action OnShareFunc;

	public Action<byte[]> OnSave;

	private UIImageCoverPreviewWindowView m_View;

	private const uint HEIGHTOFFSETINPORTRAIT = 24u;

	private int mCoverHeight;

	private int mCoverWidth;

	private HNDHJGJILHC mEditGame;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetImage(string filePath)
	{
	}

	public void OnCloseClick()
	{
	}

	public void OnSetAsCoverClick()
	{
	}

	public void OnShareClick()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
