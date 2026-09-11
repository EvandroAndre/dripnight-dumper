using System;
using GCommon;
using message;
using proto;

namespace COW;

public class UIModelLinkActivity : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass14_0<T> where T : class
	{
		public Action<T> callback;

		internal void _003CSendServerRequest_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_LinkActivityInfo = 1u;

	public const uint PropID_LinkActivityReward = 2u;

	public const uint PropID_LinkEquipSet = 4u;

	public const uint PropID_LinkPVEOpen = 8u;

	private const string TipPrefKey = "LinkActivityProcess";

	private const string TipPrefEntryKey = "LinkActivityProcessEntry";

	private CSGetLinkageActivityInfoRes m_State;

	public int RefreshHour;

	public int EquipSetsId;

	public uint Day => 0u;

	public uint ActivityId => 0u;

	public override uint GetModelType()
	{
		return 0u;
	}

	private void SendServerRequest<T>(ServiceMessageTypeHTTP cmd, Action<T> callback, uint httpOp = 0u) where T : class
	{
	}

	public void GetLinkEquipSetInfoFromServer(uint httpOp = 0u, bool updateEntryTick = true)
	{
	}

	private string GetPrefKey(ETipsType type)
	{
		return null;
	}

	public void OnClearTipToday(ETipsType type)
	{
	}

	private void _003CGetLinkEquipSetInfoFromServer_003Eb__15_0(CSGetLinkEquipSetRes data)
	{
	}
}
