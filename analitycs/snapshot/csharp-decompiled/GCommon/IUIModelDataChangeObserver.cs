namespace GCommon;

public interface IUIModelDataChangeObserver
{
	void OnDataChanged(UIBaseModel model, uint propID, object[] param);

	uint GetInterestedPropID(UIBaseModel model);
}
