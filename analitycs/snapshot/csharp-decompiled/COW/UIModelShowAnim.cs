using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UIModelShowAnim : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public FullscreenABTestDesc desc;

		internal bool _003CReplaceAnimDataByAB_003Eb__0(FullscreenCgDesc Item)
		{
			return false;
		}
	}

	private List<FullscreenCgDesc> fullscreen_cgs;

	private List<FullscreenItemDesc> fullscreen_items;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public void SetAnimData(CSGetFullscreenCgRes res)
	{
	}

	public void SetItemAnimData(CSGetFullscreenItemRes res)
	{
	}

	public void ReplaceAnimDataByAB(CSGetFullscreenABTestRes res)
	{
	}

	public int CheckFullScreenItem(uint itemid)
	{
		return 0;
	}

	public List<FullscreenCgDesc> FullScreenAnimByNavType(UINavigationUtil.UINavigationPageType type)
	{
		return null;
	}

	public FullscreenCgDesc FullScreenAnimByItemAnimID(uint id)
	{
		return null;
	}

	public bool NeedDownloadFullScreen_TwoPeopleAnim(FullscreenCgDesc desc)
	{
		return false;
	}

	public DownloadInfoSpecific GetDownloadInfoSpecific(FullscreenCgDesc desc)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
