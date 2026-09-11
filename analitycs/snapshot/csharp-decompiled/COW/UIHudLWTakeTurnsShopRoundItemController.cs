using System.Collections.Generic;
using System.Text;
using GCommon;
using message;

namespace COW;

public class UIHudLWTakeTurnsShopRoundItemController : UIHudTakeTurnsShopRoundItemBaseController
{
	private UIHudLWTakeTurnsShopRoundItemView m_View;

	private StringBuilder m_Timer;

	private int mSeconds;

	private uint sec;

	private bool m_NeedShowTime;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetView(ERoundType roundType, int curRound, HFPCCOGIILE roundState)
	{
	}

	public override void SetViewLW(int curRound, bool finial, List<byte> chooserTeamIds)
	{
	}

	public override void SetRoundView(int curRound, int itemRound)
	{
	}

	public override void PlayScaleAnim(bool enlarge)
	{
	}

	public override void SetScale(bool enlarge)
	{
	}

	public override void SetBuffIcon()
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetView(ERoundType P0, int P1, HFPCCOGIILE P2)
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewLW(int P0, bool P1, List<byte> P2)
	{
	}

	public void _003C_003EiFixBaseProxy_SetRoundView(int P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_PlayScaleAnim(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetScale(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetBuffIcon()
	{
	}
}
