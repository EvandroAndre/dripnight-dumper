using GCommon;
using UnityEngine;

namespace COW;

public class UITwentyFiveSeasonYearMainController : UISeasonYearMainBaseController
{
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public UITwentyFiveSeasonYearMainController _003C_003E4__this;

		public int animType;

		internal void _003COnPlayStartAnim_003Eb__0()
		{
		}
	}

	private UITwentyFiveSeasonYearMainView m_View;

	private uint m_MainAnimDelayCall;

	private uint m_AfterPopAnimDelayCall;

	private uint m_AfterHarkAnimDelayCall;

	private Animation m_UifxBgAnim;

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

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnPlayStartAnim(object[] data)
	{
	}

	protected override void OnPlaySwitchAnim(uint seasonYearId)
	{
	}

	protected override void InitProgressDict()
	{
	}

	private void InitView()
	{
	}

	private void SetCDN()
	{
	}

	protected override void SetHeroicCntAndProgressView()
	{
	}

	protected override void SetRewardView()
	{
	}

	protected override void SetPointView()
	{
	}

	protected override void SetBRHeroicPointsView()
	{
	}

	protected override void SetCSHeroicPointsView()
	{
	}

	public override void PlayMainAnim(int animType)
	{
	}

	private void PlayPageAndHawkAnim()
	{
	}

	private void OnHeroicCntClick()
	{
	}

	private void ShowSwitchYearGuide()
	{
	}

	private void _003CPlayPageAndHawkAnim_003Eb__21_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public uint _003C_003EiFixBaseProxy_GetSeasonYearId()
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPlayStartAnim(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnPlaySwitchAnim(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_InitProgressDict()
	{
	}

	public void _003C_003EiFixBaseProxy_SetHeroicCntAndProgressView()
	{
	}

	public void _003C_003EiFixBaseProxy_SetRewardView()
	{
	}

	public void _003C_003EiFixBaseProxy_SetPointView()
	{
	}

	public void _003C_003EiFixBaseProxy_SetBRHeroicPointsView()
	{
	}

	public void _003C_003EiFixBaseProxy_SetCSHeroicPointsView()
	{
	}

	public void _003C_003EiFixBaseProxy_PlayMainAnim(int P0)
	{
	}
}
