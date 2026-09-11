using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UISoundSettingController : UISettingContentBase
{
	private enum SoundSettingKey
	{
		Music,
		SoundEffect,
		KillSoundEffect,
		GameVoice,
		PCFireSound,
		PCAchievementSound,
		SpecialCharacterVoice,
		GameVoiceVolumeBalance,
		GameVoiceVolumeBalanceOpenMode,
		GameVoiceBackground,
		MagicVoice,
		PressedVoiceOpen,
		PressedVoiceIsAll,
		MuteNonPreMatchTeammate,
		EmoteOnly1PAudio
	}

	private enum SettingBlock
	{
		Sound,
		Voice
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<float> _003C_003E9__12_0;

		public static Action<float> _003C_003E9__13_0;

		public static Action<float> _003C_003E9__14_0;

		public static Action<float> _003C_003E9__15_0;

		public static Func<int> _003C_003E9__16_1;

		public static Func<int> _003C_003E9__17_0;

		public static Func<int> _003C_003E9__19_1;

		public static Func<float> _003C_003E9__21_0;

		public static Action<float> _003C_003E9__21_1;

		public static Func<int> _003C_003E9__23_0;

		public static Action _003C_003E9__23_3;

		public static Action _003C_003E9__23_6;

		public static Func<int> _003C_003E9__25_0;

		public static Action _003C_003E9__27_0;

		public static Action _003C_003E9__27_1;

		public static Func<int> _003C_003E9__30_0;

		internal void _003CCreateMusicData_003Eb__12_0(float value)
		{
		}

		internal void _003CCreateSoundEffectData_003Eb__13_0(float value)
		{
		}

		internal void _003CCreateKillSoundEffectData_003Eb__14_0(float value)
		{
		}

		internal void _003CCreateGameVoiceData_003Eb__15_0(float value)
		{
		}

		internal int _003CCreatePressedVoiceBlockData_003Eb__16_1()
		{
			return 0;
		}

		internal int _003CCreatePressedVoiceIsAllBlockData_003Eb__17_0()
		{
			return 0;
		}

		internal int _003CCreateGameVoiceVolumeBalanceData_003Eb__19_1()
		{
			return 0;
		}

		internal float _003CCreateGameVoiceVolumeBalanceOpenModeData_003Eb__21_0()
		{
			return 0f;
		}

		internal void _003CCreateGameVoiceVolumeBalanceOpenModeData_003Eb__21_1(float value)
		{
		}

		internal int _003CCreateGameVoiceBackgroundData_003Eb__23_0()
		{
			return 0;
		}

		internal void _003CCreateGameVoiceBackgroundData_003Eb__23_3()
		{
		}

		internal void _003CCreateGameVoiceBackgroundData_003Eb__23_6()
		{
		}

		internal int _003CCreateMuteNonPreMatchTeammateData_003Eb__25_0()
		{
			return 0;
		}

		internal void _003CCreateSpecialCharacterVoiceData_003Eb__27_0()
		{
		}

		internal void _003CCreateSpecialCharacterVoiceData_003Eb__27_1()
		{
		}

		internal int _003CCreateEmoteOnly1PAudioData_003Eb__30_0()
		{
			return 0;
		}
	}

	private UISoundSettingView m_View;

	private Dictionary<int, UICommonSettingContentController> m_CtrlDict;

	private Dictionary<int, CommonSettingContentData> m_DataDict;

	public override void RefreshContent(object[] param)
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Start()
	{
	}

	private void ResetScrollViewWidth()
	{
	}

	private CommonSettingContentData CreateSoundBlockData()
	{
		return null;
	}

	private CommonSettingContentData CreateVoiceBlockData()
	{
		return null;
	}

	private CommonSettingItemDataSlider CreateMusicData()
	{
		return null;
	}

	private CommonSettingItemDataSlider CreateSoundEffectData()
	{
		return null;
	}

	private CommonSettingItemDataSlider CreateKillSoundEffectData()
	{
		return null;
	}

	private CommonSettingItemDataSlider CreateGameVoiceData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreatePressedVoiceBlockData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreatePressedVoiceIsAllBlockData()
	{
		return null;
	}

	private void OnPressedVoiceClick(bool isEnable)
	{
	}

	private CommonSettingItemDataToggleBtns CreateGameVoiceVolumeBalanceData()
	{
		return null;
	}

	private void OnVolumeBalanceClick(bool isEnable)
	{
	}

	private CommonSettingItemDataSlider CreateGameVoiceVolumeBalanceOpenModeData()
	{
		return null;
	}

	private void ShowSoundSettingTips(string shownStr)
	{
	}

	private CommonSettingItemDataToggleBtns CreateGameVoiceBackgroundData()
	{
		return null;
	}

	private CommonSettingItemMagicVoiceData CreateMagicVoiceData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateMuteNonPreMatchTeammateData()
	{
		return null;
	}

	private static void EnsureGameVoiceVolumeBalanceVaild()
	{
	}

	private CommonSettingItemDataToggleBtns CreateSpecialCharacterVoiceData()
	{
		return null;
	}

	public static void OnSpecialCharacterVoiceSwitchClick(bool enable)
	{
	}

	private int SetSpecialCharacterVoiceSetting()
	{
		return 0;
	}

	private CommonSettingItemDataToggleBtns CreateEmoteOnly1PAudioData()
	{
		return null;
	}

	private void RefreshBtnsState()
	{
	}

	private void OpenQuickMsg()
	{
	}

	private void RefreshMsgSettingEntryRedTips(uint groupId)
	{
	}

	private float SliderMinusValue()
	{
		return 0f;
	}

	private float SliderAddValue()
	{
		return 0f;
	}

	public void ScrollLastPos()
	{
	}

	private void _003COnUIInit_003Eb__7_0()
	{
	}

	private void _003CCreatePressedVoiceBlockData_003Eb__16_0()
	{
	}

	private void _003CCreatePressedVoiceBlockData_003Eb__16_2()
	{
	}

	private void _003CCreatePressedVoiceBlockData_003Eb__16_3()
	{
	}

	private void _003CCreatePressedVoiceIsAllBlockData_003Eb__17_1()
	{
	}

	private void _003CCreatePressedVoiceIsAllBlockData_003Eb__17_2()
	{
	}

	private void _003CCreateGameVoiceVolumeBalanceData_003Eb__19_0()
	{
	}

	private void _003CCreateGameVoiceVolumeBalanceData_003Eb__19_2()
	{
	}

	private void _003CCreateGameVoiceVolumeBalanceData_003Eb__19_3()
	{
	}

	private void _003CCreateGameVoiceVolumeBalanceOpenModeData_003Eb__21_2()
	{
	}

	private void _003CCreateGameVoiceBackgroundData_003Eb__23_1()
	{
	}

	private void _003CCreateGameVoiceBackgroundData_003Eb__23_2()
	{
	}

	private void _003CCreateGameVoiceBackgroundData_003Eb__23_4()
	{
	}

	private void _003CCreateGameVoiceBackgroundData_003Eb__23_5()
	{
	}

	private void _003CCreateMagicVoiceData_003Eb__24_0()
	{
	}

	private void _003CCreateMuteNonPreMatchTeammateData_003Eb__25_1()
	{
	}

	private void _003CCreateMuteNonPreMatchTeammateData_003Eb__25_2()
	{
	}

	private void _003CCreateEmoteOnly1PAudioData_003Eb__30_1()
	{
	}

	private void _003CCreateEmoteOnly1PAudioData_003Eb__30_2()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent(object[] P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
