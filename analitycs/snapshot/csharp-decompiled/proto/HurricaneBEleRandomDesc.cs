using System.Collections.Generic;

namespace proto;

public class HurricaneBEleRandomDesc
{
	public uint level_id;

	public List<HurricaneBRandomEle> elements;

	public List<HurricaneBTarget> targets;

	public uint steps_required_1;

	public uint steps_required_2;

	public uint total_steps;
}
