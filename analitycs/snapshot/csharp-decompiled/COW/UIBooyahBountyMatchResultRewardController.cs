using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIBooyahBountyMatchResultRewardController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<BooyahDay24BDimensionInfo> _003C_003E9__3_0;

		internal int _003CSetDetailData_003Eb__3_0(BooyahDay24BDimensionInfo a, BooyahDay24BDimensionInfo b)
		{
			return 0;
		}
	}

	private UIBooyahBountyMatchResultRewardView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetDetailData(uint totalNum, List<BooyahDay24BDimensionInfo> list)
	{
	}

	private void OnClickTipsBtn()
	{
	}

	private void OnClickCloseMaskBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
