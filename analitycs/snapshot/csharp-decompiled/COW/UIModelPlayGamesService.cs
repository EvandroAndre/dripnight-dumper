using System;
using System.Collections.Generic;
using GCommon;
using GarenaMSDK;
using proto;
using tcp;

namespace COW;

public class UIModelPlayGamesService : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<SDKPGS.AchievementResult> _003C_003E9__24_0;

		public static Action<SDKPGS.AchievementResult> _003C_003E9__24_1;

		public static Action<SDKPGS.AchievementResult> _003C_003E9__26_0;

		public static Action<SDKPGS.AchievementResult> _003C_003E9__26_1;

		internal void _003CSyncAchievements_ServerToGooglePlay_003Eb__24_0(SDKPGS.AchievementResult result)
		{
		}

		internal void _003CSyncAchievements_ServerToGooglePlay_003Eb__24_1(SDKPGS.AchievementResult result)
		{
		}

		internal void _003CUpdateAchievements_ServerToGooglePlay_003Eb__26_0(SDKPGS.AchievementResult result)
		{
		}

		internal void _003CUpdateAchievements_ServerToGooglePlay_003Eb__26_1(SDKPGS.AchievementResult result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public UIModelLogin modelLogin;

		public Action onFinish;

		internal void _003CWriteSessionToPGS_003Eb__0(string str)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public Action<string> callback;

		public UIModelPlayGamesService _003C_003E4__this;

		public Action<GetCurrentPGSPlayerIdResult> _003C_003E9__1;

		internal void _003CUpdatePGSPlayerId_003Eb__0(string authState)
		{
		}

		internal void _003CUpdatePGSPlayerId_003Eb__1(GetCurrentPGSPlayerIdResult result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public Action onFinish;

		public UIModelPlayGamesService _003C_003E4__this;

		internal void _003CGetAuthCode_003Eb__0(RequestAuthCodePGSResult result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public Action onFinish;

		internal void _003CSendPGSAuthCode_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public CSGetGooglePlayAchievementsRes desc;

		public UIModelPlayGamesService _003C_003E4__this;

		internal void _003CGetAchievementsFromServer_003Eb__1(SDKPGS.LoadAchievementsResult result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public UIModelPlayGamesService _003C_003E4__this;

		public Action<SDKPGS.LoadAchievementsResult> callback;

		internal void _003CGetAchievementsFromGooglePlay_003Eb__0(SDKPGS.LoadAchievementsResult result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public UIModelPlayGamesService _003C_003E4__this;

		public GooglePlayAchievementUpdateNtf ntf;

		internal void _003COnAchievementsUpdate_Android_003Eb__0(string pgsPlayerId)
		{
		}
	}

	private string _003CPGSPlayerId_003Ek__BackingField;

	private Dictionary<string, SDKPGS.AchievementInfo> _AchievementsFromGooglePlay;

	public string PGSPlayerId
	{
		get
		{
			return _003CPGSPlayerId_003Ek__BackingField;
		}
		private set
		{
			_003CPGSPlayerId_003Ek__BackingField = value;
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public string GetPGSPlayerId()
	{
		return null;
	}

	public void AfterPlayerLogin()
	{
	}

	public void AfterPGSManualSignIn()
	{
	}

	public void OnAchievementsUpdate(GooglePlayAchievementUpdateNtf ntf)
	{
	}

	public void WriteSessionToPGS(Action onFinish = null)
	{
	}

	private void Logout_Android()
	{
	}

	private void AfterPlayerLogin_Android()
	{
	}

	private void AfterPGSManualSignIn_Android()
	{
	}

	private void UpdatePGSPlayerId(Action<string> callback)
	{
	}

	private void CheckServerPGSAuthStatus()
	{
	}

	private string _Mask(string input, int unmaskLength)
	{
		return null;
	}

	private string _MaskClientId(string clientId)
	{
		return null;
	}

	private void GetAuthCode(Action onFinish = null)
	{
	}

	private void SendPGSAuthCode(string authCode, Action onFinish = null)
	{
	}

	private void GetAchievementsFromServer()
	{
	}

	private void GetAchievementsFromGooglePlay(Action<SDKPGS.LoadAchievementsResult> callback)
	{
	}

	private void SyncAchievements_ServerToGooglePlay(List<CSGooglePlayAchievement> serverAchievements)
	{
	}

	private void OnAchievementsUpdate_Android(GooglePlayAchievementUpdateNtf ntf)
	{
	}

	private void UpdateAchievements_ServerToGooglePlay(GooglePlayAchievementUpdateNtf ntf)
	{
	}

	private void _003CAfterPlayerLogin_Android_003Eb__14_0(string pgsPlayerId)
	{
	}

	private void _003CAfterPGSManualSignIn_Android_003Eb__15_0(string pgsPlayerId)
	{
	}

	private void _003CCheckServerPGSAuthStatus_003Eb__17_0(HttpErrorCode err, object res)
	{
	}

	private void _003CGetAchievementsFromServer_003Eb__22_0(HttpErrorCode err, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
