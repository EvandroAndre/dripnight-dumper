using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIActivityOverviewController : UIActivityContentController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<AdvertDesc> _003C_003E9__5_0;

		internal int _003CSetData_003Eb__5_0(AdvertDesc x, AdvertDesc y)
		{
			return 0;
		}
	}

	private UIActivityOverviewView m_View;

	private UIModelActivity m_ModelActivity;

	private List<UIActivityOverviewItemController> m_Items;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetData(object data)
	{
	}

	public override void Reload()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Reload()
	{
	}
}
