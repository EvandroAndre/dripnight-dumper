using System;
using System.Collections;
using System.Collections.Generic;
using COW.OpSysExt;
using GCommon;
using proto;

namespace COW;

internal class UIHighlightShareWindowController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public AlbumPhotoInfo highlightInfo;

		public UIHighlightShareWindowController _003C_003E4__this;

		internal void _003CShowHighlightPhoto_003Eb__0(bool success, MediaMgr.IAlbumImageTexture img, string failTipStr)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public long picTimeTicks;

		internal bool _003COnLeftArrowBtnClick_003Eb__0(AlbumPhotoInfo p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public long picTimeTicks;

		internal bool _003COnRightArrowBtnClick_003Eb__0(AlbumPhotoInfo p)
		{
			return false;
		}
	}

	private sealed class _003CSetVideoViewPos_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHighlightShareWindowController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetVideoViewPos_003Ed__34(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UIHighlightShareWindowView m_View;

	private ReplayKitVideoPreviewWindowController m_ReplayKitVideoPreviewWindowCtrl;

	private UIHudMatchResultHighlightTipsController m_MatchResultHighlightTipsCtrl;

	private UIImageSharePreviewWindowController m_ImageShareCtrl;

	private List<AlbumPhotoInfo> m_HighlightPhotos;

	private byte[] m_ResultPageImage;

	private byte[] m_PosterPageImage;

	private ulong m_MatchId;

	private MatchResultHighlightWindowInfo m_MatchResultHighlightWindowInfo;

	private UIModelTakePhoto m_ModelTakePhoto;

	private MatchStats m_MatchStats;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override int MinGroupDepth()
	{
		return 0;
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnClickToggleVideo()
	{
	}

	private void OnClickTogglePhoto()
	{
	}

	private void OnClickToggleScore()
	{
	}

	private void OnClickToggleResult()
	{
	}

	private void OnClickToggleRoom()
	{
	}

	private ShareImageData CreateMatchResultImageData(byte[] imageBytes, string filePath)
	{
		return null;
	}

	private EventLogger.EventShareMatchResultPosterExtraInfo CreateMatchResultPosterExtraInfo(bool isPoster)
	{
		return null;
	}

	public void ShowHighlightPhoto(AlbumPhotoInfo highlightInfo)
	{
	}

	public void SetHighlightWindowShareView(MatchResultHighlightWindowInfo highlightWindowInfo, bool hasHighlightVideo, MatchStats matchStats = null)
	{
	}

	public static bool CanShowFunResultShare(MatchStats matchStats, bool isNormalMatchResult)
	{
		return false;
	}

	private bool IsFunResultShareAvailable()
	{
		return false;
	}

	private static bool IsFunResultLeagueRoom(uint roomType)
	{
		return false;
	}

	private static bool IsFunResultGameMode(uint gameMode)
	{
		return false;
	}

	public static bool IsPlayerMatchVictory(MatchStats matchStats)
	{
		return false;
	}

	public void OnLeftArrowBtnClick(long picTimeTicks)
	{
	}

	public void OnRightArrowBtnClick(long picTimeTicks)
	{
	}

	private void IncreaseBtnDepth()
	{
	}

	private void SetPhotoViewPos()
	{
	}

	private IEnumerator SetVideoViewPos()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public int _003C_003EiFixBaseProxy_MinGroupDepth()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
