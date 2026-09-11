using COW.GamePlay;
using message;

namespace COW.Gameplay.UGC;

public interface IUGCLogicEntityBridging
{
	SceneEditObjectBase EditObj { get; }

	bool Init(string entityID, SceneEditObjectBase editObj, long[] componentIDs);

	void Destroy();

	void AddCustomProp(long propID, UGCVarValueDataV2 value);

	void RemoveCustomProp(long propID);

	void ManuallyApplyPropToEditObj(long propID, bool isManullyChanged = true);

	void ManualApplyAllDataStorePropsToEditObj(bool isManullyChanged = true);
}
