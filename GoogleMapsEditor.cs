using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace EPiServer.GoogleMapsEditor
{
    [EditorDescriptorRegistration(TargetType = typeof(string), UIHint = UIHint)]
    public class GoogleMapsEditor : EditorDescriptor
    {
        public const string UIHint = "CoordinatesEditorDescriptor";

        public GoogleMapsEditor()
        {
            ClientEditingClass = "tedgustaf.googlemaps.Editor";
        }
    }
}