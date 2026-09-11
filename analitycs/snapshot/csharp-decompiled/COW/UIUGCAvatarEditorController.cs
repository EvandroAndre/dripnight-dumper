using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay.UGC;
using GCommon;
using ReactUI;
using UnityEngine;
using message;

namespace COW;

public class UIUGCAvatarEditorController : UIPreviewPopUpWindowController
{
	public class BoneEditingInfo
	{
		public string BoneName;

		public WorkshopNPCRigName BoneConfig;

		public float BoneScalePct;
	}

	public enum EAvatarType
	{
		Female = 1,
		Male,
		Pet
	}

	public delegate void OnFinalSelected(MNJPGANHNOK resultData);

	private class ThirdSubTypeInfo
	{
		public int ShowIndex;

		public string NameKey;

		public int ValueID;
	}

	private class ThirdMainTypeInfo
	{
		public int TypeID;

		public string NameKey;

		public List<ThirdSubTypeInfo> SubTypes;

		public void AddSubTypeInfo(int typeID, string name)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass107_0
	{
		public UIUGCAvatarEditorController _003C_003E4__this;

		public string loadingClipUUID;

		internal void _003ConResAnimationClipLoaded_003Eb__0(bool succ2, UGCResAnimationClip resObj2)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass108_0
	{
		public UIUGCAvatarEditorController _003C_003E4__this;

		public string loadingClipUUID;

		internal void _003CpreviewAnimStateClip_003Eb__0(bool succ, UGCResAnimationClip resObj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass90_0
	{
		public UIModelUGCResourceSelect.EAvatarFirstTab curSecondTab;

		public UIModelUGCResourceSelect modelResSelect;

		internal bool _003ConSelectedEditorItem_003Eb__0(uint id)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass93_0
	{
		public UIModelUGCResourceSelect modelResSelect;

		public UIModelUGCResourceSelect.AvatarEditorItemData item;

		internal bool _003ConSelectedClothItem_003Eb__0(uint id)
		{
			return false;
		}

		internal bool _003ConSelectedClothItem_003Eb__1(uint id)
		{
			return false;
		}
	}

	private UIUGCAvatarEditorView m_View;

	private uint m_showingAvatarID;

	private List<uint> m_showingItemIDs;

	private int m_showingEmoteID;

	private string m_showingClipUUID;

	private int m_showingWeaponID;

	private int m_showingBagID;

	private Dictionary<string, BoneEditingInfo> m_boneEditingInfos;

	private List<BoneEditingInfo> m_boneEditingInfoList;

	private int m_avatarType;

	private OnFinalSelected m_okCallback;

	private MNJPGANHNOK m_editingProtoData;

	private GameObject m_cacheRealtimeLight;

	private SceneEditGridMesh m_cacheEditGrid;

	private UIVariable var_CommonItems;

	private UIVariable var_EmoteItems;

	private UIVariable var_CurFirstTabID;

	private UIVariable var_CurSecondTabID;

	private UIVariable var_SecondTabItems;

	private UIVariable var_FirstTabItems;

	private UIVariable var_CurrentSelectCommonItemID;

	private UIVariable var_BoneItems;

	private UIVariable var_HasSecondTab;

	private UIVariable var_HasThirdTypeSelect;

	private UIVariable var_ThirdMainTypeList;

	private UIVariable var_ThirdSubTypeList;

	private UIVariable var_CurThirdMainType;

	private UIVariable var_CurThirdSubType;

	private UIVariable var_WeaponItems;

	private List<ThirdMainTypeInfo> m_weaponMainTypeList;

	private Dictionary<int, List<UIModelUGCResourceSelect.AvatarEditorItemData>> m_weaponShowIndex2WeaponListMap;

	private List<string> m_cacheThirdMainTypeList;

	private List<string> m_cacheThirdSubTypeList;

	private List<UIModelUGCResourceSelect.AvatarEditorTabData> m_avatarEditorAnimationTabs;

	private List<int> m_commonItems;

	private List<UIModelUGCResourceSelect.AvatarEditorItemData> m_debugItems;

	private List<WorkshopNPCRigName> m_cacheNpcRigNames;

	private BodyPartUtilByName m_boneScaleComponent;

	private float m_nextFindBoneScaleComponentTime;

	private AnimationClip m_previewAnimStateClip;

	private UIPetAvatar m_previewPetAvatar;

	private UIMaleAvatar m_previewPlayerAvatar;

	private int CurFirstTabIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private int CurSecondTabIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private UIModelUGCResourceSelect.EAvatarFirstTab CurFirstTabID => UIModelUGCResourceSelect.EAvatarFirstTab.enNone;

	private UIModelUGCResourceSelect.EAvatarFirstTab CurSecondTabID => UIModelUGCResourceSelect.EAvatarFirstTab.enNone;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override FrontEndPreviewComponent GetFrontEndPreviewComponent()
	{
		return null;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetEditingDataAndCallback(MNJPGANHNOK data, OnFinalSelected callback)
	{
	}

	public static EAvatarType AvatarRefFFID2Type(uint ffid)
	{
		return (EAvatarType)0;
	}

	private void protoData2EditingData(MNJPGANHNOK data)
	{
	}

	private MJAIEIAKNHJ createPart()
	{
		return null;
	}

	private void editingData2ProtoData(MNJPGANHNOK data)
	{
	}

	private void setupLighting()
	{
	}

	private void restoreLighting()
	{
	}

	private void event_OnSecondTabIDChanged(object[] args)
	{
	}

	private void event_OnFirstTabIDChanged(object[] args)
	{
	}

	private void reactFirstTab()
	{
	}

	private void event_OnClickCommonItem(object[] args)
	{
	}

	private void event_OnClickEmoteItem(object[] args)
	{
	}

	private void event_OnBoneScaleChanged(object[] args)
	{
	}

	private void event_OnClose(object[] args)
	{
	}

	private void event_OnThirdMainTypeChanged(object[] args)
	{
	}

	private void event_OnThirdSubTypeChanged(object[] args)
	{
	}

	private void addItemWeaponShowListMap(int nWeaponID, UIModelUGCResourceSelect.AvatarEditorItemData item)
	{
	}

	private bool fetchWeaponMainSubTypeIndexFromWeaponItemID(uint weaponItemID, out int mainTypeIndex, out int subTypeIndex)
	{
		mainTypeIndex = default(int);
		subTypeIndex = default(int);
		return false;
	}

	private void initWeaponMainSubTypes()
	{
	}

	private void refreshWeaponMainSubTypes()
	{
	}

	private void refreshWeaponSubTypes()
	{
	}

	private void refreshWeaponItems()
	{
	}

	private int getIntFromArgs(object[] args)
	{
		return 0;
	}

	private void refreshFirstTabIDs()
	{
	}

	private void refreshSecondTabIDs()
	{
	}

	private void refreshSecondTabEnables()
	{
	}

	private void refreshAvatarItems()
	{
	}

	private void refreshClothItems()
	{
	}

	private void refreshEmoteItems()
	{
	}

	private void refreshBoneItems()
	{
	}

	private void refreshCommonItems()
	{
	}

	private void onSelectedEditorItem(UIModelUGCResourceSelect.AvatarEditorItemData item, UIModelUGCResourceSelect.EAvatarFirstTab curSecondTab)
	{
	}

	private string getDefaultAnimClipUUID()
	{
		return null;
	}

	private void onSelectedAvatarItem(UIModelUGCResourceSelect.AvatarEditorItemData item)
	{
	}

	private void onSelectedClothItem(UIModelUGCResourceSelect.AvatarEditorItemData item)
	{
	}

	private void refreshPreviewEmote()
	{
	}

	private void Update()
	{
	}

	private void clearBoneScale()
	{
	}

	private void applyPetBoneScale()
	{
	}

	private void applyPlayerBoneScale()
	{
	}

	private void applyBoneScale(bool find = true)
	{
	}

	private void onPetAvatarCreated(GameObject obj)
	{
	}

	private void onPlayerAvatarCreated(GameObject obj)
	{
	}

	private void onResAnimationClipLoaded(bool succ, UGCResAnimationClip resObj, string loadingClipUUID, bool enableCheckReload)
	{
	}

	private void previewAnimStateClip(bool tryLoad, bool skipCheckNeedDownload)
	{
	}

	private bool onCheckDownloadResourceID(List<ResourceID> resourceIDs)
	{
		return false;
	}

	private void onAllResourcePrepared()
	{
	}

	private bool isAllResDownload()
	{
		return false;
	}

	private bool checkIfNeedDownload()
	{
		return false;
	}

	private void refreshPreview()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public FrontEndPreviewComponent _003C_003EiFixBaseProxy_GetFrontEndPreviewComponent()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
