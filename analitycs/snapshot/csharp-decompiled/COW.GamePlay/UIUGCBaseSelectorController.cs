using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

public abstract class UIUGCBaseSelectorController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
{
	private sealed class MEPDAJPAKFG
	{
		public string DKMDICNKGJJ;

		internal bool NEFCMKDHLIL(FCAJEKECGME JCONDDPFBKK)
		{
			return false;
		}
	}

	public UIModelUGCResourceSelect.ETableType ContentType;

	protected UIModelUGCResourceSelect LPDPPCINKOP;

	protected UGCAssetExplorer HKELMBCOPBH;

	protected UIModelOptionalDownload GHHMLLLGCCO;

	protected UINewDownloadInfoController NBLPNAHCGEB;

	protected FCAJEKECGME FJJMPIFDKBD;

	protected List<FCAJEKECGME> LBDLCEMGMIG;

	private Action<string, int> DBCGGCHHOJH;

	protected UGCSimpleDownloadTask KKFPCLCLGLL;

	protected List<ResourceID> HBKKFKBFIHK;

	protected List<UGCCustomLevelObjectEditorPackageInfo> HPHCIDPCJJJ;

	protected abstract GameObject NOLBMFKNABL { get; }

	public static void OpenSelector(UIModelUGCResourceSelect.ETableType CCNBNLAPJFM, string DKMDICNKGJJ, Action<string, int> CEHELPAIELA = null)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected void AGJOAAJJIJO(UIModelUGCResourceSelect.ETableType CCNBNLAPJFM, string DKMDICNKGJJ, Action<string, int> CEHELPAIELA = null)
	{
	}

	protected virtual void FCAGAKOMADG(string DKMDICNKGJJ)
	{
	}

	protected abstract void IKJEJKCCKHI();

	protected virtual void JJGGKFOOIPF()
	{
	}

	protected virtual void LPPJMMBLHGE()
	{
	}

	protected void JJFNIJHPFBF()
	{
	}

	protected void GKJMDDMAPFC(out int JDNELOKMKPB, out float GILNNBJLDGO, out float IFDHHGECCCM)
	{
		JDNELOKMKPB = default(int);
		GILNNBJLDGO = default(float);
		IFDHHGECCCM = default(float);
	}

	public uint GetInterestedPropID(UIBaseModel NAGHAPBBLKF)
	{
		return 0u;
	}

	public virtual void OnDataChanged(UIBaseModel NAGHAPBBLKF, uint FAICJLONPIK, object[] DJAPBCKDFKA)
	{
	}

	protected virtual bool CIHFNEDBAFB()
	{
		return false;
	}

	protected virtual void JPLAIPLLNHK(UGCSimpleDownloadTask MNIFMNCJHNJ)
	{
	}

	public UIEasyListItemController OpenItemController(Transform FKODMCNOBDM)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController CFFBINMFPAK)
	{
	}

	public virtual void OnItemSelect(FCAJEKECGME JCONDDPFBKK)
	{
	}

	protected virtual void KEMDCOMJGDB()
	{
	}

	protected virtual void GICEJNJJIFA()
	{
	}

	private void AEJLKGEMBJA()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
