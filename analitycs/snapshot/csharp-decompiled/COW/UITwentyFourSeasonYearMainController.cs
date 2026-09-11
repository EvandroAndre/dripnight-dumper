using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UITwentyFourSeasonYearMainController : UISeasonYearMainBaseController, IUIModelDataChangeObserver
{
	private sealed class _003CDelayShowProgressAndRewardView_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UITwentyFourSeasonYearMainController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayShowProgressAndRewardView_003Ed__17(int _003C_003E1__state)
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

	private UITwentyFourSeasonYearMainView m_View;

	private const uint AllHeroicCnt = 12u;

	private uint m_PopAnimDelayCall;

	private uint m_MainAnimDelayCall;

	private uint m_MainSoundDelayCall;

	private bool m_HasFinishMainAnim;

	public uint HeroicCnt;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override uint GetSeasonYearId()
	{
		return 0u;
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	protected override void OnPlayStartAnim(object[] data)
	{
	}

	private void SetCDN()
	{
	}

	private void InitView()
	{
	}

	private IEnumerator DelayShowProgressAndRewardView()
	{
		return null;
	}

	protected override void SetPointView()
	{
	}

	protected override void InitProgressDict()
	{
	}

	public override void PlayMainAnim(int animType)
	{
	}

	protected override void SetHeroicCntAndProgressView()
	{
	}

	protected override void SetBRHeroicPointsView()
	{
	}

	protected override void SetCSHeroicPointsView()
	{
	}

	protected override void SetRewardView()
	{
	}

	private void SetThumbCurrentClaimView()
	{
	}

	private void _003COnPlayStartAnim_003Eb__14_0()
	{
	}

	private void _003CPlayMainAnim_003Eb__20_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public uint _003C_003EiFixBaseProxy_GetSeasonYearId()
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPlayStartAnim(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetPointView()
	{
	}

	public void _003C_003EiFixBaseProxy_InitProgressDict()
	{
	}

	public void _003C_003EiFixBaseProxy_PlayMainAnim(int P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetHeroicCntAndProgressView()
	{
	}

	public void _003C_003EiFixBaseProxy_SetBRHeroicPointsView()
	{
	}

	public void _003C_003EiFixBaseProxy_SetCSHeroicPointsView()
	{
	}

	public void _003C_003EiFixBaseProxy_SetRewardView()
	{
	}
}
