using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCHudPrefabMgr : IUGCModule, IUGCModuleHudPrefab
{
	private UGCRuntime ugcRuntime;

	private List<OCGHOAIKOGG> prefabList;

	private Dictionary<string, Dictionary<string, string>> hudChildren;

	private Dictionary<string, Dictionary<string, uint>> hudPathToId;

	private Dictionary<string, UGCHudNode> hudNodeMap;

	private UniqueIDGenerator widgetEntityIDGen;

	private Dictionary<ulong, int> hudDepth;

	private Dictionary<ulong, List<string>> hudOwner;

	private Dictionary<string, ulong> hudProfileInfo;

	public UGCHudPrefabMgr Create(UGCRuntime ugcRuntime, FICHBIFMBOF hudPrefabData)
	{
		return null;
	}

	public void Init(object[] args)
	{
	}

	public void Destroy()
	{
	}

	public void DeleteUser(ulong userID)
	{
	}

	public void CreateCustomHudWithLogicEntityData(uint hudID, EntityIndex entityIndex, IUGCUser user)
	{
	}

	private void FixEntityRefRedirection(string hudEntityID, List<UGCLogicEntity> instanceEntities)
	{
	}

	public void RemoveCustomHudOrWidgetEntity(string entityID)
	{
	}

	public void RemoveCustomHudEntity(string hudEntityID)
	{
	}

	public void RemoveWidgetEntity(string widgetEntityID)
	{
	}

	public string FindHudWidgetEntity(string hudEntityID, string widgetFileID)
	{
		return null;
	}

	public string FindHudWidgetEntityByString(string hudEntityID, string hudPrefabID, string widgetNameOrPath)
	{
		return null;
	}

	public int GetHudWidgetEntityType(UGCHudWidgetType widgetType)
	{
		return 0;
	}

	private UGCHudNode GetHudNodeByentityID(string entityID)
	{
		return null;
	}

	public void SetHudSizeProp(string entityID, int propID, int itemValue)
	{
	}

	public void CalculateSizeDelta(UGCHudNode hudNode)
	{
	}

	public void GetHudSizeDeltaBySize(string entityID, object s, object d, ref Vector2 src, ref Vector2 dst)
	{
	}

	public void GetHudSizeDelta(string entityID, long propID, object s, object d, ref Vector2 src, ref Vector2 dst)
	{
	}

	public Vector2 GetSizeDelta(UGCHudNode hudNode)
	{
		return default(Vector2);
	}

	public void UpdateUGCHudSizeByAnchorBox(UGCHudNode hudNode)
	{
	}

	public Vector2 GetParentSize(UGCHudNode hudNode)
	{
		return default(Vector2);
	}

	public void SetChildHudSizeDirty(UGCHudNode hudNode)
	{
	}

	public Vector2 GetHudSize(UGCHudNode hudNode)
	{
		return default(Vector2);
	}

	public int GetHudSizeProp(string entityID, int propID)
	{
		return 0;
	}

	public void internalGeneratePathMap(string prefabId, string basePath, List<LBHDMMIEANP> children)
	{
	}

	public void GeneratePathMap(string prefabId, string basePath, string entityID)
	{
	}

	public void internalCreateAllHudWidgetEntity(string hudEntityID, IUGCUser user, List<LBHDMMIEANP> children, string parentID)
	{
	}

	public List<UGCLogicEntity> internalCreateAllHudWidgetEntityWithLogicEntityData(string hudPrefabID, IUGCUser user, string hudEntityID)
	{
		return null;
	}

	public UGCLogicEntity createWidgetEntity(string hudEntityID, int fileID, int componentType, string entityID, IUGCUser user)
	{
		return null;
	}

	public string DynamicCreateWidgetEntity(int widgetType, EntityIndex entityIndex, string parentWidgetEntityID)
	{
		return null;
	}

	private void initEmptyWidgetEntity(UGCLogicEntity widgetEntity, ALGADJPAAGL data)
	{
	}

	private void initLabelWidgetEntity(UGCLogicEntity widgetEntity, ALGADJPAAGL data)
	{
	}

	private void initImageWidgetEntity(UGCLogicEntity widgetEntity, ALGADJPAAGL data)
	{
	}

	private void initButtonWidgetEntity(UGCLogicEntity widgetEntity, ALGADJPAAGL data)
	{
	}

	private void initInputWidgetEntity(UGCLogicEntity widgetEntity, ALGADJPAAGL data)
	{
	}

	private void initPanelEntity(UGCLogicEntity widgetEntity, ALGADJPAAGL data)
	{
	}

	public void InitScrollViewEntity(UGCLogicEntity widgetEntity, ALGADJPAAGL data)
	{
	}

	public void InitGridEntity(UGCLogicEntity widgetEntity, ALGADJPAAGL data)
	{
	}

	public void InitLayoutEntity(UGCLogicEntity widgetEntity, ALGADJPAAGL data)
	{
	}

	public void Init3DContainerEntity(UGCLogicEntity widgetEntity, ALGADJPAAGL data)
	{
	}

	private void InitTextureEntity(UGCLogicEntity widgetEntity, ALGADJPAAGL data)
	{
	}

	private void InitProfileInfoEntity(UGCLogicEntity widgetEntity, ALGADJPAAGL data)
	{
	}

	public void InitSocialButtonWidgetEntity(UGCLogicEntity widgetEntity, ALGADJPAAGL data)
	{
	}

	public OCGHOAIKOGG GetHudPrefabData(uint hudID)
	{
		return null;
	}

	private LBHDMMIEANP GetWidgetObjByName(string widgetName, List<LBHDMMIEANP> children)
	{
		return null;
	}

	private Vector3 CreateVector3(KCEOCGOLEAD value)
	{
		return default(Vector3);
	}

	private Vector2 CreateVector2(BHHFHBEKKFJ value)
	{
		return default(Vector2);
	}

	private Vector2 CreateAnchorPropsFromOldAlignData(int horizontalAlignment, int verticalAlignment)
	{
		return default(Vector2);
	}

	private float CreateAlpha(int value)
	{
		return 0f;
	}

	public string[] GetChildren(string entityID)
	{
		return null;
	}

	public string GetParent(string entityID)
	{
		return null;
	}

	public string CloneEntity(string entityID)
	{
		return null;
	}

	private string CloneWidgetEntityWithParent(string oriEntityID, string parentEntityID)
	{
		return null;
	}

	private string CloneHudEntity(string oriHudEntityID)
	{
		return null;
	}

	public void SetParent(string childEntityID, string parentEntityID, bool keepWordPos)
	{
	}

	private bool CheckSetParentActionLegal(string childEntityID, string parentEntityID)
	{
		return false;
	}

	public void SetParentToNewEntity(string childEntityID, string newHudEntityID, string oriHudEntityID, UGCLogicEntity newHudEntity, string parentEntityID, object newPrefabID, object oriPrefabID)
	{
	}

	public void SetAccountID(string entityID, string value)
	{
	}

	public string GetAccountID(string entityID)
	{
		return null;
	}

	public void SetHudProfileInfoData(ulong accountID, uint headID, uint bannerID, uint pinID, string nickName, uint brRank, uint brPeakRank, uint csRank, uint csPeakRank)
	{
	}

	public void LoadParameters(Dictionary<object, object> parameters)
	{
	}

	public void GetWidgetAnchorPosition(string entityID, Vector3 s, Vector3 d, ref Vector3 src, ref Vector3 dst)
	{
	}

	public Vector2 GetWidgetSize(string entityID)
	{
		return default(Vector2);
	}

	public UGCUIBehaviour GetWidget(string entityID)
	{
		return null;
	}

	public bool SetWidgetSize(string entityID, Vector2 size)
	{
		return false;
	}

	public void CreateCustomHudWithLogicEntityDataByAssetID(string hudAssetID, EntityIndex entityIndex, IUGCUser user)
	{
	}

	public string GetHudAssetID(string hudEntityID)
	{
		return null;
	}

	public string GetHudWidgetID(string hudEntityID, string widgetID)
	{
		return null;
	}
}
