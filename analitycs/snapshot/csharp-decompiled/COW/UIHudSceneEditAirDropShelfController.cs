using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudSceneEditAirDropShelfController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<KeyValuePair<int, int>> _003C_003E9__7_0;

		internal int _003CTryGetDropItems_003Eb__7_0(KeyValuePair<int, int> a, KeyValuePair<int, int> b)
		{
			return 0;
		}
	}

	private UIHudSceneEditAirDropShelfView m_View;

	private List<UIHudSceneEditAirDropItemController> m_CachedItemCtrls;

	private string m_BindShopID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetShelfData(string shopID, bool initShow)
	{
	}

	private void RefreshUI(object[] data)
	{
	}

	private bool TryGetDropItems(out List<KeyValuePair<int, int>> dropItems)
	{
		dropItems = null;
		return false;
	}

	private bool TryConvertToInt(object value, out int result)
	{
		result = default(int);
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
