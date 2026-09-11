using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudLoadoutFeedBackTipsController : UIBaseController, NODKNGMKFIP
{
	private class FeedBackData
	{
		public ELoadoutShowType showType;

		public uint playerID;

		public object param1;
	}

	private UIHudLoadoutFeedBackTipsView m_View;

	private UISprite[] m_BgSprites;

	private Queue<FeedBackData> m_FeedBackDataQueue;

	private uint m_HideDelayCallID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(ELoadoutShowType showType, uint playerID, object[] extraParams)
	{
	}

	public void CheckAndPlay()
	{
	}

	private void StartShowData(FeedBackData data)
	{
	}

	public void OnHintShow()
	{
	}

	public void OnHintHide()
	{
	}

	public uint GetHintType()
	{
		return 0u;
	}

	public float GetHintPriority()
	{
		return 0f;
	}

	public bool IsHintShowing()
	{
		return false;
	}

	private void _003CStartShowData_003Eb__10_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
