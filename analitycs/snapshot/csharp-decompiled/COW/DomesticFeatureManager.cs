using InterApp;
using proto;

namespace COW;

public abstract class DomesticFeatureManager
{
	private class Impl_Global : DomesticFeatureManager
	{
		private bool _CanBindToPlatform(PlatformType platformType)
		{
			return false;
		}

		public override bool CanSwapToPlatform(string swappingRegion, PlatformType platformType)
		{
			return false;
		}

		public override bool CanGuestBindToPlatform(PlatformType platformType)
		{
			return false;
		}

		public override bool CanLoginByPlatform(PlatformType platformType)
		{
			return false;
		}

		public override bool CanNonGuestBindToPlatform(PlatformType platformType)
		{
			return false;
		}

		public override bool CanUseSocialMediaPlatform(GalleryShow.SocialMediaType snsType)
		{
			return false;
		}

		public override bool CanUseSocialMediaPlatform(InterAppName appName)
		{
			return false;
		}

		protected override bool CanUseGooglePlayGamesServices()
		{
			return false;
		}

		protected override bool CanUseRecall_PlayGamesServices()
		{
			return false;
		}

		protected override bool CanUseAchievements_PlayGamesServices()
		{
			return false;
		}

		protected override bool CanUseServersideAccess_PlayGamesServices()
		{
			return false;
		}

		public override string ClientIdForServer_PlayGamesServices()
		{
			return null;
		}

		public override bool CanUseAppleGameCenter()
		{
			return false;
		}
	}

	private class Impl_India : DomesticFeatureManager
	{
		private bool _CanAuthByPlatform(PlatformType platformType)
		{
			return false;
		}

		public override bool CanSwapToPlatform(string swappingRegion, PlatformType platformType)
		{
			return false;
		}

		public override bool CanGuestBindToPlatform(PlatformType platformType)
		{
			return false;
		}

		public override bool CanLoginByPlatform(PlatformType platformType)
		{
			return false;
		}

		public override bool CanNonGuestBindToPlatform(PlatformType platformType)
		{
			return false;
		}

		public override bool CanUseSocialMediaPlatform(GalleryShow.SocialMediaType snsType)
		{
			return false;
		}

		public override bool CanUseSocialMediaPlatform(InterAppName appName)
		{
			return false;
		}

		protected override bool CanUseGooglePlayGamesServices()
		{
			return false;
		}

		protected override bool CanUseRecall_PlayGamesServices()
		{
			return false;
		}

		protected override bool CanUseAchievements_PlayGamesServices()
		{
			return false;
		}

		protected override bool CanUseServersideAccess_PlayGamesServices()
		{
			return false;
		}

		public override string ClientIdForServer_PlayGamesServices()
		{
			return null;
		}

		public override bool CanUseAppleGameCenter()
		{
			return false;
		}
	}

	private class Impl_Vietnam : DomesticFeatureManager
	{
		public override bool CanSwapToPlatform(string swappingRegion, PlatformType platformType)
		{
			return false;
		}

		public override bool CanGuestBindToPlatform(PlatformType platformType)
		{
			return false;
		}

		public override bool CanLoginByPlatform(PlatformType platformType)
		{
			return false;
		}

		public override bool CanNonGuestBindToPlatform(PlatformType platformType)
		{
			return false;
		}

		public override bool CanUseSocialMediaPlatform(GalleryShow.SocialMediaType snsType)
		{
			return false;
		}

		public override bool CanUseSocialMediaPlatform(InterAppName appName)
		{
			return false;
		}

		protected override bool CanUseGooglePlayGamesServices()
		{
			return false;
		}

		protected override bool CanUseRecall_PlayGamesServices()
		{
			return false;
		}

		protected override bool CanUseAchievements_PlayGamesServices()
		{
			return false;
		}

		protected override bool CanUseServersideAccess_PlayGamesServices()
		{
			return false;
		}

		public override string ClientIdForServer_PlayGamesServices()
		{
			return null;
		}

		public override bool CanUseAppleGameCenter()
		{
			return false;
		}
	}

	private static DomesticFeatureManager _I;

	public static DomesticFeatureManager I => null;

	protected static bool IsOfRegionOrCountry(string region, string country, string accountRegion = "")
	{
		return false;
	}

	public virtual string GetAppCalendarName()
	{
		return null;
	}

	public abstract bool CanSwapToPlatform(string swappingRegion, PlatformType platformType);

	public abstract bool CanGuestBindToPlatform(PlatformType platformType);

	public abstract bool CanNonGuestBindToPlatform(PlatformType platformType);

	public abstract bool CanLoginByPlatform(PlatformType platformType);

	public abstract bool CanUseSocialMediaPlatform(GalleryShow.SocialMediaType snsType);

	public abstract bool CanUseSocialMediaPlatform(InterAppName appName);

	protected abstract bool CanUseGooglePlayGamesServices();

	public bool UsePlayGamesServices()
	{
		return false;
	}

	public bool UseRecall_PlayGamesServices()
	{
		return false;
	}

	public bool UseAchievements_PlayGamesServices()
	{
		return false;
	}

	public bool UseServersideAccess_PlayGamesServices()
	{
		return false;
	}

	protected abstract bool CanUseRecall_PlayGamesServices();

	protected abstract bool CanUseAchievements_PlayGamesServices();

	protected abstract bool CanUseServersideAccess_PlayGamesServices();

	public abstract string ClientIdForServer_PlayGamesServices();

	public abstract bool CanUseAppleGameCenter();
}
