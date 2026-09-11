using System;
using GCommon;

namespace COW;

public class UISceneEditSettingInfoController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__13_0;

		public static Action _003C_003E9__13_2;

		internal void _003CInit_003Eb__13_0()
		{
		}

		internal void _003CInit_003Eb__13_2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public UISceneEditSettingInfoController _003C_003E4__this;

		public UIModelSceneEdit sceneEditModel;

		internal void _003CInit_003Eb__1()
		{
		}

		internal void _003CInit_003Eb__3()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public string key;

		internal void _003CCheckGuideSubscribeSetting_003Eb__0()
		{
		}
	}

	public static readonly string Key_GuideSubscribeSetting_Format;

	private static readonly string URL_SubscribeNotifyItemPic;

	private static readonly string URL_IND_SubscribeNotifyItemPic;

	private static readonly string URL_MapAutoTranslateItemPic;

	private static readonly string URL_IND_MapAutoTranslateItemPic;

	private UISceneEditSettingInfoView m_View;

	private UISceneEditSettingItemController m_SubscribeNotifyItem;

	private UISceneEditSettingItemController m_MapAutoTranslateItem;

	private EventLogger.EventTypeUGCPlatformHomeSettingChange m_SettingLogger;

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

	private void Init()
	{
	}

	private void CheckGuideSubscribeSetting()
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
}
