using System;
using proto;

namespace COW;

public interface IBigEventModel
{
	void OnProcessEventOpenInfo();

	UIABigEventLobbyEnterWndControler GetBigEventLobbyEnterWnd();

	UIBigEventLobbyIconWndController GetBigEventLobbyIconWnd();

	Type GetLobbyEntranceType();

	bool IgnoreCheckOptionalDownload();

	bool OptionalResNeedDownload();

	bool CheckOpenedActivityView();

	void GotoBigEvent(string from, UIModelBigEvent.EBigEventEntranceID entranceId, ELimitedEvent.EventState activityState, string param, ulong subType3, object extra);

	bool CanGotoWhenBigEventClosed();

	bool CanIngoreDownloadRes(UIModelBigEvent.EBigEventEntranceID entranceId);
}
