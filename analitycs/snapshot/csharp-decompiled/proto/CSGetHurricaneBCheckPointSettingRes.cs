using System.Collections.Generic;

namespace proto;

public class CSGetHurricaneBCheckPointSettingRes
{
	public List<HurricaneBMapShapeDesc> maps_shape;

	public List<HurricaneBEleConfigDesc> maps_config;

	public List<HurricaneBEleRandomDesc> random_descs;
}
