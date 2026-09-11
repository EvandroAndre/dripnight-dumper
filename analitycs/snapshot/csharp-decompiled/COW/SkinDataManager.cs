using System;
using GCommon;

namespace COW;

public class SkinDataManager : SingletonModule<SkinDataManager>
{
	public enum SkinType
	{
		Weapon,
		FistWeapon,
		BackPack,
		LootBox,
		Parachute,
		Skyboard,
		Flight,
		Vehicle,
		ActionCollection,
		Emote
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<DeviceWhiteListSpecialData> _003C_003E9__4_0;

		internal int _003COnInit_003Eb__4_0(DeviceWhiteListSpecialData a, DeviceWhiteListSpecialData b)
		{
			return 0;
		}
	}

	private DeviceWhiteListSpecialData m_matchingDeviceWhiteListSpecialData;

	public DeviceWhiteListSpecialData MatchingDeviceWhiteListSkinData => null;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public bool CheckApplySkinFlagByType(SkinType type)
	{
		return false;
	}
}
