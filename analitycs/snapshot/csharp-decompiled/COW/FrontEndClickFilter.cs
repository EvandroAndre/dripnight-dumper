using System.Collections.Generic;
using UnityEngine;

namespace COW;

internal class FrontEndClickFilter : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public object[] data;

		internal bool _003COnAddClickFilter_003Eb__0(ClickFilterData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public string key;

		internal bool _003COnRemovelickFilter_003Eb__0(ClickFilterData a)
		{
			return false;
		}
	}

	public ClickFilterData[] FilterArr;

	private List<ClickFilterData> m_Filters;

	private Dictionary<string, Rect> m_DictRect;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void RegisterUICameraCustomInput(UICamera.OnCustomInput handler)
	{
	}

	private void UnRegisterUICameraCustomInput(UICamera.OnCustomInput handler)
	{
	}

	private void OnAddClickFilter(object[] data)
	{
	}

	private void OnRemovelickFilter(object[] data)
	{
	}

	private void OnUICameraCustomInput()
	{
	}

	private void AddRect(ClickFilterData fd)
	{
	}
}
