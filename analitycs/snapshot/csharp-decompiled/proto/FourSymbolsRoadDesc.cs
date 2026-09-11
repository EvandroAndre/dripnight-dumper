using System.Collections.Generic;

namespace proto;

public class FourSymbolsRoadDesc
{
	public uint node_id;

	public ELimitedEvent.FourSymbolsID symbol_id;

	public ELimitedEvent.FourSymbolsRoadNodeType node_type;

	public List<AwardDesc> awards;

	public string node_title;

	public string node_text;

	public uint start_time;

	public uint token_num_required;
}
