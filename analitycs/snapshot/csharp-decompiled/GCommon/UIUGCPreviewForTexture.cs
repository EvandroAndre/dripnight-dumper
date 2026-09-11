using System;
using COW.Gameplay.UGC;
using UnityEngine;

namespace GCommon;

public class UIUGCPreviewForTexture : UINetworkTexture
{
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public UGCPreviewForTexture requestedPreview;

		public UIUGCPreviewForTexture _003C_003E4__this;

		internal void _003CSetPreviewTexture_003Eb__0(UnityEngine.Object obj)
		{
		}
	}

	public bool m_UGCShowLoadingState;

	private GameObject m_UGCCommonLoadingGO;

	private UGCPreviewForTexture m_CurrentPreview;

	private Action m_OnLoaded;

	public void SetPreviewTexture(UGCPreviewForTexture preview, bool useDefaultTexture, Action onLoaded)
	{
	}

	public void SetPreviewTexture(UGCPreviewForTexture preview)
	{
	}

	public void ClearPreview(bool resetToDefaultTexture)
	{
	}

	private void OnPreviewLoadedInternal(UnityEngine.Object obj)
	{
	}

	private void ShowUGCCommonLoading(bool isActive)
	{
	}
}
