using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIGameModeCSPeakTournamentItemController : UIGameModeBaseItemController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__11_0;

		internal void _003CSetItemUIData_003Eb__11_0()
		{
		}
	}

	private UIGameModeCSPeakTournamentInfoController m_InfoCtrl;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	private uint m_SeasonEndDelayCall;

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override ResourceID SelectEffectResID()
	{
		return default(ResourceID);
	}

	protected override ResourceID ClickEffectResID()
	{
		return default(ResourceID);
	}

	protected override void SetMapModeUI(MapModeData mapModeData)
	{
	}

	protected override bool CheckBanMatchState(ref long punishUntil)
	{
		return false;
	}

	protected override void SetItemUIData(List<MapModeData> dataList)
	{
	}

	public override void OnModeBtnClick()
	{
	}

	protected override bool CheckDuoVersionState()
	{
		return false;
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_SelectEffectResID()
	{
		return default(ResourceID);
	}

	public ResourceID _003C_003EiFixBaseProxy_ClickEffectResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_SetMapModeUI(MapModeData P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_CheckBanMatchState(ref long P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_SetItemUIData(List<MapModeData> P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnModeBtnClick()
	{
	}

	public bool _003C_003EiFixBaseProxy_CheckDuoVersionState()
	{
		return false;
	}
}
