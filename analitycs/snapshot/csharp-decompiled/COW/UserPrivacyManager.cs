using System;

namespace COW;

public static class UserPrivacyManager
{
	public static class GoogleConsentMode
	{
		public enum UserApplicability
		{
			None,
			Optional,
			Enforced
		}

		[Serializable]
		public class UserConsents
		{
			public UserApplicability Applicability;

			public bool Analytics_Storage;

			public bool Ad_Storage;

			public bool Ad_UserData;

			public bool Ad_Personalization;

			private UserConsents()
			{
			}

			internal static UserConsents Instance(UserApplicability applicability, bool initConsent)
			{
				return null;
			}
		}

		private const string PLAYER_PREFS_KEY_CONSENTS_EU = "Consents_EU";

		public static UserConsents LocalSaved
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public static bool PerhapsApplyLocalRecord(Action callback = null)
		{
			return false;
		}

		public static void SetForInapplicableUser(Action callback = null)
		{
		}

		public static void SetForApplicableUser(UserConsents consents, Action callback = null)
		{
		}
	}
}
