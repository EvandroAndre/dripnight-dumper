using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityEighthSignetItemContentController : UIActivityContentController
{
	public enum State
	{
		UnOpen,
		CanOpen,
		Opening,
		Closed
	}

	public class Data
	{
		public uint TapIndex;

		public uint ItemIndex;

		public ClientActivityDesc EighthSignetDatas;

		public ClientActivityDesc EighthSignetSpecialData;
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public uint subTypeId;

		internal bool _003CGetCdnUrl_003Eb__0(AdvertDesc e)
		{
			return false;
		}
	}

	public const uint CDN_SIGNET_LEFT_CONTENT_BG = 20250009u;

	public const uint CDN_SIGNET_LEFT_CONTENT_MASK_BG = 20250010u;

	public const uint CDN_SIGNET_MID_CONTENT_BG = 20250013u;

	public const uint CDN_SIGNET_MID_CONTENT_MASK_BG = 20250014u;

	public const uint CDN_SIGNET_RIGHT_CONTENT_BG = 20250011u;

	public const uint CDN_SIGNET_RIGHT_CONTENT_MASK_BG = 20250012u;

	public const uint CDN_SIGNET_LEFT_CONTENT_COMPLETE_BG = 20250016u;

	public const uint CDN_SIGNET_MID_CONTENT_COMPLETE_BG = 20250017u;

	public const uint CDN_SIGNET_RIGHT_CONTENT_COMPLETE_BG = 20250018u;

	public const uint CDN_SIGNET_CONTENT_TITLE = 20250019u;

	private UIActivityEighthSignetItemContentView m_View;

	private UIModelActivity m_ModelActivity;

	protected State m_State;

	private UIActivityEighthSignetContentController.EighthSignetItemList m_Data;

	private uint m_FirstStartShowKey;

	private List<UIActivityEighthSignetItemController> m_EightSigenItemCtrlList;

	private int m_LoadCdnCount;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public bool GetSightItemFingerItem(ref UIActivityEighthSignetItemController signetItemCtrl)
	{
		return false;
	}

	protected virtual void OnShowMaskTips()
	{
	}

	protected virtual void OnShowOpenAnim()
	{
	}

	public virtual UIActivityEighthSignetContentController.EighthSignetItemList GetData()
	{
		return null;
	}

	public State GetState()
	{
		return State.UnOpen;
	}

	public override void SetData(object data)
	{
	}

	public override void Reload()
	{
	}

	protected void UpdateShowData()
	{
	}

	protected ClientActivityDesc GetEightSpecialItemData(ClientActivityDesc desc)
	{
		return null;
	}

	private bool CheckActivityPreId(uint sortId, ulong value)
	{
		return false;
	}

	protected void UpdateState()
	{
	}

	protected void UpdateViewState()
	{
	}

	protected void ShowUnOpen()
	{
	}

	protected void ShowOpening()
	{
	}

	protected void ShowCanOpen()
	{
	}

	protected void ShowClosed()
	{
	}

	protected void UpdateChildDepth(Transform trans, int depth)
	{
	}

	protected void InitCDN()
	{
	}

	protected string GetCdnUrl(uint subTypeId)
	{
		return null;
	}

	private bool LoadImageFromUrl(UINetworkTexture uINetworkTexture, string strUrl)
	{
		return false;
	}

	private void OnShareCdnSuccessCallback()
	{
	}

	public virtual bool NeedShowFirstUIFX()
	{
		return false;
	}

	protected virtual uint GetCDNContentBgType()
	{
		return 0u;
	}

	protected virtual uint GetCDNMaskBgType()
	{
		return 0u;
	}

	protected virtual uint GetCDNContentCompleteBgType()
	{
		return 0u;
	}

	private void _003CShowCanOpen_003Eb__34_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Reload()
	{
	}
}
