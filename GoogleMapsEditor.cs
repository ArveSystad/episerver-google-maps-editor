using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace EPiServer.GoogleMapsEditor
{
    [EditorDescriptorRegistration(TargetType = typeof(MapPoint), EditorDescriptorBehavior = EditorDescriptorBehavior.Default)]
    public class GoogleMapsEditor : EditorDescriptor
    {
        public GoogleMapsEditor()
        {
            ClientEditingClass = "tedgustaf/googlemaps/Editor";
        }
    }
}