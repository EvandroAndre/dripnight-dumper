using System.Collections.Generic;

namespace proto;

public class CSGetVeteranConfigDescRes
{
	public List<VeteranAwardDesc> veteran_award;

	public VeteranConfigDesc veteran_config;

	public List<TeamUpBonusVeteranDesc> bonus_veteran_config;

	public List<VeteranAwardDesc> veteran_special_award;

	public uint veteran_special_stage_price;

	public List<VeteranModeMainDesc> vet_mode_main_configs;

	public List<VeteranModeSubDesc> vet_mode_sub_configs;
}
