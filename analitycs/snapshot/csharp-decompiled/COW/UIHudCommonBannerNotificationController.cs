using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCommonBannerNotificationController : UIBaseController, IScheduledNotification
{
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public UIHudCommonBannerNotificationViewData data;

		public UIHudCommonBannerNotificationController _003C_003E4__this;

		internal void _003CPlay_003Eb__0(uint uniqueID, ResourceID vfxResID, GameObject obj)
		{
		}
	}

	private UIHudCommonBannerNotificationView m_View;

	private UIHudCommonBannerNotificationViewData m_ViewData;

	private UIHudCommonBannerNotificationShowRefrence m_ShowRefrence;

	private uint m_ResUId;

	private string m_DefaultIconSprite;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void Finish(bool interrupted)
	{
	}

	public void Play(object viewData)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
