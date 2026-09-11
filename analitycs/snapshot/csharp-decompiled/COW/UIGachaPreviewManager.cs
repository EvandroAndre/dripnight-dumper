using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaPreviewManager
{
	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public int animID;

		internal bool _003CGetClotheIDListByAnim_003Eb__0(FullscreenCgDesc item)
		{
			return false;
		}
	}

	private Vector3 TURNTABLEGACHADOUBLEANIMCAMERAROTATION;

	private const uint PREVIEWTYPELIMIT = 2u;

	private uint m_CurrentGachaID;

	private UIModelGacha m_ModelGacha;

	private UIModelAvatar m_ModelAvatar;

	private UINetworkTexture m_CDNTextureComponent;

	private bool m_ShowingAnimationFlag;

	private bool m_CurrentGachaIsFullScreenAnim;

	private UIGachaSceneShowType m_CurrenGachaModelShow;

	private List<uint> m_ShowTypeList;

	private FrontEndPreviewComponent_Gacha m_FrontEndPreviewComponent;

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

	public void RefreshPreviewSceneCtx(uint gachaID)
	{
	}

	public void RefreshPreviewScene(bool needSkipAnimation, bool needSkipKillNotify = false)
	{
	}

	public void SetAnimaionOver()
	{
	}

	public bool IsPlayingFullScreenAnim()
	{
		return false;
	}

	private void SkipModelAnim(bool needSkipKillNotify = false)
	{
	}

	public void SetCurrentSceneShowType(UIGachaSceneShowType showType)
	{
	}

	public UIGachaSceneShowType GetCurrentSceneShowType()
	{
		return UIGachaSceneShowType.Normal;
	}

	public List<uint> GetCurrentOtherShowType()
	{
		return null;
	}

	public void ClosePreviewScene()
	{
	}

	public void ResetPreviewModelCache()
	{
	}

	public void RefreshPreviewScenePlayAnimation(bool needSkipAnimation = false, bool needSkipKillNotify = false)
	{
	}

	private void ShowCDNSceneBg()
	{
	}

	private void ShowAnimationScene(bool needSkipAnimation = false, bool needSkipKillNotify = false)
	{
	}

	public void SkipAllAnim(bool needSkipKillNotify = false)
	{
	}

	public void SkipPreviewFullScreenAnim()
	{
	}

	public void NotifyContentUIShow()
	{
	}

	public void NotifyContentUIHide()
	{
	}

	public void SetSwitchBtnActive(bool activeState)
	{
	}

	public bool HasPreviewAnimation()
	{
		return false;
	}

	public void PlayPreviewAnimation()
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

	public void ShowTokenTowerPrivilege(LegendClothPrivilege privilege)
	{
	}

	private FullScreenAnimParams CreateFullScreenAnimParmas()
	{
		return null;
	}

	private void SetAvatarTransformInfo(AvatarTransformInfo avatarInfoA, AvatarTransformInfo avatarInfoB)
	{
	}

	private void RefreshPreivewAvatar(bool needSkipAnimation = false, bool needSkipKillNotify = false)
	{
	}

	private void ShowComPositePreviewModel(GachaDesc desc)
	{
	}

	private PlayDoubleAvatarAnimParams CreatePlayDoubleAvatarAnimParams(List<uint> idlistA, List<uint> idlistB, int doubleanimA = 1, int doubleanimB = 1, string doublespecialA = "", string doubleidleA = "", string doublespecialB = "", string doubleidleB = "")
	{
		return null;
	}

	private PlayDoubleAvatarAnimParams.AvatarAnimParams CreateAvatarAnimParams(List<uint> idlist, int doubleanim = 1, string doublespecial = "", string doubleidle = "")
	{
		return null;
	}

	private List<uint> Get1PModelList(GachaDesc desc)
	{
		return null;
	}

	private void ShowSimplePreviewModel(GachaDesc desc, bool needSkipAnimation = false, bool needSkipKillNotify = false)
	{
	}

	private void TryPlayFullScreenAnim(FullscreenCgDesc data)
	{
	}

	private bool IsAllClothesOwned(uint animID)
	{
		return false;
	}

	private List<uint> GetClotheIDListByAnim(int animID)
	{
		return null;
	}

	private List<uint> ProcessAnimData(FullscreenCgDesc animData)
	{
		return null;
	}

	private List<uint> DoProcessAnimData(CSSharedItemData data, List<uint> clothesID)
	{
		return null;
	}

	private void PreviewManagerReset()
	{
	}

	public void TryHidePreviewPanelOnShowAnimation()
	{
	}

	public void TryShowPreviewOnAnimationOver(bool needSkip = false, bool skipAnim = false, bool needSkipKillNotify = false)
	{
	}

	public void ShowPreview(bool skipAnim = false)
	{
	}

	public void LogEventTypeFullScreenAnimation(float playTime = 0f, float animTime = 0f, uint isPlayActively = 0u)
	{
	}

	private void SetPreviewShowAvatar()
	{
	}

	public void ClearKillNotify()
	{
	}
}
