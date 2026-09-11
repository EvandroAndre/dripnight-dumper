using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;

namespace COW.GamePlay;

internal abstract class UIUGCBaseSelectorItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	protected FCAJEKECGME GFBHKKMBJLJ;

	protected UIUGCBaseSelectorController OKDKCGHDBJD;

	protected UINewDownloadInfoController NBLPNAHCGEB;

	protected UIModelOptionalDownload GHHMLLLGCCO;

	protected UGCSimpleDownloadTask KKFPCLCLGLL;

	protected List<ResourceID> HBKKFKBFIHK;

	protected UGCCustomLevelObjectEditorPackageInfo OBNFNMHCPHP;

	protected abstract UISprite IIGOFBIIJKP { get; }

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object JCONDDPFBKK, int FOFBHPKKDAK)
	{
	}

	protected abstract void PAIAOBGDLPO();

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public virtual void OnDataChanged(UIBaseModel NAGHAPBBLKF, uint FAICJLONPIK, object[] DJAPBCKDFKA)
	{
	}

	protected virtual void JJGGKFOOIPF()
	{
	}

	protected virtual void DAJGDDJAJDE()
	{
	}

	protected virtual bool CIHFNEDBAFB()
	{
		return false;
	}

	protected virtual void JPLAIPLLNHK(UGCSimpleDownloadTask MNIFMNCJHNJ)
	{
	}

	public uint GetInterestedPropID(UIBaseModel NAGHAPBBLKF)
	{
		return 0u;
	}

	private void DEJHOANNDKH()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
