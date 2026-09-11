using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIReplayKitSettingController : UISettingContentBase
{
	private enum SoundSettingKey
	{
		Replay,
		InGame,
		Lobby,
		Microphone,
		VideoQuality,
		HighLighRecordPermission,
		HighlightPhoto
	}

	private enum SettingBlock
	{
		Replay,
		Common,
		Microphone,
		VideoQuality,
		HighLighRecord
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__15_0;

		public static Action _003C_003E9__15_1;

		public static Action _003C_003E9__18_2;

		public static Action _003C_003E9__20_2;

		public static Action _003C_003E9__23_0;

		public static Action _003C_003E9__23_1;

		public static Action _003C_003E9__26_3;

		public static Action _003C_003E9__26_0;

		public static Action _003C_003E9__28_1;

		public static Action _003C_003E9__28_2;

		public static Action _003C_003E9__28_0;

		public static Action _003C_003E9__31_0;

		public static Action _003C_003E9__31_1;

		public static Action _003C_003E9__31_2;

		internal void _003CCreateReplayData_003Eb__15_0()
		{
		}

		internal void _003CCreateReplayData_003Eb__15_1()
		{
		}

		internal void _003CCreateInGameData_003Eb__18_2()
		{
		}

		internal void _003CCreateLobbyData_003Eb__20_2()
		{
		}

		internal void _003CCreateMicrophoneData_003Eb__23_0()
		{
		}

		internal void _003CCreateMicrophoneData_003Eb__23_1()
		{
		}

		internal void _003CCreateHighlightRecordPermissionData_003Eb__26_3()
		{
		}

		internal void _003CCreateHighlightRecordPermissionData_003Eb__26_0()
		{
		}

		internal void _003CCreateHighlightPhotoData_003Eb__28_1()
		{
		}

		internal void _003CCreateHighlightPhotoData_003Eb__28_2()
		{
		}

		internal void _003CCreateHighlightPhotoData_003Eb__28_0()
		{
		}

		internal void _003CCreateVideoQualityData_003Eb__31_0()
		{
		}

		internal void _003CCreateVideoQualityData_003Eb__31_1()
		{
		}

		internal void _003CCreateVideoQualityData_003Eb__31_2()
		{
		}
	}

	private sealed class _003CRefreshScroll_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIReplayKitSettingController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshScroll_003Ed__9(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UIReplayKitSettingView m_View;

	private Dictionary<int, UICommonSettingContentController> m_CtrlDict;

	private Dictionary<int, CommonSettingContentData> m_DataDict;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void ResetScrollViewWidth()
	{
	}

	private void Start()
	{
	}

	private IEnumerator RefreshScroll()
	{
		return null;
	}

	public override void RefreshContent(object[] param)
	{
	}

	private void RefreshHighlightRecordSettingData()
	{
	}

	private void RefreshBtnsState()
	{
	}

	private void RefreshRecrodSettingContent(SettingBlock setting)
	{
	}

	private CommonSettingContentData CreateReplayBlockData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateReplayData()
	{
		return null;
	}

	private int GetReplaySetting()
	{
		return 0;
	}

	private CommonSettingContentData CreateCommonBlockData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateInGameData()
	{
		return null;
	}

	private int GetInGameReplayKitSetting()
	{
		return 0;
	}

	private CommonSettingItemDataToggleBtns CreateLobbyData()
	{
		return null;
	}

	private int GetLobbyReplayKitSetting()
	{
		return 0;
	}

	private CommonSettingContentData CreateMicrophoneBlockData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateMicrophoneData()
	{
		return null;
	}

	private int GetMicrophoneSetting()
	{
		return 0;
	}

	private CommonSettingContentData CreateHighlightRecordSettingData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateHighlightRecordPermissionData()
	{
		return null;
	}

	private int GetHighlightRecordSetting()
	{
		return 0;
	}

	private CommonSettingItemDataToggleBtns CreateHighlightPhotoData()
	{
		return null;
	}

	private int GetHighlightPhotoSetting()
	{
		return 0;
	}

	private CommonSettingContentData CreateAndroidBlockData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateVideoQualityData()
	{
		return null;
	}

	private int GetVideoQualityReplayKitSetting()
	{
		return 0;
	}

	private void OnReplayKitSwitchCallback(object[] args)
	{
	}

	private void OnClickVideoBtn()
	{
	}

	private void _003CCreateInGameData_003Eb__18_0()
	{
	}

	private void _003CCreateInGameData_003Eb__18_1(bool permission)
	{
	}

	private void _003CCreateLobbyData_003Eb__20_0()
	{
	}

	private void _003CCreateLobbyData_003Eb__20_1(bool permission)
	{
	}

	private void _003CCreateHighlightRecordPermissionData_003Eb__26_1()
	{
	}

	private void _003CCreateHighlightRecordPermissionData_003Eb__26_2(bool permission)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent(object[] P0)
	{
	}
}
