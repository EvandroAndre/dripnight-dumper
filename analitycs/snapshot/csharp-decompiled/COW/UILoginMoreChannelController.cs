using System;
using GCommon;

namespace COW;

public class UILoginMoreChannelController : UIPopupWindowController
{
	private UILoginMoreChannelView m_View;

	public Action ActionVKClick;

	public Action ActionGoogleClick;

	public Action ActionFacebookClick;

	public Action ActionTwitterClick;

	public Action ActionGarenaClick;

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

	public void Init(bool hasShowVK, bool hasShowFacebook, bool hasShowGoogle, bool hasShowTwitter, bool hasShowGarena)
	{
	}

	private void OnVKClick()
	{
	}

	private void OnGoogleClick()
	{
	}

	private void OnFacebookClick()
	{
	}

	private void OnTwitterClick()
	{
	}

	private void OnGarenaClick()
	{
	}

	private void OnGarenaTipsClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
