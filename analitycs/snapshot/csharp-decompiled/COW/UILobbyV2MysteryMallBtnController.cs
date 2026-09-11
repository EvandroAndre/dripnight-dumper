using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2MysteryMallBtnController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static OnFinished _003C_003E9__12_0;

		internal void _003CRefreshMysteryMallEntrance_003Eb__12_0()
		{
		}
	}

	private UILobbyNewMysteryMallBtnView m_View;

	private UICountDownController m_MysteryMallCountCtrl;

	private UIModelMysteryMall m_ModelMysteryMall;

	private GameObject m_NormalVFXOBJ;

	private uint m_DelayCallId;

	private uint m_DelayCallShowCountDownId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void RequestRequestGetAllMysteryMallInfo()
	{
	}

	private void SetCDNIcon()
	{
	}

	private void RefreshDiscountView()
	{
	}

	private void OnMysteryMallClick()
	{
	}

	public void RefreshMysteryMallEntrance()
	{
	}

	public void ResetTipsContainer(bool isShow)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void DelayCallCreateNormalVFX()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void _003CSetCDNIcon_003Eb__9_0()
	{
	}

	private void _003CDelayCallCreateNormalVFX_003Eb__16_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
