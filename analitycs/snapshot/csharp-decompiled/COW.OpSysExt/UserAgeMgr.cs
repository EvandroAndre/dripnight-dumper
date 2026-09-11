using System;
using UnityEngine;

namespace COW.OpSysExt;

public class UserAgeMgr : OpSysExt
{
	public enum AgeStatus
	{
		Error = -1,
		Unlegislated,
		Unverified,
		Undisclosed,
		Minor_Approved,
		Minor_Pending,
		Minor_Denied,
		Adult,
		Ranged,
		Declared
	}

	public static class ErrorCode
	{
		public const string ANDROID_PLAY_STORE_NOT_FOUND = "ANDROID_PLAY_STORE_NOT_FOUND";

		public const string ANDROID_NETWORK_ERROR = "ANDROID_NETWORK_ERROR";

		public const string ANDROID_PLAY_SERVICES_NOT_FOUND = "ANDROID_PLAY_SERVICES_NOT_FOUND";

		public const string ANDROID_CANNOT_BIND_TO_SERVICE = "ANDROID_CANNOT_BIND_TO_SERVICE";

		public const string ANDROID_PLAY_STORE_VERSION_OUTDATED = "ANDROID_PLAY_STORE_VERSION_OUTDATED";

		public const string ANDROID_PLAY_SERVICES_VERSION_OUTDATED = "ANDROID_PLAY_SERVICES_VERSION_OUTDATED";

		public const string ANDROID_SDK_VERSION_OUTDATED = "ANDROID_SDK_VERSION_OUTDATED";

		public const string ANDROID_CLIENT_TRANSIENT_ERROR = "ANDROID_CLIENT_TRANSIENT_ERROR";

		public const string ANDROID_APP_NOT_OWNED = "ANDROID_APP_NOT_OWNED";

		public const string ANDROID_INTERNAL_ERROR = "ANDROID_INTERNAL_ERROR";

		public const string IOS_ROOT_VIEW_CONTROLLER_NOT_FOUND = "IOS_ROOT_VIEW_CONTROLLER_NOT_FOUND";

		public const string IOS_INVALID_REQUEST = "IOS_INVALID_REQUEST";

		public const string ANDROID_ACTIVITY_NULL = "ANDROID_ACTIVITY_NULL";

		public const string ANDROID_NULL_RESULT = "ANDROID_NULL_RESULT";

		public const string API_NOT_AVAILABLE = "API_NOT_AVAILABLE";

		public const string INTERNAL_ERROR = "INTERNAL_ERROR";

		public const string UNKNOWN_ERROR = "UNKNOWN_ERROR";

		public const string EXCEPTION = "EXCEPTION";
	}

	public class AgeRange
	{
		private int _003CMinAge_003Ek__BackingField;

		private int _003CMaxAge_003Ek__BackingField;

		public const int AGE_UNDEFINED = -1;

		public static readonly AgeRange KID;

		public static readonly AgeRange TEEN;

		public static readonly AgeRange MINOR;

		public static readonly AgeRange ADULT;

		public int MinAge
		{
			get
			{
				return _003CMinAge_003Ek__BackingField;
			}
			private set
			{
				_003CMinAge_003Ek__BackingField = value;
			}
		}

		public int MaxAge
		{
			get
			{
				return _003CMaxAge_003Ek__BackingField;
			}
			private set
			{
				_003CMaxAge_003Ek__BackingField = value;
			}
		}

		public AgeRange(int min, int max)
		{
		}

		public bool IsEmpty()
		{
			return false;
		}

		public bool WithinRange(AgeRange ageRange)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public string LogStr()
		{
			return null;
		}

		public string _003C_003EiFixBaseProxy_ToString()
		{
			return null;
		}
	}

	public class AgeResult
	{
		public class iOS_Details
		{
			public enum DeclaringEntity
			{
				Unknown,
				None,
				SelfDeclared,
				PaymentChecked,
				GovernmentIDChecked,
				CheckedByOtherMethod,
				GuardianDeclared,
				GuardianPaymentChecked,
				GuardianGovernmentIDChecked,
				GuardianCheckedByOtherMethod
			}

			public enum ParentalControlPolicy
			{
				CommunicationLimits = 1,
				SignificantAppChangeApprovalRequired
			}

			public DeclaringEntity DeclaredBy;

			public ParentalControlPolicy[] ParentalControls;
		}

		public class Android_Details
		{
			public string InstallID;

			public long MostRecentApprovalTimestamp;

			public bool IsRetryable;

			public DateTime? GetApprovalDateTime()
			{
				return null;
			}
		}

		public AgeStatus Status;

		public AgeRange AgeRange;

		public string ErrorCode;

		public string ErrorMessage;

		public Android_Details Android;
	}

	private class Impl_Android : UserAgeMgr
	{
		private class UserAgeMgrCallback : AndroidJavaProxy
		{
			private sealed class _003C_003Ec__DisplayClass2_0
			{
				public UserAgeMgrCallback _003C_003E4__this;

				public long id;

				public int status;

				public string installId;

				public string errorCode;

				public string errorMessage;

				public int minAge;

				public int maxAge;

				public long mostRecentApprovalTimestamp;

				internal void _003ConAgeVerificationResult_003Eb__0()
				{
				}
			}

			private Impl_Android _Mgr;

			public UserAgeMgrCallback(Impl_Android mgr)
				: base((string)null)
			{
			}

			public void onAgeVerificationResult(long id, int status, string installId, string errorCode, string errorMessage, int minAge, int maxAge, long mostRecentApprovalTimestamp)
			{
			}
		}

		private AndroidJavaClass _JavaClass;

		private UserAgeMgrCallback _Callback;

		private LongSeqPool<Action<AgeResult>> _AgeVerificationCallbacks;

		public override string UsingAPI => null;

		public override bool IsAvailable()
		{
			return false;
		}

		public override void RequestAgeVerification(Action<AgeResult> callback)
		{
		}

		private void OnAgeVerificationResult(long id, int status, string installId, string errorCode, string errorMessage, int minAge, int maxAge, long mostRecentApprovalTimestamp)
		{
		}

		public override void PrepareTestResult(AgeResult result)
		{
		}

		public string _003C_003EiFixBaseProxy_get_UsingAPI()
		{
			return null;
		}

		public bool _003C_003EiFixBaseProxy_IsAvailable()
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_RequestAgeVerification(Action<AgeResult> P0)
		{
		}

		public void _003C_003EiFixBaseProxy_PrepareTestResult(AgeResult P0)
		{
		}
	}

	private static UserAgeMgr _I;

	private static bool _TestMode;

	public static UserAgeMgr I => null;

	public static bool TestMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual string UsingAPI => null;

	public virtual int AdultAge => 0;

	protected UserAgeMgr()
	{
	}

	public static bool IsErrorRetryable(string errorCode)
	{
		return false;
	}

	public static bool RetryWithExpBackoff(string errorCode)
	{
		return false;
	}

	public virtual bool IsAvailable()
	{
		return false;
	}

	public virtual bool OverrideAdultAge(int age)
	{
		return false;
	}

	public virtual void RequestAgeVerification(Action<AgeResult> callback)
	{
	}

	public virtual void PrepareTestResult(AgeResult result)
	{
	}

	public virtual bool CanSetAgeGates()
	{
		return false;
	}

	public virtual void SetAgeGates(int[] ageGates)
	{
	}
}
