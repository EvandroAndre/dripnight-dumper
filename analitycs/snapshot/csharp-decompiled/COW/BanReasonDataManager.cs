using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class BanReasonDataManager : SingletonModule<BanReasonDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<BanInfoUrlData> _003C_003E9__8_1;

		internal bool _003CGetDefaultUrl_003Eb__8_1(BanInfoUrlData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public EAccount.BanReason reasonId;

		public bool timeLimited;

		internal bool _003CGetBanReasonDesc_003Eb__0(BanReasonData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public EAccount.BanReason reasonId;

		public string Country;

		internal bool _003CGetBanReasonUrl_003Eb__0(BanInfoUrlData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public EAccount.BanReason reasonId;

		internal bool _003CGetDefaultUrl_003Eb__0(BanInfoUrlData x)
		{
			return false;
		}
	}

	public List<BanReasonData> m_BanReasonDataList;

	public List<BanInfoUrlData> m_BanInfoUrlDataList;

	public Dictionary<string, BanReasonDescData> m_BanReasonDescDataList;

	protected override void OnInit()
	{
	}

	private void InitBanReasonDesc()
	{
	}

	protected override void OnCleanup()
	{
	}

	public string GetBanReasonDesc(EAccount.BanReason reasonId, uint timeStamp)
	{
		return null;
	}

	public string GetBanReasonUrl(EAccount.BanReason reasonId)
	{
		return null;
	}

	public string GetDefaultUrl(EAccount.BanReason reasonId)
	{
		return null;
	}

	private EAccount.BanReason ModifyBanReason(EAccount.BanReason banReason)
	{
		return EAccount.BanReason.BanReason_UNKNOWN;
	}

	public string GetBanReasonDesc(string banType)
	{
		return null;
	}
}
