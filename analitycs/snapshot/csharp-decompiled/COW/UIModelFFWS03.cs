using System;
using GCommon;
using proto;

namespace COW;

public class UIModelFFWS03 : UIBaseModel, IBigEventModel
{
	private FFWSMiscSettingDesc m_FFWSSetting;

	public const uint PropID_GetMiscSetting = 2u;

	public override uint GetModelType()
	{
		return 0u;
	}

	public UIABigEventLobbyEnterWndControler GetBigEventLobbyEnterWnd()
	{
		return null;
	}

	public UIBigEventLobbyIconWndController GetBigEventLobbyIconWnd()
	{
		return null;
	}

	public bool IgnoreCheckOptionalDownload()
	{
		return false;
	}

	public bool CheckOpenedActivityView()
	{
		return false;
	}

	public bool CanGotoWhenBigEventClosed()
	{
		return false;
	}

	public bool CanIngoreDownloadRes(UIModelBigEvent.EBigEventEntranceID entranceId)
	{
		return false;
	}

	public bool OptionalResNeedDownload()
	{
		return false;
	}

	public void GotoBigEvent(string from, UIModelBigEvent.EBigEventEntranceID entranceId, ELimitedEvent.EventState activityState, string param, ulong subType3, object extra)
	{
	}

	public void OnProcessEventOpenInfo()
	{
	}

	public Type GetLobbyEntranceType()
	{
		return null;
	}

	public FFWSMiscSettingDesc GetMiscSetting()
	{
		return null;
	}

	public void RequestMiscSetting()
	{
	}

	public bool IsExchangeStoreLocked(uint storeId)
	{
		return false;
	}

	public bool IsInMatchLive()
	{
		return false;
	}

	public bool IsInMatchTeamShow()
	{
		return false;
	}

	public override void Logout(object[] data)
	{
	}

	private void _003CRequestMiscSetting_003Eb__14_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
