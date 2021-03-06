// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonDanger", columnHash: 0xdc23efe7 )]
    public class DeepDungeonDanger : IExcelRow
    {
        
        public LazyRow< ScreenImage > ScreenImage;
        public LazyRow< LogMessage > LogMessage;
        public LazyRow< DeepDungeonFloorEffectUI > Name;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ScreenImage = new LazyRow< ScreenImage >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            LogMessage = new LazyRow< LogMessage >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            Name = new LazyRow< DeepDungeonFloorEffectUI >( lumina, parser.ReadColumn< ushort >( 2 ), language );
        }
    }
}