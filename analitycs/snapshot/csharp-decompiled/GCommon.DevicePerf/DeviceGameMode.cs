using UnityEngine;

namespace GCommon.DevicePerf;

public static class DeviceGameMode
{
	public static class GameMode
	{
		public const int Unsupported = 0;

		public const int Standard = 1;

		public const int Performance = 2;

		public const int Battery = 3;

		public const int Custom = 4;
	}

	public static class GameState
	{
		public const int Unknown = 0;

		public const int None = 1;

		public const int GameplayInterruptible = 2;

		public const int GameplayUninterruptible = 3;

		public const int Content = 4;
	}

	public abstract class IDeviceGameMode
	{
		public virtual bool SupportGameModeRetrieving => false;

		public virtual bool SupportGameStateManeuvering => false;

		public virtual int RetrieveGameMode()
		{
			return 0;
		}

		public virtual void ManeuverGameState(bool isLoading, int state)
		{
		}

		public virtual void ManeuverGameState(bool isLoading, int state, int label, int quality)
		{
		}
	}

	private class DeviceGameMode_Default : IDeviceGameMode
	{
	}

	private class DeviceGameMode_Android : IDeviceGameMode
	{
		public static class GameState
		{
			public const int Unknown = 0;

			public const int None = 1;

			public const int GameplayInterruptible = 2;

			public const int GameplayUninterruptible = 3;

			public const int Content = 4;
		}

		private static AndroidJavaClass _GameModeManager;

		public static AndroidJavaClass GameModeManager => null;

		public override bool SupportGameModeRetrieving => false;

		public override bool SupportGameStateManeuvering => false;

		public override int RetrieveGameMode()
		{
			return 0;
		}

		public override void ManeuverGameState(bool isLoading, int state)
		{
		}

		public override void ManeuverGameState(bool isLoading, int state, int label, int quality)
		{
		}
	}

	private static IDeviceGameMode _DeviceGameMode;

	public static IDeviceGameMode Device => null;

	static DeviceGameMode()
	{
	}
}
