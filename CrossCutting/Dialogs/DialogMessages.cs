namespace MVVM_Template.CrossCutting
{
    /// <summary>
    /// Static messages for dialog box settings.
    /// Variable names have the following format: [Pane, Control, Window, Class][Action Type][Object Type][Dialog Type]Message
    /// 
    /// [Pane, Control, Window]: Icon, Element, Navigation, Dynamic, etc...
    ///           [Action Type]: Delete, Remove, Add, Insert, etc...
    ///           [Object Type]: Trip, Sighting, User, File, etc...
    ///           [Dialog Type]: Information, Warning, Error, Other, etc...
    ///                    
    /// Examples: IconDeleteSightingWarningMessage 
    ///           ElementSaveHaulInformationMessage
    ///           CreateTripInsertTripInformationMessage
    ///           
    /// </summary>
    public static class DialogMessages
    {
        public static readonly string DeleteWarningMessage = "You are about to delete an entire object! This is recursive and deletes everything associated with this object!\n\n" +
                                                                     "Are you absolutely sure you want to do this?";

        public static readonly string TruncateWarningMessage = "You are about to truncate/purge database tables!\n\n" +
                                                             "Are you sure you want to do this?";
    }
}