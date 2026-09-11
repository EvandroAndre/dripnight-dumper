using System;
using GCommon;

namespace COW;

internal class UIEnterGroupRankEffectController : UIBaseController
{
	private UIEnterGroupRankEffectView m_View;

	public Action<bool> onAnimFinished;

	private UIBRRankIconController m_BRRankIconController;

	private UICSRankIconController m_CSRankIconController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(int rank, bool isBRRank, int anotherRank, uint peakRankPos = 0u)
	{
	}

	public void PlayAnim()
	{
	}

	private void OnAnimFinished()
	{
	}

	private void OnEffectInterrupt(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
