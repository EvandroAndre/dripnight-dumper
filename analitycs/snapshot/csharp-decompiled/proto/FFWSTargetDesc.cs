using System.Collections.Generic;

namespace proto;

public class FFWSTargetDesc
{
	public EMiniGame.FFWS03ManagerStageType stage_type;

	public uint target;

	public List<AwardDesc> awards;

	public uint pre_target;

	public string key;
}
