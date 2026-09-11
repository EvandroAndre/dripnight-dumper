using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using proto;

namespace COW;

internal class UGCCommerceIAPServiceDebug : UGCCommerceIAPServiceBase
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<WorkshopProductInfo> _003C_003E9__7_0;

		internal int _003CParseCSVToStoreItemList_003Eb__7_0(WorkshopProductInfo a, WorkshopProductInfo b)
		{
			return 0;
		}
	}

	private sealed class _003CDownloadAndParseCSV_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public UGCCommerceIAPServiceDebug _003C_003E4__this;

		private UnityWebRequest _003Cwww_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDownloadAndParseCSV_003Ed__6(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private int m_GemsCount;

	private int m_ItemTokenCount;

	private int m_UGCTokenCount;

	private UIModelUGCCommerceIAP m_Model;

	public UGCCommerceIAPServiceDebug(UIModelUGCCommerceIAP model)
	{
	}

	public void InitDebugData(int gemsCount, int ugcCurrencyCount = 0, string iapDebugUrl = "")
	{
	}

	private IEnumerator DownloadAndParseCSV(string url)
	{
		return null;
	}

	private void ParseCSVToStoreItemList(string csvText)
	{
	}

	public override List<WorkshopProductInfo> RequestStoreData()
	{
		return null;
	}

	public override void RequestPurchase(WorkshopProductInfo data, uint count, uint price)
	{
	}

	public override void RequestExchange(uint gems, uint itemTokens, WorkshopProductInfo data, uint count, uint price)
	{
	}

	public override int GetUserGems()
	{
		return 0;
	}

	public override int GetUserToken()
	{
		return 0;
	}

	public override int GetItemTokenCount()
	{
		return 0;
	}

	public override void SetTokenCount(int tokenCount)
	{
	}

	public override void Clearup()
	{
	}

	private static long ParseDateTimeToUnixSeconds(string value)
	{
		return 0L;
	}

	public void _003C_003EiFixBaseProxy_Clearup()
	{
	}
}
