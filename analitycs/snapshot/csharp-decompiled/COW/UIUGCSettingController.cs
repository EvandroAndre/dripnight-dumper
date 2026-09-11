using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UIUGCSettingController : UISettingContentBase
{
	private enum UGCSettingKey
	{
		CameraMoveSpeed,
		FriendMessage
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<int> _003C_003E9__14_0;

		internal int _003CCreateFriendMessageData_003Eb__14_0()
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public float length;

		internal void _003CCreateCameraMoveSpeedData_003Eb__0(float value)
		{
		}

		internal float _003CCreateCameraMoveSpeedData_003Eb__1()
		{
			return 0f;
		}
	}

	private UIUGCSettingView m_View;

	private List<UICommonSettingContentController> m_CtrlList;

	private SwitchDesc m_AgreementSwitchDesc;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetAgreementActive()
	{
	}

	private void OnClickUserAgreementBtn()
	{
	}

	private void ResetScrollViewWidth()
	{
	}

	private void Start()
	{
	}

	public override void RefreshContent(object[] param)
	{
	}

	private CommonSettingContentData CreateCameraBlockData()
	{
		return null;
	}

	private CommonSettingItemDataSlider CreateCameraMoveSpeedData()
	{
		return null;
	}

	private CommonSettingContentData CreateNotificationBlockData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateFriendMessageData()
	{
		return null;
	}

	private void OnFriendMessageOn()
	{
	}

	private void OnFriendMessageOff()
	{
	}

	private void OnClickResetDefaultBtn()
	{
	}

	private void _003COnClickResetDefaultBtn_003Eb__17_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent(object[] P0)
	{
	}
}
