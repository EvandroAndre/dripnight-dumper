using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

internal class UIHUDUGC_OpeningBanner_AnnihilateController : UIHUDUGC_InternalHudController
{
	public class OpeningBanner_Annihilate
	{
		public int ShowTimeMs;
	}

	private UIHUDUGC_OpeningBanner_AnnihilateView m_View;

	private OpeningBanner_Annihilate m_ViewData;

	private uint m_DelayCallID;

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

	public void SetStateByParams(bool isShow, List<GOGJFEJNDLE> args)
	{
	}

	private void UpdateView()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
