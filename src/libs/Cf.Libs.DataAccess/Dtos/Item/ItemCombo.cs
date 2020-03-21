using Cf.Libs.DataAccess.Dtos.Setting;
using System.Collections.Generic;

namespace Cf.Libs.DataAccess.Dtos.Item
{
    public class ItemCombo : JumbotronDto
    {
        public IEnumerable<ItemDto> Items { get; set; }
    }
}
