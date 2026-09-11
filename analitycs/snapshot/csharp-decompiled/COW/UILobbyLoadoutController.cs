using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UILobbyLoadoutController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public UILobbyLoadoutController _003C_003E4__this;

		public Action onContinuePlay;

		public Action onLater;

		internal void _003CShowLoadoutEmptyBox_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_1
	{
		public UICommonCountDownBoxController ctrl;

		public _003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals1;

		internal void _003CShowLoadoutEmptyBox_003Eb__0()
		{
		}

		internal void _003CShowLoadoutEmptyBox_003Eb__1()
		{
		}
	}

	private UIModelLoadout m_ModelLoadout;

	private UILoadoutV2GuideController m_GuideController;

	private UILobbyLoadoutView m_View;

	private UITipsNormalController m_Tips;

	private List<string> iconList;

	private UILobbyLoadoutBubbleController m_BubbleController;

	private Func<bool> m_HasGuideInLobby;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnDisable()
	{
	}

	private void InitTips()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public UIWidget GetGuideWidget()
	{
		return null;
	}

	public UIButton GetGuideButton()
	{
		return null;
	}

	private void OnCheckLoadoutV2Guide(uint step)
	{
	}

	private void OnLoadOutBtnClickCallback()
	{
	}

	private void OnLoadOutBtnClick(bool enableEmptySlotGuide = false)
	{
	}

	public void RefreshIcon(bool needShowVFX = true)
	{
	}

	public void ShowLoadoutEmptyBox(Action onContinuePlay, Action onLater = null)
	{
	}

	public void RefreshLoadoutBubble(bool isFirstPresetPlan = false)
	{
	}

	private bool HasNoGuideInLobby()
	{
		return false;
	}

	public void SetGuideFunc(Func<bool> guideFunc)
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
