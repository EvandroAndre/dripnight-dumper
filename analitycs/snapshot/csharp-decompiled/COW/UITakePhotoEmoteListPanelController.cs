using System;
using GCommon;

namespace COW;

public class UITakePhotoEmoteListPanelController : UIHudCameraEmotePanelController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<bool> _003C_003E9__11_0;

		internal bool _003COnUIOpen_003Eb__11_0()
		{
			return false;
		}
	}

	private bool IsPlayingTransformerFirstHalf_Lobby;

	public UIClickMask m_ClickMask;

	public bool IsContinuousPlay;

	public bool IsContinuousPlayBreakByItemClick;

	public bool IsPlayEmoteByList;

	public bool IsBreakByDuoEmote;

	public bool IsBreakByDelayCall;

	private uint m_DelayCallId;

	private UITakePhotoController ParentCtrl;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public UIClickMask GetClickMask()
	{
		return null;
	}

	protected override void RegisterEvents()
	{
	}

	private void OnEmotePanelShow(object[] data)
	{
	}

	protected override bool HasBp()
	{
		return false;
	}

	protected override uint GetTransfromId()
	{
		return 0u;
	}

	private void HideAllPlayVFX()
	{
	}

	protected override bool PlayEmote(int index, bool isItemClick = false)
	{
		return false;
	}

	private void StartDelayCall()
	{
	}

	protected override void BeforeDoEmoteListReplay()
	{
	}

	public void ClearParamCache()
	{
	}

	public void CancelDelayCall()
	{
	}

	private void OnLocalAvatarEmotionExist(float normalizedTime)
	{
	}

	public override void OnBtnCloseClick()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	protected override void DoEmoteListReplay()
	{
	}

	public override void AddToPlayList(UIHudCameraEmoteItemController item, bool isItemClick = false)
	{
	}

	public void OnLocalAvatarPlayInviterDuoEmotion(EmoteData emoteData)
	{
	}

	public void OnStopEmotionByDownLoadAvatarAsset(bool beforeplayemote)
	{
	}

	protected override void Update()
	{
	}

	private void _003CStartDelayCall_003Eb__19_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_RegisterEvents()
	{
	}

	public bool _003C_003EiFixBaseProxy_HasBp()
	{
		return false;
	}

	public uint _003C_003EiFixBaseProxy_GetTransfromId()
	{
		return 0u;
	}

	public bool _003C_003EiFixBaseProxy_PlayEmote(int P0, bool P1)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_BeforeDoEmoteListReplay()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnCloseClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_DoEmoteListReplay()
	{
	}

	public void _003C_003EiFixBaseProxy_AddToPlayList(UIHudCameraEmoteItemController P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_Update()
	{
	}
}
