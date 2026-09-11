namespace COW.GamePlay.UGCRuntime;

public interface IBridgingEntity
{
	int BridgingTypeID();

	string UGCEntityID();

	void OnLogicEntityCreated(string entityID);

	IUGCValue BridgingPropGetter(long bridgingProp);

	bool BridgingPropSetter(long bridgingProp, UGCSimpleValue value);
}
