using System.Collections.Generic;

namespace proto;

public class CSGetSparkDescRes
{
	public List<SparkActiveDesc> spark_active_descs;

	public List<SparkLevelAwardDesc> spark_level_award_descs;

	public List<SparkColorWheelDesc> spark_color_wheel_descs;

	public SparkExpSettingDesc spark_exp_setting_desc;
}
