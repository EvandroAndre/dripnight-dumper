using System.Collections.Generic;
using GCommon;
using message;
using proto;
using tcp;

namespace COW;

public class UIModelUGCPremium : UIBaseModel, IUIModelDataChangeObserver
{
	internal enum EUGCPremiumEnvironment
	{
		Release,
		Debug
	}

	public const uint PropID_MyVipInfoChanged = 2u;

	public const uint PropID_VIPControlDesc = 4u;

	private static readonly string Key_First_Viper_Format;

	private IUGCPremiumService m_ReleaseService;

	private IUGCPremiumService m_DebugService;

	private IUGCPremiumService m_CurrentService;

	private UIModelMall m_ModelMall;

	private bool m_HasRequestWorkshopSwitch;

	private bool _003CEnableCraftlandBlock_003Ek__BackingField;

	public string FirstViperPrefsKey => null;

	public bool InGame => false;

	public bool IsDebugging => false;

	public bool EnableCraftlandBlock
	{
		get
		{
			return _003CEnableCraftlandBlock_003Ek__BackingField;
		}
		internal set
		{
			_003CEnableCraftlandBlock_003Ek__BackingField = value;
		}
	}

	public bool IsOpen => false;

	public bool IsViper => false;

	public bool FreeUGCRoomCard => false;

	public MLCGGNGNBFB MyVipChangeState => MLCGGNGNBFB.Expire;

	public List<StoreDesc> CardStoreDescList => null;

	public WorkshopVIPControlDesc VipControlDesc => null;

	public bool InGameHudPremiumCenterState
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal IUGCPremiumService DebugService => null;

	internal IUGCPremiumService CurrentService => null;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public proto.WorkshopVipInfo GetMyVipInfo()
	{
		return null;
	}

	public proto.WorkshopVipInfo GetLastMyVipInfo()
	{
		return null;
	}

	public void RequestUnsubscribeWorkshopMember()
	{
	}

	public void RequestPurchase(StoreDesc storeDesc, bool enableSubscribe, proto.EWorkshop.VIPType subscribeType, bool systemAuto = false)
	{
	}

	public void OnBuyPremiumNotify(tcp.WorkshopVipInfo info)
	{
	}

	public int GetUserGems()
	{
		return 0;
	}

	public uint GetStorePrice(StoreDesc storeDesc)
	{
		return 0u;
	}

	public CSSharedItemData GetItemData(uint itemId)
	{
		return null;
	}

	public string GetCDN(string key)
	{
		return null;
	}

	public CSSharedItemDataManager.ItemSubType ConvertToItemSubType(proto.EWorkshop.VIPType vipType)
	{
		return CSSharedItemDataManager.ItemSubType.ItemSubType_NONE;
	}

	public proto.EWorkshop.VIPType ConvertToVIPType(CSSharedItemDataManager.ItemSubType itemSubType)
	{
		return proto.EWorkshop.VIPType.VIPType_NONE;
	}

	public bool IsOpenSubscribe(CSSharedItemDataManager.ItemSubType cardType)
	{
		return false;
	}

	public void RequestWorkshopSwitch()
	{
	}

	public void DebugInit(bool isViper, int gemsCount)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CRequestWorkshopSwitch_003Eb__50_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
