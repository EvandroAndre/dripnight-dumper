using GCommon;

namespace COW;

internal class UISceneEditGMVerifyController : UIBaseController, IUIModelDataChangeObserver
{
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}
}
