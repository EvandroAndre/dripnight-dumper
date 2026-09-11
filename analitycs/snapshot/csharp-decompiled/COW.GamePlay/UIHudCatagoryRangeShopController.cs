using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

internal class UIHudCatagoryRangeShopController : UIBaseController
{
	public class JCBDLDGMIBF : IEasyList
	{
		private UIHudCatagoryRangeShopController MBPMMLMJOHL;

		public JCBDLDGMIBF(UIHudCatagoryRangeShopController LDCIMNAAGNO)
		{
		}

		public UIEasyListItemController OpenItemController(Transform FKODMCNOBDM)
		{
			return null;
		}

		public void CloseItemController(UIEasyListItemController CFFBINMFPAK)
		{
		}
	}

	public class MIMOIOMJBNO : IEasyList
	{
		private UIHudCatagoryRangeShopController MBPMMLMJOHL;

		public MIMOIOMJBNO(UIHudCatagoryRangeShopController LDCIMNAAGNO)
		{
		}

		public UIEasyListItemController OpenItemController(Transform FKODMCNOBDM)
		{
			return null;
		}

		public void CloseItemController(UIEasyListItemController CFFBINMFPAK)
		{
		}
	}

	private enum HIKJGOBJIDC
	{
		None,
		Title,
		ShopItem
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__30_0;

		public static Action _003C_003E9__30_1;

		public static Comparison<AJPCOJFKGOL> _003C_003E9__31_0;

		internal void IFHADCMAPCC()
		{
		}

		internal void OGICHCCJILG()
		{
		}

		internal int IDFEKPNJMON(AJPCOJFKGOL MDFHMBHHGGF, AJPCOJFKGOL OGECPGHMIHA)
		{
			return 0;
		}
	}

	private UIHudCatagoryRangeShopView CGIEAOLABHM;

	private AJPCOJFKGOL APPGNKBEBIP;

	private INOLNBGACGK FKMIOAOIACC;

	private List<AJPCOJFKGOL> FDECNOCGNGK;

	private Vector2 FFAODGBNIIK;

	private Vector2 KCDCPHECFEB;

	private Vector2 EDEBHDCBBPN;

	private bool HLLFDBGEMPF;

	private uint HHIAOANPJNA;

	private EFEHLPKFFMM DJJGKKMMEIA;

	private Vector3 HJKAKLPDIMC;

	private Vector3 LHODNBLICMB;

	private Vector3 GAMPMICEAPC;

	private Vector3 FEGPODNHFDI;

	private UIHudInGameShopItemDescController CELOAOFAKIJ;

	private readonly Dictionary<uint, HashSet<uint>> PKNDNPALGHL;

	private readonly HashSet<uint> MAAFPNLGHDN;

	private UIModelMatch AKBEAPBHMGL;

	private int DAHPFCJMOOP;

	public uint CIBODLELBBB => 0u;

	public EFEHLPKFFMM HOKFGGPBDOH => EFEHLPKFFMM.None;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void ANKDBEAMOID()
	{
	}

	private bool JFDLLFCGPBI()
	{
		return false;
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void SetControllerCursorEvent(Action IPOJNFDGBLF, Action CGHCLNEDFIC)
	{
	}

	public void InitData(List<AJPCOJFKGOL> NCLBOADCBEE, uint LPABIMBDIJI, INOLNBGACGK FIBHEMNPGMG)
	{
	}

	private void NKABHCKAOEI(object[] JCONDDPFBKK)
	{
	}

	private void DDFNBOHPNAN(object[] JCONDDPFBKK)
	{
	}

	private void CAJBNIFKIMP(object[] JCONDDPFBKK)
	{
	}

	private void MHFNAEIMCBP(object[] JCONDDPFBKK)
	{
	}

	private void PODCDFFCEHB()
	{
	}

	private void GGBHLJIAEEN()
	{
	}

	private void JJFNIJHPFBF()
	{
	}

	private void BOANHHADJOP(uint PNGNPLNDHBG)
	{
	}

	private void MJCKHFGALJA(uint OPPPILHBLHO)
	{
	}

	private void KFNBLHNFPON()
	{
	}

	public override void Hide()
	{
	}

	private void IINBFAFOBMP()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void Update()
	{
	}

	private void FDDJMPFLICC(List<uint> MIHGNHFDALC)
	{
	}

	private void GMJGNOOCPNO(uint OPPPILHBLHO)
	{
	}

	public bool ShouldShowTabNew(uint OPPPILHBLHO)
	{
		return false;
	}

	private UITable2.IUITable2Item IMFDEFAEBAN()
	{
		return null;
	}

	private UITable2.IUITable2Item GAEHCBFFELD()
	{
		return null;
	}

	private UITable2.IUITable2Item BALDPKLEBAH()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
