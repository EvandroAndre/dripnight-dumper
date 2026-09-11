using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIBigEventStoreBaseController : UIBigEventNaviPopBaseController, IEasyList
{
	private UIEasyList m_EasyList;

	private bool m_IsInit;

	private LimitedEventStore m_StoreData;

	public UIEasyList StoreEasyList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void SetViewData(LimitedEventStore storeData)
	{
	}

	public virtual UIBigEventStoreItemBaseController GetStoreItemController()
	{
		return null;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}
}
