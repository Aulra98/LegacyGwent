using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("42007")]//罗契：冷酷之心
	public class RocheMerciless : CardEffect
	{//摧毁1个背面向上的伏击敌军单位。
		public RocheMerciless(GameCard card) : base(card){}
		public override async Task<int> CardPlayEffect(bool isSpying,bool isReveal)
		{
			return 0;
		}
	}
}