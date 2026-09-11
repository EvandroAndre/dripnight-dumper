using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBigEventLobbyEnterWndControler : UIABigEventLobbyEnterWndControler, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<BigEventEntryDesc> _003C_003E9__14_0;

		public static Predicate<CustomEventEntryDesc> _003C_003E9__15_0;

		internal bool _003CTransferEntryDesc_003Eb__14_0(BigEventEntryDesc x)
		{
			return false;
		}

		internal bool _003CTransferTemplateEntryDes_003Eb__15_0(CustomEventEntryDesc x)
		{
			return false;
		}
	}

	private UIBigEventLobbyEnterWndView m_View;

	private UIModelBigEvent m_ModelBigEvent;

	private UIModelBigEventTemplate m_ModelBigEventTemplate;

	private BigEventEntryDesc m_DescData;

	private CustomEventEntryDesc m_TemplateDescData;

	private string m_CdnImage;

	private string m_TitleCdn;

	private const uint MAIN_ENTRY_DESC_INDEX = 1u;

	protected Transform ItemRoot;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public virtual UIBigEventLobbyEnterItemControler GetLobbyEnterItem()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public override void TransferEndTimeStamp(uint end_timestamp)
	{
	}

	public override void TransferEntryDesc(List<BigEventEntryDesc> entryDesc)
	{
	}

	public override void TransferTemplateEntryDes(uint useType, List<CustomEventEntryDesc> entryDesc)
	{
	}

	private void RefreshView()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIClose()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
