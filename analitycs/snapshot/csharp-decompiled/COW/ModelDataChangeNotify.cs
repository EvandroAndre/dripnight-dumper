using GCommon;

namespace COW;

public class ModelDataChangeNotify : NotifyBase
{
	public UIBaseModel Model;

	public uint PropID;

	public object[] Param;

	public ModelDataChangeNotify(UIBaseModel model, uint propID, object[] param)
	{
	}
}
