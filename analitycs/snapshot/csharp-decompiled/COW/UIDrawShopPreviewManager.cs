using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIDrawShopPreviewManager
{
	private const uint PREVIEW_TYPE_LIMIT = 2u;

	private uint m_CurrentChestId;

	private UIModelDrawShop m_ModelDrawShop;

	private UIModelAvatar m_ModelAvatar;

	private UINetworkTexture m_CDNTextureComponent;

	private FrontEndPreviewComponent_Gacha m_FrontEndPreviewComponent;

	private bool m_ShowingAnimationFlag;

	private bool m_CurrentChestIsFullScreenAnim;

	private UIDrawShopSceneShowType m_CurrentSceneShowType;

	private List<uint> m_ShowTypeList;

	public bool IsCGVideoActivePlay;

	public void Init(UINetworkTexture texture, FrontEndPreviewComponent_Gacha frontEndPreviewComponent)
	{
	}

	public void SetFrontendPreviewComponent(FrontEndPreviewComponent_Gacha frontEndPreviewComponent)
	{
	}

	public void SetPreviewSceneBorder(UIWidget uIWidget)
	{
	}

	public void Dispose()
	{
	}

	public void RefreshPreviewSceneCtx(uint chestId)
	{
	}

	public void RefreshPreviewScene(bool needSkipAnimation, bool needSkipKillNotify = false)
	{
	}

	public void RefreshPreviewScenePlayAnimation(bool needSkipAnimation = false, bool needSkipKillNotify = false)
	{
	}

	public void SetCurrentSceneShowType(UIDrawShopSceneShowType showType)
	{
	}

	public UIDrawShopSceneShowType GetCurrentSceneShowType()
	{
		return UIDrawShopSceneShowType.Normal;
	}

	public List<uint> GetCurrentOtherShowType()
	{
		return null;
	}

	public void SetAnimationOver()
	{
	}

	public bool IsPlayingFullScreenAnim()
	{
		return false;
	}

	public void SkipAllAnim(bool needSkipKillNotify = false)
	{
	}

	public void SkipPreviewFullScreenAnim()
	{
	}

	public bool HasPreviewAnimation()
	{
		return false;
	}

	public void PlayPreviewAnimation()
	{
	}

	private void SkipModelAnim(bool needSkipKillNotify = false)
	{
	}

	public void ClosePreviewScene()
	{
	}

	public void ClearAvatarOnly()
	{
	}

	public void ShowPreviewRewardPoolItem(BaseItemInfo itemInfo, bool needSkipAnim = false, bool needSkipKillNotify = false)
	{
	}

	public void ShowPreviewRewardPoolItem(uint itemId, bool needSkipAnim = false)
	{
	}

	public uint GetCurrentPreviewItemId()
	{
		return 0u;
	}

	public void HidePreviewUI()
	{
	}

	public void ShowPreviewUI()
	{
	}

	public void ShowPreview(uint itemID, bool skipAnim = false)
	{
	}

	public void TryHidePreviewPanelOnShowAnimation()
	{
	}

	public void TryShowPreviewOnAnimationOver(bool needSkip = false, bool skipAnim = false, bool needSkipKillNotify = false)
	{
	}

	public void NotifyContentUIShow()
	{
	}

	public void NotifyContentUIHide()
	{
	}

	private void ShowCDNSceneBg()
	{
	}

	private void ShowAnimationScene(bool needSkipAnimation = false, bool needSkipKillNotify = false)
	{
	}

	private void RefreshPreviewAvatar(bool needSkipAnimation = false, bool needSkipKillNotify = false)
	{
	}

	private void ShowSimplePreviewModel(UIModelDrawShop.DrawShopUniversalData universalData, bool needSkipAnimation = false, bool needSkipKillNotify = false)
	{
	}

	private void TryPlayFullScreenAnim(FullscreenCgDesc animData)
	{
	}

	private FullScreenAnimParams CreateFullScreenAnimParams()
	{
		return null;
	}

	private void SetAvatarTransformInfo(AvatarTransformInfo avatarInfoA, AvatarTransformInfo avatarInfoB)
	{
	}

	private void SetPreviewShowAvatar()
	{
	}

	private void PreviewManagerReset()
	{
	}

	public FullscreenCgDesc GetCurrentAnimData()
	{
		return null;
	}

	public void ClearKillNotify()
	{
	}

	public uint GetCurrentChestId()
	{
		return 0u;
	}
}
