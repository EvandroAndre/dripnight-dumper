using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudCabinWaitingStickerController : UIBaseController
{
	private UIHudCabinWaitingStickerView m_View;

	private bool m_IsInCD;

	private float m_chatCD;

	private uint m_CheckCDDelayCallID;

	private BHGGAEEHJCO m_PlayerId;

	private readonly List<StickerSpriteView> m_StickerSpriteViewList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(BHGGAEEHJCO playerID)
	{
	}

	private void OnStickerSpriteClick(object[] data)
	{
	}

	private void StartMsgCDCheck()
	{
	}

	private void _003CStartMsgCDCheck_003Eb__13_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
