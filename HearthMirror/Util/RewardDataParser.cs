using System.Collections.Generic;
using HearthMirror.Objects;

namespace HearthMirror.Util
{
	internal static class RewardDataParser
	{
		public static List<RewardData> Parse(dynamic rewards)
		{
			if(rewards == null)
				return new List<RewardData>();
			var returnList = new List<RewardData>();
			foreach(var reward in rewards)
			{
				if(reward == null)
					continue;
				var data = ParseReward(reward);
				if(data != null)
					returnList.Add(data);
			}
			return returnList;
		}

		private static RewardData ParseReward(dynamic reward)
		{
			switch((string)reward?.Class.Name)
			{
				case "ArcaneDustRewardData":
					return new ArcaneDustRewardData((int)reward["<Amount>k__BackingField"]);
				case "BoosterPackRewardData":
					return new BoosterPackRewardData((int)reward["<Id>k__BackingField"], (int)reward["<Count>k__BackingField"]);
				case "CardRewardData":
					return new CardRewardData((string)reward["<CardID>k__BackingField"], (int)reward["<Count>k__BackingField"], (int)reward["<Premium>k__BackingField"] > 0);
				case "CardBackRewardData":
					return new CardBackRewardData((int)reward["<CardBackID>k__BackingField"]);
				case "ForgeTicketRewardData":
					return new ForgeTicketRewardData((int)reward["<Quantity>k__BackingField"]);
				case "GoldRewardData":
					return new GoldRewardData((int)reward["<Amount>k__BackingField"]);
				case "MountRewardData":
					return new MountRewardData((int)reward["<Mount>k__BackingField"]);
			}
			return null;
		}
	}
}
