using System;
using System.Collections.Generic;
using proto;

namespace COW;

internal interface OnlineMatch
{
	OnlineMatchEntranceState GetEntranceBtnState();

	void SetEntranceWarmUpState();

	bool AllProtocalReady();

	bool SetEntranceBtnState();

	bool CanShowEntranceCountDown();

	ulong GetCountDownTime();

	void SetLobbyEntranceWarmUpPlayerPrefs();

	void SetLobbyEntranceMatchOpenPlayerPrefs();

	DateTime MatchStartTime();

	int LobbyEntrancePriority();

	List<AdvertDesc> GetEntranceCdnDesc();
}
