using System.Collections.Generic;
using GCommon;

namespace COW;

internal class VoucherDataManager : SingletonModule<VoucherDataManager>
{
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public uint id;

		internal bool _003CFindVoucherDataByID_003Eb__0(VoucherData data)
		{
			return false;
		}
	}

	private List<VoucherData> m_VoucherDataList;

	public List<VoucherData> VoucherDataList => null;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public VoucherData FindVoucherDataByID(uint id)
	{
		return null;
	}
}
