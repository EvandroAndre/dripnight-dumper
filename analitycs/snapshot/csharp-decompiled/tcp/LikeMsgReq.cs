using System.Collections.Generic;

namespace tcp;

public class LikeMsgReq
{
	public ulong sender_id;

	public List<LikeMsg> like_list;
}
