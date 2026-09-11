using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudAvatarTransformerBaseController : UIBaseController, IUIModelDataChangeObserver
{
	private class TransformConfig
	{
		public ResourceID BeforeAnimationId;

		public ResourceID AfterAnimationId;

		public ResourceID SoundEffectId;

		public EAvatarTransform BeforeStep;

		public EAvatarTransform AfterStep;

		public EAvatarModelIngameType TargetModelType;
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public UIHudAvatarTransformerBaseController _003C_003E4__this;

		public TransformConfig config;

		public Player localPlayer;

		public ConditionAction.ActionHandler _003C_003E9__1;

		internal void _003CExecuteTransform_003Eb__0()
		{
		}

		internal bool _003CExecuteTransform_003Eb__1()
		{
			return false;
		}
	}

	protected UIHudAvatarTransformerBaseView m_BaseView;

	protected TransformData m_transformData;

	private ResourceID m_CurPlayingResID;

	protected CSSharedItemData m_ItemData;

	private bool m_IsTransformBtnEventRegistered;

	private UINewDownloadInfoController m_DownloaderCtrl;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void Init(uint transformerId)
	{
	}

	public void InitForSocialLobby(uint transformerId)
	{
	}

	private void InitInternal(uint transformerId, bool needShowTutorial)
	{
	}

	private void OnEnable()
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

	protected virtual void UpdateDownloadStatus()
	{
	}

	private void OnTryTransform()
	{
	}

	public void TryTransformByHotkey()
	{
	}

	protected virtual EAvatarModelIngameType GetTargetTransformType(EAvatarModelIngameType curAvatarModelType)
	{
		return EAvatarModelIngameType.Normal;
	}

	private void OnBtnTransform(EAvatarModelIngameType targetTransformType)
	{
	}

	private bool ValidateTransformConditions(EAvatarModelIngameType targetTransformType)
	{
		return false;
	}

	private bool TryShowSocialLobbyDownloadPopup()
	{
		return false;
	}

	private List<ResourceID> GetNeedDownloadRes()
	{
		return null;
	}

	private void OpenOrRefreshDownloader(List<ResourceID> needDownloadRes)
	{
	}

	private void RefreshDownloadSprite(bool showDownloadIcon)
	{
	}

	private void CloseDownloader()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private TransformConfig GetTransformConfig(EAvatarModelIngameType targetTransformType, EAvatarModelIngameType curTransformType)
	{
		return null;
	}

	private void ExecuteTransform(Player localPlayer, TransformConfig config)
	{
	}

	private bool IsPlayingTransformAnim()
	{
		return false;
	}

	private bool isCanChange()
	{
		return false;
	}

	private void _003COpenOrRefreshDownloader_003Eb__24_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
