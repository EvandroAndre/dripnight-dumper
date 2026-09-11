using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIFrontEndPreview2DItemController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public UIFrontEndPreview2DItemController _003C_003E4__this;

		public UISprite iconSprite;

		public CSSharedItemData itemInfo;

		internal void _003CSetSpriteWithInfo_003Eb__0(bool downloadSuccess)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass34_1
	{
		public UISprite sprite;

		public _003C_003Ec__DisplayClass34_0 CS_0024_003C_003E8__locals1;

		internal void _003CSetSpriteWithInfo_003Eb__1(bool downloadSuccess)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public UITexture targetTexture;

		public UIFrontEndPreview2DItemController _003C_003E4__this;

		internal void _003CSetPhotoFrameByResourceID_003Eb__0(bool result)
		{
		}
	}

	private UIFrontEndPreview2DItemView m_View;

	public bool left;

	private UIFrontEndSpecialItemCdnPreviewController m_SpecialCdnPreviewCtrl;

	private UIModelStoreBox m_ModelStoreBox;

	private UIModelCollection m_ModelCollection;

	private CSSharedItemData m_Data;

	private FrontEndPreviewComponent m_FrontEndPreviewComponent;

	private UILoadingPlayerInfoController m_BattleCardCtrl;

	private UILoadingCardController m_LoadingCardCtrl;

	private UIBaseProfileInfoController m_BaseProfileInfoCtrl;

	private TextureIconCDNResource m_PhotoFrameCDNRes;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetAnchorInspector(UIWidget item, GameObject go, int left, int right, int bottom, int top, float leftOri = 0f, float rightOri = 1f, float bottomOri = 0f, float topOri = 1f)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetLeftAnchor(int biasLeft = 0, int biasRight = 0, int biasTop = 0, int biasBottom = 0)
	{
	}

	public void SetRightAnchor()
	{
	}

	public void SetCommonDepth(int depth)
	{
	}

	public void SetFrontEndPreviewComponent(FrontEndPreviewComponent component)
	{
	}

	private bool IsPhotoFramePreviewSupported()
	{
		return false;
	}

	public void SetUIdata(CSSharedItemData info)
	{
	}

	public void SetCSPeakBundleUIData(List<uint> itemList, CSSharedItemData bundle)
	{
	}

	public void ChangeBattleCardUIState()
	{
	}

	public bool GetBattleCardUIState()
	{
		return false;
	}

	public void SetSpecialCdnWidgetSize(Vector2 size)
	{
	}

	public void SetSpecialCdnItemData(BaseItemInfo data, bool needSetDepth = true)
	{
	}

	public void SetSpecialUIdata(BaseItemInfo data)
	{
	}

	private void SetSPSpriteWithInfo(BaseItemInfo itemInfo, UISprite iconSprite, bool isBigIcon = false)
	{
	}

	public void SetUIItemViewIconPos(Vector3 tr)
	{
	}

	public void SetUIBannerViewPos(Vector3 tr)
	{
	}

	public void SetUIHeadPicViewPos(Vector3 tr)
	{
	}

	public void SetSpecialItemCdnViewPos(Vector3 pos)
	{
	}

	public void SetQuickMessageViewPos(Vector3 pos)
	{
	}

	public void SetBattleCardViewPos(Vector3 pos)
	{
	}

	private void SetSpriteWithInfo(CSSharedItemData itemInfo, UISprite iconSprite, bool isBigIcon = false)
	{
	}

	private void SetComposeIcon(UISprite iconSprite, UISprite sprite)
	{
	}

	private void OnGetDetailBtnClick()
	{
	}

	private void SetPhotoFrame(CSSharedItemData info)
	{
	}

	private void SetPhotoFrameByResourceID(UINetworkTextureExt textureExt, ResourceID res)
	{
	}

	private void SetPhotoFrameByUrl(UINetworkTextureExt textureExt, string cdnUrl)
	{
	}

	private void UnRegisterCDNUrl()
	{
	}

	private Color[] ParseColorSet(string colorStr)
	{
		return null;
	}

	private Color ParseColor(string colorStr)
	{
		return default(Color);
	}

	private string GetCDNLink(int itemIdsCount, string item_cdn_link, string bundle_cdn_link)
	{
		return null;
	}

	private string GetDefaultCDNLink(bool isSingleItem)
	{
		return null;
	}

	private Vector3 GetQuickMessagePreviewScale()
	{
		return default(Vector3);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
