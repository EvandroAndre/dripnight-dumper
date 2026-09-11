using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class WebTutorialDataManager : SingletonModule<WebTutorialDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<CreditWebSwitchData> _003C_003E9__12_0;

		public static Predicate<WebTutorialData> _003C_003E9__18_2;

		public static Predicate<WebTutorialData> _003C_003E9__18_3;

		internal bool _003CGetCreditWebSwitch_003Eb__12_0(CreditWebSwitchData x)
		{
			return false;
		}

		internal bool _003CGetUGCTutorial_003Eb__18_2(WebTutorialData temp)
		{
			return false;
		}

		internal bool _003CGetUGCTutorial_003Eb__18_3(WebTutorialData temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public int id;

		internal bool _003CGetUGCTutorial_003Eb__0(WebTutorialData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_1
	{
		public string regionServer;

		internal bool _003CGetUGCTutorial_003Eb__1(WebTutorialData temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public int id;

		internal bool _003CGetUGCCreatorCenterURL_003Eb__0(WebTutorialData a)
		{
			return false;
		}
	}

	private Dictionary<int, List<WebTutorialData>> m_webTutorialDataDic;

	private bool m_CreditWebSwitchLoaded;

	private bool m_CreditWebSwitch;

	private string m_RegionName;

	public bool CreditWebSwitch => false;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public void LoadData()
	{
	}

	public void OnRegionChangeRefreshTutorialData()
	{
	}

	protected override void OnReloadMemory()
	{
	}

	protected override void OnUnloadMemeory()
	{
	}

	private bool GetCreditWebSwitch()
	{
		return false;
	}

	public string GetWebUrlByType(WebTutorialType type)
	{
		return null;
	}

	public string GetWebUrlByType(WebTutorialType type, int subType)
	{
		return null;
	}

	public string GetWebUrlByType(WebTutorialType type, int subType, int matchType)
	{
		return null;
	}

	public string GetUGCMapWithTemplateTutorial(int modeWithTemplate)
	{
		return null;
	}

	public string GetGameModeTutorial(int gameMode, int matchMode)
	{
		return null;
	}

	public string GetUGCTutorial(int id)
	{
		return null;
	}

	public string GetUGCCreatorCenterURL(int id)
	{
		return null;
	}

	public bool HasTutorialByType(int type)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnReloadMemory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUnloadMemeory()
	{
	}
}
