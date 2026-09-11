using GCommon;

namespace COW;

public class UILobbyAvatarTransformerBaseController : UIBaseController, IUIModelDataChangeObserver
{
	protected UIModelEmote m_ModelEmote;

	protected UIMaleAvatar m_CurAvatar;

	protected TransformData m_transformData;

	protected CSSharedItemData m_ItemData;

	public UINewDownloadInfoController m_DownloaderCtrl;

	protected UILobbyAvatarTransformerBaseView m_BaseView;

	protected override void OnUIInit()
	{
	}

	public virtual void Init(uint transformerId)
	{
	}

	public virtual void SetCurAvatar(UIMaleAvatar avatar)
	{
	}

	protected void RefreshView()
	{
	}

	protected virtual void RefreshTransformerSprite()
	{
	}

	protected virtual void RefreshTransformerVFX()
	{
	}

	protected virtual EAvatarModelIngameType GetUITransformType()
	{
		return EAvatarModelIngameType.Normal;
	}

	protected virtual void OnTryTransform()
	{
	}

	protected virtual void BtnTransformClick(int transformerType)
	{
	}

	private void CloseEmotePanel()
	{
	}

	private bool IsPlayingTransformAnim()
	{
		return false;
	}

	private void UpdateDownloadStatus()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
