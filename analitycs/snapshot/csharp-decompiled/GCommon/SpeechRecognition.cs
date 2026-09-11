using System;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class SpeechRecognition
{
	public interface ISpeechRecognitionObserver
	{
		void OnAuthorizationResponse(bool? result);

		void OnRecordedAndRecognizedText(bool isFinal, string[] matches);

		void OnReadyToRecordAndRecognize();

		void OnDictationBreak();

		void OnError(string error, bool shouldForceStop);

		void OnGetAvailableLanguages(string error, LanguageStatus languageStatus);
	}

	public class LanguageStatus
	{
		public string[] Availables;

		public string[] Availables_Online;

		public string[] Availables_Installed;

		public string[] Unavailables_Installable;

		public string[] Unavailables_Installing;
	}

	public class Impl : MonoBehaviour
	{
		private bool _003CDictationMode_003Ek__BackingField;

		private bool _003CPreferOffline_003Ek__BackingField;

		private bool _003CEnforceOnDevice_003Ek__BackingField;

		private bool _003CReportPartialResults_003Ek__BackingField;

		private bool _003CDebug_003Ek__BackingField;

		public virtual bool ShouldWaitForReady => false;

		public virtual bool AutoRestart
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual bool MaximizeStandby
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual bool CanChangeDictationMode => false;

		public virtual bool DictationMode
		{
			get
			{
				return _003CDictationMode_003Ek__BackingField;
			}
			set
			{
				_003CDictationMode_003Ek__BackingField = value;
			}
		}

		public virtual bool CanChangePreferOffline => false;

		public virtual bool PreferOffline
		{
			get
			{
				return _003CPreferOffline_003Ek__BackingField;
			}
			set
			{
				_003CPreferOffline_003Ek__BackingField = value;
			}
		}

		public virtual bool CanEnforceOnDevice => false;

		public virtual bool EnforceOnDevice
		{
			get
			{
				return _003CEnforceOnDevice_003Ek__BackingField;
			}
			set
			{
				_003CEnforceOnDevice_003Ek__BackingField = value;
			}
		}

		public virtual bool ReportPartialResults
		{
			get
			{
				return _003CReportPartialResults_003Ek__BackingField;
			}
			set
			{
				_003CReportPartialResults_003Ek__BackingField = value;
			}
		}

		public virtual bool Debug
		{
			get
			{
				return _003CDebug_003Ek__BackingField;
			}
			set
			{
				_003CDebug_003Ek__BackingField = value;
			}
		}

		public virtual bool CanInstallLanguages => false;

		public virtual bool WillReportDuringLanguageInstalls => false;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public virtual bool SupportRecordAndRecognize()
		{
			return false;
		}

		public virtual bool CanCheckLanguageAvailability()
		{
			return false;
		}

		public virtual void SetForceStopOnErrors(string[] errors)
		{
		}

		public virtual bool RestartOnError(string error, bool restart)
		{
			return false;
		}

		public virtual bool GetAvailableLanguages()
		{
			return false;
		}

		public virtual bool InstallLanguage(string language)
		{
			return false;
		}

		protected virtual void SetUnitySendMessageGameObjectName(string name)
		{
		}

		public virtual bool? GetAuthStatus()
		{
			return null;
		}

		public virtual void RequestAuth()
		{
		}

		public virtual bool SetLocale(string locale)
		{
			return false;
		}

		public virtual bool IsRecordingAndRecognizing()
		{
			return false;
		}

		public virtual bool StartRecordingAndRecognizing()
		{
			return false;
		}

		public virtual bool StopRecordingAndRecognizing()
		{
			return false;
		}
	}

	private class Impl_Android : Impl
	{
		private static class Errors
		{
			public const int NetworkTimeout = 1;

			public const int Network = 2;

			public const int Audio = 3;

			public const int Server = 4;

			public const int Client = 5;

			public const int SpeechTimeout = 6;

			public const int NoMatch = 7;

			public const int RecognizerBusy = 8;

			public const int InsufficientPermissions = 9;

			public const int TooManyRequests = 10;

			public const int ServerDisconnected = 11;

			public const int LanguageNotSupported = 12;

			public const int LanguageUnavailable = 13;

			public const int CannotCheckSupport = 14;

			public const int CannotListenToDownloadEvents = 15;
		}

		[Serializable]
		private class CheckRecognitionSupportResult
		{
			public int Error;

			public string[] Online;

			public string[] SupportedOnDevice;

			public string[] InstalledOnDevice;

			public string[] PendingOnDevice;
		}

		[Serializable]
		private class GetLanguageDetailsResult
		{
			public string Error;

			public string Preferred;

			public string[] Supported;
		}

		[Serializable]
		private class RecognitionResults
		{
			public string[] Results;
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Converter<string, int> _003C_003E9__41_0;

			internal int _003CSetForceStopOnErrors_003Eb__41_0(string error)
			{
				return 0;
			}
		}

		private AndroidJavaClass I;

		private bool _DictationMode;

		private bool _AutoRestart;

		private bool _MaximizeStandby;

		private bool _PreferOffline;

		private bool _EnforceOnDevice;

		private bool _ReportPartialResults;

		private static readonly Dictionary<int, string> _ErrorCodeToMsgs;

		private int[] _ForceStopOnErrors;

		private bool _Debug;

		public override bool ShouldWaitForReady => false;

		public override bool CanChangeDictationMode => false;

		public override bool DictationMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool AutoRestart
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool MaximizeStandby
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool CanChangePreferOffline => false;

		public override bool PreferOffline
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool CanEnforceOnDevice => false;

		public override bool EnforceOnDevice
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool ReportPartialResults
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool Debug
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool CanInstallLanguages => false;

		public override bool WillReportDuringLanguageInstalls => false;

		public override bool SupportRecordAndRecognize()
		{
			return false;
		}

		protected override void SetUnitySendMessageGameObjectName(string name)
		{
		}

		public override bool? GetAuthStatus()
		{
			return null;
		}

		public override void RequestAuth()
		{
		}

		public override bool CanCheckLanguageAvailability()
		{
			return false;
		}

		public override void SetForceStopOnErrors(string[] errors)
		{
		}

		public override bool RestartOnError(string error, bool restart)
		{
			return false;
		}

		public override bool GetAvailableLanguages()
		{
			return false;
		}

		public void OnCheckRecognitionSupport(string data)
		{
		}

		public void OnGetLanguageDetails(string data)
		{
		}

		public override bool InstallLanguage(string language)
		{
			return false;
		}

		public override bool SetLocale(string locale)
		{
			return false;
		}

		public override bool IsRecordingAndRecognizing()
		{
			return false;
		}

		public override bool StartRecordingAndRecognizing()
		{
			return false;
		}

		public override bool StopRecordingAndRecognizing()
		{
			return false;
		}

		public void OnReadyForSpeech(string data)
		{
		}

		public void OnSpeechStarted(string data)
		{
		}

		public void OnSpeechStopped(string data)
		{
		}

		public void OnError(string data)
		{
		}

		public void OnResults(string data)
		{
		}

		public void OnPartialResults(string data)
		{
		}

		public void OnLanguageDetection(string language)
		{
		}

		public void OnEvent(string data)
		{
		}
	}

	private static Action<string, string[]> _Log;

	private static Action<string, string[]> _LogError;

	private static List<ISpeechRecognitionObserver> _Observers;

	private static Impl _I;

	public static Impl I => null;

	public static void SetLog(Action<string, string[]> log)
	{
	}

	public static void SetLogError(Action<string, string[]> log)
	{
	}

	protected static void Log(string format, string[] parameters)
	{
	}

	protected static void LogError(string format, string[] parameters)
	{
	}

	public static void Register(ISpeechRecognitionObserver observer)
	{
	}

	public static void Unregister(ISpeechRecognitionObserver observer)
	{
	}

	private static void _NotifyObservers_OnAuthorizationResponse(bool? result)
	{
	}

	private static void _NotifyObservers_OnGetAvailableLanguages(string error, LanguageStatus languageStatus)
	{
	}

	private static void _NotifyObservers_RecordedAndRecognized(bool isFinal, string[] matches)
	{
	}

	private static void _NotifyObservers_DictationBreak()
	{
	}

	private static void _NotifyObservers_OnReadyToRecordAndRecognize()
	{
	}

	private static void _NotifyObservers_OnError(string error, bool shouldForceStop)
	{
	}
}
