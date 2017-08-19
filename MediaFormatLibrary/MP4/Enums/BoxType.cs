
namespace MediaFormatLibrary.MP4
{
    public enum BoxType : uint
    {
        AudioProfileEntry = 0x41505246, // 'APRF'
        AC3AudioSampleEntry = 0x61632D33, // 'ac-3'
        AC3SpecificBox = 0x64616333, // 'dac3'
        AVCVisualSampleEntry = 0x61766331, // 'avc1'
        AVCDecoderConfigurationRecordBox = 0x61766343, // 'avcC'
        BitRateBox = 0x62747274, // 'btrt'
        CompositionTimeToSampleBox = 0x63747473, // 'ctts'
        ChunkLargeOffsetBox = 0x636F3634, // 'co64'
        ChunkOffsetBox = 0x7374636F, // 'stco'
        DataEntryUrlBox = 0x75726C20, // 'url '
        DataInformationBox = 0x64696E66, // 'dinf'
        DataReferenceBox = 0x64726566, // 'dref'
        DecodingTimeToSampleBox = 0x73747473, // 'stts'
        EditBox = 0x65647473, // 'edts'
        EditListBox = 0x656C7374, // 'elst'
        ElementaryStreamDescriptorBox = 0x65736473, // 'esds'
        EncoderBox = 0xA9746F6F, // '�too'
        FileGlobalProfileEntry = 0x46505246, // 'FPRF'
        FileTypeBox = 0x66747970, // 'ftyp'
        FreeSpaceBox = 0x66726565, // 'free'
        HandlerReferenceBox = 0x68646C72, // 'hdlr'
        HVCVisualSampleEntry = 0x68766331, // 'hvc1'
        HVCDecoderConfigurationRecordBox = 0x68766343, // 'hvcC'
        InitialObjectDescriptorBox = 0x696F6473, // 'iods'
        ItemListBox = 0x696c7374, // 'ilst'
        MediaBox = 0x6D646961, // 'mdia'
        MediaDataBox = 0x6D646174, // 'mdat'
        MediaHeaderBox = 0x6D646864, // 'mdhd'
        MediaInformationBox = 0x6D696E66, // 'minf'
        MetaBox = 0x6D657461, // 'meta'
        MetaDataBox = 0x4D544454, // 'MTDT'
        MetaDataValueBox = 0x64617461, // 'data'
        MovieBox = 0x6D6F6F76, // 'moov'
        MovieExtendsBox = 0x6D766578, // 'mvex'
        MovieFragmentBox = 0x6D6F6F66, // 'moof'
        MovieFragmentRandomAccessBox = 0x6D667261, // 'mfra'
        MovieHeaderBox = 0x6D766864, // 'mvhd'
        MP4AudioSampleEntry = 0x6D703461, // 'mp4a'
        NameBox = 0x6E616D65, // 'name'
        NullMediaHeaderBox = 0x6E6D6864, // 'nmhd'
        SampleDescriptionBox = 0x73747364, // 'stsd'
        SampleSizeBox = 0x7374737a, // 'stsz'
        SampleTableBox = 0x7374626C, // 'stbl'
        SampleToChunkBox = 0x73747363, // 'stsc'
        SoundMediaHeaderBox = 0x736D6864, // 'smhd'
        SyncSampleBox = 0x73747373, // 'stss'
        UserDataBox = 0x75647461, // 'udta'
        UserBox = 0x75756964, // 'uuid'
        VideoMediaHeaderBox = 0x766D6864, // 'vmhd'
        VideoProfileEntry = 0x56505246, // 'VPRF'
        TrackBox = 0x7472616B, // 'trak'
        TrackHeaderBox = 0x746B6864, // 'tkhd'
        TrackReferenceBox = 0x74726566, // 'tref'
    }
}
