// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SpearfishingItem", columnHash: 0xd17632b4 )]
    public class SpearfishingItem : IExcelRow
    {
        
        public SeString Description;
        public LazyRow< Item > Item;
        public LazyRow< GatheringItemLevelConvertTable > GatheringItemLevel;
        public LazyRow< FishingRecordType > FishingRecordType;
        public LazyRow< TerritoryType > TerritoryType;
        public bool IsVisible;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Description = parser.ReadColumn< SeString >( 0 );
            Item = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 1 ), language );
            GatheringItemLevel = new LazyRow< GatheringItemLevelConvertTable >( lumina, parser.ReadColumn< ushort >( 2 ), language );
            FishingRecordType = new LazyRow< FishingRecordType >( lumina, parser.ReadColumn< byte >( 3 ), language );
            TerritoryType = new LazyRow< TerritoryType >( lumina, parser.ReadColumn< ushort >( 4 ), language );
            IsVisible = parser.ReadColumn< bool >( 5 );
        }
    }
}