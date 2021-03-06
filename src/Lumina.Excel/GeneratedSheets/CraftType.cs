// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CraftType", columnHash: 0xb92c9b70 )]
    public class CraftType : IExcelRow
    {
        
        public byte MainPhysical;
        public byte SubPhysical;
        public SeString Name;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            MainPhysical = parser.ReadColumn< byte >( 0 );
            SubPhysical = parser.ReadColumn< byte >( 1 );
            Name = parser.ReadColumn< SeString >( 2 );
        }
    }
}