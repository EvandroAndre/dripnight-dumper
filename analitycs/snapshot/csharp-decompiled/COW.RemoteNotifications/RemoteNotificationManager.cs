using System.Collections.Generic;

namespace COW.RemoteNotifications;

public class RemoteNotificationManager
{
	public interface IRmtNtfObserver
	{
		void OnTokenReceived(string token);
	}

	private static RemoteNotificationManager _I;

	private string _003CToken_003Ek__BackingField;

	protected List<IRmtNtfObserver> _RmtNtfObserver;

	public static RemoteNotificationManager I => null;

	public virtual string Token
	{
		get
		{
			return _003CToken_003Ek__BackingField;
		}
		private set
		{
			_003CToken_003Ek__BackingField = value;
		}
	}

	protected RemoteNotificationManager()
	{
	}

	protected static void _Log(string log)
	{
	}

	protected static void _LogError(string log)
	{
	}

	internal static void Log(string log)
	{
	}

	public void RegisterObserver(IRmtNtfObserver observer)
	{
	}

	public void UnregisterObserver(IRmtNtfObserver observer)
	{
	}

	protected void NotifyObservers()
	{
	}

	public virtual void BeforeLoginSDK()
	{
	}

	public virtual void AfterLoginSDK()
	{
	}

	public virtual void BeforeLoginServer()
	{
	}

	public virtual void AfterLoginServer()
	{
	}

	public virtual void BeforeLogoutServer()
	{
	}

	public virtual void AfterLogoutServer()
	{
	}

	public virtual void BeforeLogoutSDK()
	{
	}

	public virtual void AfterLogoutSDK()
	{
	}

	public virtual void BeforeChangeLanguage()
	{
	}

	public virtual void AfterChangeLanguage()
	{
	}

	public virtual void BeforeChangeFirstTimePaid()
	{
	}

	public virtual void AfterChangeFirstTimePaid()
	{
	}

	public virtual void BeforeChangeClanID()
	{
	}

	public virtual void AfterChangeClanID()
	{
	}

	public virtual void BeforeChangeElitePassBadgeNumber()
	{
	}

	public virtual void AfterChangeElitePassBadgeNumber()
	{
	}

	public virtual void BeforeChangePlayerLevel()
	{
	}

	public virtual void AfterChangePlayerLevel()
	{
	}

	public virtual void BeforeChangeGamesPlayedInRankedMatch()
	{
	}

	public virtual void AfterChangeGamesPlayedInRankedMatch()
	{
	}

	public virtual void OnEnterGame()
	{
	}

	public virtual void OnLeaveGame()
	{
	}

	public virtual void CheckAndLogRecvedNtfs(bool shouldClearNtfs, out bool willClearNtfs)
	{
		willClearNtfs = default(bool);
	}

	private void _003CNotifyObservers_003Eb__15_0()
	{
	}
}
