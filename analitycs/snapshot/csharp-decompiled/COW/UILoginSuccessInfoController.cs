using GCommon;
using UnityEngine;

namespace COW;

public class UILoginSuccessInfoController : UIBaseController
{
	private UILoginSuccessInfoView m_View;

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

	private void OnBtnStartGameClick()
	{
	}

	public void SetBtnStartGameActive(bool active, bool showLabel = true)
	{
	}

	private void OnLogoutBtnClick()
	{
	}

	public void SetCachedPlayerInfoActive(bool active)
	{
	}

	public void SetBtnLogoutActive(bool active)
	{
	}

	public void UpdateSetLogoutBtnSprite()
	{
	}

	public void SetLogoutBtnSprite(string spriteName, Color color, int width, int height, UIWidget.AspectRatioSource aspectRatioSource = UIWidget.AspectRatioSource.Free)
	{
	}

	public void RefreshPlayerInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
