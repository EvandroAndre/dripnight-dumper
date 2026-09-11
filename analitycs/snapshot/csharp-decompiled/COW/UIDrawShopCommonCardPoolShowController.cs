using GCommon;
using UnityEngine;

namespace COW;

public class UIDrawShopCommonCardPoolShowController : UIBaseController
{
	private UIDrawShopCommonCardPoolShowView m_View;

	private string m_CurrentShowClipName;

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

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData()
	{
	}

	public virtual void PlaySingleShow()
	{
	}

	public virtual void PlayMultiShow()
	{
	}

	public virtual void SkipShowAnimation()
	{
	}

	protected virtual Animation GetShowAnimation()
	{
		return null;
	}

	protected virtual string GetSingleShowClipName()
	{
		return null;
	}

	protected virtual string GetMultiShowClipName()
	{
		return null;
	}

	protected void PlayShowAnimation(string clipName)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
