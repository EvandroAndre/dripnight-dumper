using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIPrimeFestivalController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<PrimeFestivalDesc> _003C_003E9__8_0;

		internal int _003CInitFestival_003Eb__8_0(PrimeFestivalDesc x, PrimeFestivalDesc y)
		{
			return 0;
		}
	}

	private UIPrimeFestivalView m_View;

	private UIModelPrime m_ModelPrime;

	private Dictionary<int, Transform> m_Dic4FestivalsPos;

	private Dictionary<int, Transform> m_Dic5FestivalsPos;

	private List<UIPrimeFestivalItemController> m_Ctrls;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InitFestival()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
