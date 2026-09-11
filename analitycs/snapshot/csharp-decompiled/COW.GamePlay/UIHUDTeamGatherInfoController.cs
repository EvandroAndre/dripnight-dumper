using System;
using System.Collections.Generic;
using System.Text;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class UIHUDTeamGatherInfoController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<Player> _003C_003E9__22_1;

		internal int GJCBJKCHPMA(Player MDFHMBHHGGF, Player OGECPGHMIHA)
		{
			return 0;
		}
	}

	private sealed class IIAMFMOAAHJ
	{
		public BHGGAEEHJCO FGDJMLACAMK;

		internal bool NMGDMBHEPBO(Player MDFHMBHHGGF)
		{
			return false;
		}
	}

	private UIHUDTeamGatherInfoView CGIEAOLABHM;

	private float DNBGGEPFAIA;

	private float DLHGGBPFOCN;

	private Color ANELFLFLICE;

	private Color DHOCMJPDHND;

	private StringBuilder GOOPOJGAAOC;

	private List<TeamGatherTeammateStateView> ENBEBAGAJNC;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected virtual void Update()
	{
	}

	private void IAEDHKNEGPF()
	{
	}

	private void GDKHKACEDLL()
	{
	}

	private void AHEDENIDHME()
	{
	}

	private void PFBKENEDBMK(DFDGLAKGKML LPMNOPAHHOM)
	{
	}

	public void OnRequestInfoCome(uint DKPNKDJFIPG, List<uint> FFOHOMHAHKI, uint MMMHKDJIHNG, float JDMCPGHHEHB, DFDGLAKGKML LPMNOPAHHOM)
	{
	}

	public void OnResponseInfoCome(uint HBPACABDEKL, bool EKNACOEIKID, DMBLHAPEMPA CBCAJJJCKLH, float JDMCPGHHEHB)
	{
	}

	public void ShowRequesterUI()
	{
	}

	public void ShowTeammateUI()
	{
	}

	public void ShowTeleportUI()
	{
	}

	public void ShowInterruptUI()
	{
	}

	public void RefreshTeammateGatherReadyState(uint HBPACABDEKL, bool EKNACOEIKID, DMBLHAPEMPA CBCAJJJCKLH, float JDMCPGHHEHB)
	{
	}

	public void InitTeammateReadyStateUI(bool NBOLKMPCMEM, BHGGAEEHJCO FGDJMLACAMK, List<uint> FFOHOMHAHKI)
	{
	}

	private void ADCFKHCDFBK()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
