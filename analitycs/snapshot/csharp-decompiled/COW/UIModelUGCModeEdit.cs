using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

public class UIModelUGCModeEdit : UIBaseModel
{
	public UIModeEditData CurrentModeSetting;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public CLMPMGMIDGD GetModeSettingProtoData()
	{
		return null;
	}

	public void BuildSettingFromModeWithTemplateSetting(uint mode, uint template)
	{
	}

	public void BuildSettingFromProtoData(CLMPMGMIDGD protoData)
	{
	}

	public void BuildSettingFromDefault(uint mapID)
	{
	}

	public List<uint> GenerateTagKeys()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
