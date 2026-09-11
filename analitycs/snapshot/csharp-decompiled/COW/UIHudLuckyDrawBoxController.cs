using System;
using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLuckyDrawBoxController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__49_0;

		public static Action _003C_003E9__49_1;

		internal void _003CSetControllerCursorEvent_003Eb__49_0()
		{
		}

		internal void _003CSetControllerCursorEvent_003Eb__49_1()
		{
		}
	}

	private const string TITLEGUIDEKEY = "TITLEGUIDEKEY";

	private const string BUYITEMGUIDEKEY = "BUYITEMGUIDEKEY";

	private Color LEVEL2TAGCOLOR;

	private Color LEVEL3TAGCOLOR;

	private const uint ITEMCOUNT = 5u;

	private UIHudLuckyDrawBoxView m_View;

	private LevelLuckyDrawBox m_Box;

	private UIInGameScene m_InGameScene;

	private List<UIHudLuckyDrawBoxItemController> m_Items;

	private uint m_RefreshPrice;

	private uint m_BuyPirce;

	private uint m_Seconds;

	private uint m_Min;

	private uint m_Second;

	private string m_LabelUpdate;

	private uint m_EndTime;

	private uint m_TimeLength;

	private MutableString m_Timer;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool IsSuspendingEnabled()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InitItems()
	{
	}

	private void TryShowGuide()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void TryHideGuide()
	{
	}

	public void SetViewData(LevelLuckyDrawBox box)
	{
	}

	private void OnSetViewData()
	{
	}

	private void PlayVfx(GameObject vfx)
	{
	}

	private void OnBuyBtnClick()
	{
	}

	private void OnRefreshBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private static void AppendMinOrSec(StringBuilder sb, uint min)
	{
	}

	private void Update()
	{
	}

	private void RefreshCountDown()
	{
	}

	private void RefreshLevel()
	{
	}

	private void RefreshItems()
	{
	}

	private void RefreshPrice()
	{
	}

	private void OnClose(object[] param)
	{
	}

	private void OnForceClose(object[] param)
	{
	}

	private bool OnEscapeClick()
	{
		return false;
	}

	private void OnLevelUp(object[] param)
	{
	}

	private void OnRefresh(object[] param)
	{
	}

	private void OnGuideBuy(object[] param)
	{
	}

	private void OnPlayerDead(object[] data)
	{
	}

	private void OnPlayerKnockDown(object[] data)
	{
	}

	private void OnTokenChanged(int data)
	{
	}

	private void RefreshPriceLabelColorOnBoxRefresh()
	{
	}

	private void RefreshPriceLabelColor(int tokenCount)
	{
	}

	protected override void SetControllerCursorEvent(Action OnShow, Action OnHideOrDestory)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsSuspendingEnabled()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
