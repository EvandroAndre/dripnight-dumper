using System.Collections.Generic;

namespace proto;

public class CSGetSeventhBSettingRes
{
	public List<BigEventProgressAwardDesc> progress_awards;

	public BigEventProgressCycleAwardDesc cycle_award;

	public SeventhBSettingDesc settings;

	public List<SeventhBChapterDesc> chapters;

	public List<SeventhBPictureDesc> pictures;

	public List<SeventhBDataDesc> datas;

	public List<SeventhBEasterEggDesc> eastereggs;

	public List<SeventhBSpecialDataDesc> special_datas;

	public List<BigEventShowAwardDesc> show_rewards;
}
