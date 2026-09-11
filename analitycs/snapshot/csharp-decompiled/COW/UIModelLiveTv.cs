using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelLiveTv : UIBaseModel
{
	private class LiveTvVersion
	{
		public Dictionary<string, string> data;
	}

	private enum LiveType
	{
		LiveTVReqPointWebRequest = 9999,
		LiveTV = 1,
		BooyahTV = 2,
		Tournament = 3
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<LiveDesc> _003C_003E9__17_0;

		public static Predicate<LiveDesc> _003C_003E9__18_0;

		public static Predicate<LiveDesc> _003C_003E9__19_0;

		public static Predicate<LiveDesc> _003C_003E9__20_0;

		public static Predicate<LiveDesc> _003C_003E9__21_0;

		public static Predicate<LiveDesc> _003C_003E9__22_0;

		public static Predicate<LiveDesc> _003C_003E9__23_0;

		internal bool _003CTournamentURL_003Eb__17_0(LiveDesc x)
		{
			return false;
		}

		internal bool _003CLiveTVURL_003Eb__18_0(LiveDesc x)
		{
			return false;
		}

		internal bool _003CBooyahTVURL_003Eb__19_0(LiveDesc x)
		{
			return false;
		}

		internal bool _003CLiveTVReqPointWebRequestURL_003Eb__20_0(LiveDesc x)
		{
			return false;
		}

		internal bool _003CTournamentTabName_003Eb__21_0(LiveDesc x)
		{
			return false;
		}

		internal bool _003CLiveTabName_003Eb__22_0(LiveDesc x)
		{
			return false;
		}

		internal bool _003CBooyahTabName_003Eb__23_0(LiveDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public ETournamentWebLink type;

		internal bool _003CGetTournamentWebLink_003Eb__0(EsportsWebLinkDesc desc)
		{
			return false;
		}
	}

	private List<LiveDesc> m_TabDesc;

	private static string m_LiveTVLobbyRedTipsVerID;

	private bool m_HasRequested;

	private int m_Version;

	public static string HAS_ENTERED_LIVETV_KEY;

	private int m_NowLivingStartTime;

	private List<EsportsWebLinkDesc> m_EsportsWebLinkDescs;

	public int NowLivingStartTime => 0;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public void ProcessTabDesc(CSGetLiveDescRes live_desc)
	{
	}

	public void ProcessEsportsWebLinkDesc(List<EsportsWebLinkDesc> esportsWebLinkDescs)
	{
	}

	public bool IsNowLiving()
	{
		return false;
	}

	public string GetTournamentWebLink(ETournamentWebLink type)
	{
		return null;
	}

	public string TournamentURL()
	{
		return null;
	}

	public string LiveTVURL()
	{
		return null;
	}

	public string BooyahTVURL()
	{
		return null;
	}

	public string LiveTVReqPointWebRequestURL()
	{
		return null;
	}

	public string TournamentTabName()
	{
		return null;
	}

	public string LiveTabName()
	{
		return null;
	}

	public string BooyahTabName()
	{
		return null;
	}

	public void LiveTvRedTip(int version)
	{
	}

	public void RequesetLiveTvVersion()
	{
	}

	private void _003CRequesetLiveTvVersion_003Eb__25_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
