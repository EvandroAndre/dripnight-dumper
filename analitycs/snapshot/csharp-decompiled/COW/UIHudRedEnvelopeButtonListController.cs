using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudRedEnvelopeButtonListController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<FDLPLPLKEKN> _003C_003E9__5_0;

		internal int _003CSetRedEnvelopeData_003Eb__5_0(FDLPLPLKEKN a, FDLPLPLKEKN b)
		{
			return 0;
		}
	}

	private UIHudRedEnvelopeButtonListView m_View;

	private List<RedEnvelopeItemView> m_ItemViewList;

	private const int VBADGE_RED_ENVELOPE_TYPE = 2;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetRedEnvelopeData(object[] param)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnRedEnvelopeBtnClick(object[] param)
	{
	}

	private void OnTrainingZoneChanged(object[] param)
	{
	}

	private void OnEventClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
