namespace MSR.LST.MDShow
{
    public enum PayloadType : byte
    {
        Unknown = 0,
        Chat = 96,
        xApplication2,
        xApplication3,
        xApplication4,
        xApplication5,
        xApplication6,
        xApplication7,
        xApplication8,
        xApplication9,
        xApplication10,
        Venue1 = 106,
        Venue2,
        Venue3,
        Venue4,
        Venue5,
        Venue6,
        Venue7,
        Venue8,
        Venue9,
        GroupChat = 115,
        FileTransfer = 116,
        ManagedDirectX = 117,
        Whiteboard = 118,
        SharedBrowser = 119,
        RichTextChat = 120,
        RTDocument = 121,               // Serialization of an RTDocument object, network protocol TBD
        PipecleanerSignal = 122,        // Diagnostic signal used by the Pipecleaner applications to test connectivity between nodes
        Test = 123,                     // Used for test cases
        FEC = 124,                      // Identifies a packet as containing Forward Error Correction information
        dynamicPresentation = 125,      // Obsolete, being replaced by RTDocument -- lifetime TBD
        dynamicVideo = 126,             // A video signal.  The format of the video signal is embedded in the data stream itself
        dynamicAudio = 127              // An audio signal.  The format of the audio signal is embedded in the data stream itself
    }
}
