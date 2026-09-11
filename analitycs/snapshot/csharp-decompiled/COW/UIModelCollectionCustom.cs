using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;
using tcp;

namespace COW;

public class UIModelCollectionCustom : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass51_0
	{
		public bool showTips;

		public UIModelCollectionCustom _003C_003E4__this;

		public uint collectionId;

		public string customInfo;

		internal void _003CRequestChangeCustomData_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	public const uint PropID_ChangeCustomDataSuccess = 2u;

	public const uint PropID_GetCustomDataSuccess = 4u;

	private Dictionary<ulong, Dictionary<uint, string>> m_CollectionCustomDictByAccount;

	private Dictionary<ulong, string> m_CollectionCustomNickNameDictByAccount;

	public Dictionary<uint, CollectionCustomDesc> m_CollectionCustomDescs;

	public const int DefaultJerseyNumber = 9;

	public bool m_IsCustomDataReady;

	private bool m_IsPendingGetCustomData;

	private Dictionary<uint, RenderTexture> m_CollectionCustomRenderTextureDict;

	private Dictionary<uint, RenderTexture> m_CollectionCustomRenderTextureDictForSharer;

	private Dictionary<uint, bool> m_CollectionCustomRenderTextureDirtyDict;

	private GameObject m_JerseyNumberCustomGO;

	private CaptureCustomToMaterial m_JerseyNumberCustomComponent;

	public const int FirstPlayerY = 200;

	private const int OtherPlayerStartY = 400;

	private const int PlayerYStep = 200;

	private const int MaxYStep = 2400;

	private const string LocalLootBoxCustomDataPrefsKeyFormat = "{0}_CUSTOMITEM_{1}";

	private const string LocalLootBoxCustomLogPrefsKeyFormat = "{0}_CUSTOMITEM_LOG_{1}";

	private int m_NextAvailableY;

	public bool UseSharerRenderTexture;

	public bool LocalAvatarNameOrNumberDirty;

	public Dictionary<uint, CustomSortIDDesc> m_CollectionCustomSortIDDescDict;

	public bool IsCustomDataReady()
	{
		return false;
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public void ProcessCollectionCustomDesc(List<CollectionCustomDesc> datas)
	{
	}

	public void ProcessCollectionCustomSortIDDesc(List<CustomSortIDDesc> datas)
	{
	}

	public CustomSortIDDesc GetCollectionCustomSortIDDesc(uint itemSortId)
	{
		return null;
	}

	public bool IsItemCanCustom(uint itemId)
	{
		return false;
	}

	public string GetJerseyNumberSpriteName(int number)
	{
		return null;
	}

	public CollectionCustomDesc GetCollectionCustomDesc(uint itemId)
	{
		return null;
	}

	public CollectionCustomType GetCollectionCustomType(uint itemId)
	{
		return CollectionCustomType.None;
	}

	public List<CollectionCustomType> GetCollectionCustomTypes(uint itemId)
	{
		return null;
	}

	public Dictionary<uint, string> GetSelfCollectionCustomData()
	{
		return null;
	}

	public void SetCustomData(ulong accountID, string nickName, List<proto.AccountCollectionCustomItemInfo> customDataList)
	{
	}

	public void SetCustomData(ulong accountID, string nickName, List<tcp.AccountCollectionCustomItemInfo> customDataList)
	{
	}

	public void SetCollectionCustomData(ulong accountId, uint collectionId, string data)
	{
	}

	public string GetCollectionCustomData(ulong accountId = 0uL, uint collectionId = 0u)
	{
		return null;
	}

	public void SetCollectionCustomNickName(ulong accountId, string nickName, bool changeName = false)
	{
	}

	public string GetCollectionCustomNickName(ulong accountId = 0uL)
	{
		return null;
	}

	public string ConvertInfoToString(ItemCollectionCustomInfo info)
	{
		return null;
	}

	public ItemCollectionCustomInfo ConvertStringToInfo(string data)
	{
		return null;
	}

	public void ClearCollectionCustomData()
	{
	}

	public void ClearAllRenderTexture()
	{
	}

	public void ClearSharerRenderTexture()
	{
	}

	public void SetRenderTexture(uint collectionId, RenderTexture texture, bool isForSharer = false)
	{
	}

	public RenderTexture GetRenderTexture(uint collectionId, bool isForSharer = false)
	{
		return null;
	}

	public void SetRenderTextureDirty(uint collectionId, bool isDirty)
	{
	}

	public bool IsRenderTextureDirty(uint collectionId)
	{
		return false;
	}

	public void ClearRenderTexture(uint collectionId, bool isForSharer = false)
	{
	}

	public void GetAccountCollectionCustomItems()
	{
	}

	public void RequestChangeCustomData(uint collectionId, int source, List<ItemCollectionCustomLog> customContent, ItemCollectionCustomInfo info, bool showTips = true)
	{
	}

	public string GetLocalLootBoxCustomData(uint collectionId)
	{
		return null;
	}

	public void SaveLocalLootBoxCustomData(uint collectionId, string customData, List<ItemCollectionCustomLog> customContent)
	{
	}

	public void TryUploadLocalLootBoxCustomDataFromAwards(List<ExchangedAward> awards, int source)
	{
	}

	public void TryUploadLocalLootBoxCustomData(uint itemId, int source)
	{
	}

	private void TryUploadLocalLootBoxCustomDataFromAwardInfo(proto.EInventory.AwardType awardType, uint itemId, int source, List<uint> handledItemIds)
	{
	}

	private List<ItemCollectionCustomLog> BuildLootBoxCustomContentFromInfo(uint itemId, ItemCollectionCustomInfo info)
	{
		return null;
	}

	private bool IsLootBoxCustomInfoDefault(uint itemId, ItemCollectionCustomInfo info)
	{
		return false;
	}

	private string BuildSortIdListLogContent(uint[] sortIdOrder)
	{
		return null;
	}

	private string ConvertCustomContentToString(List<ItemCollectionCustomLog> customContent)
	{
		return null;
	}

	private List<ItemCollectionCustomLog> GetLocalLootBoxCustomLog(uint collectionId)
	{
		return null;
	}

	private void ClearLocalLootBoxCustomData(uint collectionId)
	{
	}

	private bool IsLootBoxItem(uint itemId)
	{
		return false;
	}

	private string GetLocalLootBoxCustomDataKey(uint collectionId)
	{
		return null;
	}

	private string GetLocalLootBoxCustomLogKey(uint collectionId)
	{
		return null;
	}

	public Vector3 GetAvailablePosition()
	{
		return default(Vector3);
	}

	public void RefreshJerseyNumberSelf(string name, int jerseyNumber, uint clothId, UIStatedAvatar avatar, ref bool isProcessCustomData, bool isForSharer = false)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void OnInventoryNewItemsNtf(InventoryChangeMessage message)
	{
	}

	private void _003CGetAccountCollectionCustomItems_003Eb__50_0(HttpErrorCode err, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
