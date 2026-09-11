using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIMysteryMallLuckyDrawController : UINaviPopController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<MysteryShopProbability> _003C_003E9__12_0;

		internal int _003CShowProbabilityTips_003Eb__12_0(MysteryShopProbability a, MysteryShopProbability b)
		{
			return 0;
		}
	}

	private sealed class _003CStopDrawCoroutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIMysteryMallLuckyDrawController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStopDrawCoroutine_003Ed__16(int _003C_003E1__state)
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

		void IEnumerator.Reset()
		{
		}
	}

	private UIMysteryMallLuckyDrawView m_View;

	private UIModelMysteryMall m_ModelMall;

	private bool m_IsDrawing;

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

	private void CreateVFXByResID(Transform defaultVFX, ResourceID resId)
	{
	}

	private void SetLabelTheme(UILabel label, MysteryMallLuckyDrawThemeData themeData, MysteryMallLuckyDrawThemeData.ECustomLabelType luckyDrawLabel)
	{
	}

	private void SetSprite(UISprite sprite, string spriteName)
	{
	}

	private void SetLabelColor(UILabel label, Color topColor, Color bottomColor)
	{
	}

	private void RefreshView()
	{
	}

	private void ShowDrawingVFX()
	{
	}

	private void ShowProbabilityTips(List<MysteryShopProbability> probabilities)
	{
	}

	private void OnBtnGetLuckClick()
	{
	}

	private void OnBtnGoMysteryClick()
	{
	}

	private void OnBtnProbabilityTipsClick()
	{
	}

	private IEnumerator StopDrawCoroutine()
	{
		return null;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
