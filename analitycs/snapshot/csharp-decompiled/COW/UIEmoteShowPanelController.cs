using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIEmoteShowPanelController : UIBaseController, IUIModelDataChangeObserver
{
	private UIEmoteShowPanelView m_View;

	private UILobbyAvatarTransformerEntryController m_TransformerEntryCtrl;

	private const int DRESSUP_BG_SMALL = 300;

	private const int DRESSUP_BG_BIG = 400;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private UIModelEvoPass m_ModelEvoPass;

	private UIModelProfile m_ModelProfile;

	private List<UILobbyEmoteSlotItemController> m_EmoteSlotItemCtrl;

	private List<Transform> m_NormalEmoteSlotTransform;

	private List<Transform> m_BPEmoteSlotTransform;

	private int m_ClickSlotId;

	private bool m_IsBpEmoteCreatNew;

	private uint m_DelayCallIdLockAnim;

	private UILaunchTagFrameController m_LaunchTagCtrl;

	private ItemTagInfo m_LaunchTagInfo;

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

	public void SetCurAvatar(UIMaleAvatar avatar)
	{
	}

	public void RefreshPhotoBtn()
	{
	}

	private void RefreshPrimeSetShareTakeOffButtom()
	{
	}

	private void PrimeSetShareTakeOffOnClick()
	{
	}

	private void SetTransformList()
	{
	}

	private void ProcessNormalEmoteSlotCtrl()
	{
	}

	private void ProcessBPEmoteSlotCtrl()
	{
	}

	public void SetPanelDepth(int depth)
	{
	}

	private void UpdateEmoteItemDownloadStatus(uint eID, UILobbyEmoteSlotItemController item)
	{
	}

	private void UpdateEmotions()
	{
	}

	private void InitDressups()
	{
	}

	private void RefreshAvatarTransformer()
	{
	}

	private void OnBpLockBtnClick()
	{
	}

	private void OnClickMask()
	{
	}

	private void OnPhotoBtnCick()
	{
	}

	protected void OnBtnGroupShowTitleShow()
	{
	}

	private void OnBtnGroupShowLaunchTag()
	{
	}

	private void RefreshTitleBtnShow()
	{
	}

	private void RefreshLaunchTagBtnShow()
	{
	}

	private void OnEmoteItemClick(object[] data)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void ShowGuide()
	{
	}

	private void _003CUpdateEmotions_003Eb__27_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
