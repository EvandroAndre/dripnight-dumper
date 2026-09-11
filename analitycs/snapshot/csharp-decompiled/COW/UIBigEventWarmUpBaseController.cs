using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public abstract class UIBigEventWarmUpBaseController : UINavigationController, IUIModelDataChangeObserver
{
	protected CountDownConfig m_Config;

	protected UIModelBigEvent m_ModelBigEvent;

	protected UIButton m_CloseBtn;

	protected UICountDownLabel m_CountDown;

	protected UINetworkTexture m_CDNTitle;

	protected abstract ELimitedEvent.EventID GetBigEventId();

	protected abstract string GetTitleCDNUrl();

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected virtual void SetCountDown(CountDownConfig config)
	{
	}

	protected virtual void OnTimeout()
	{
	}

	protected virtual void OnCloseClick()
	{
	}

	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	protected abstract void OnBigEventWarmupSettingCallback(List<BigEventShowAwardDesc> list);

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
