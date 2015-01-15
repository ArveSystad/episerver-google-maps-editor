using System;
using System.Globalization;
using EPiServer.Core;
using EPiServer.PlugIn;

namespace EPiServer.GoogleMapsEditor
{
    [PropertyDefinitionTypePlugIn]
    public class PropertyMapCoordinates : PropertyString
    {
        public MapPoint MapPoint
        {
            get
            {
                if (!string.IsNullOrEmpty(String))
                    return GetMapPoint(String);
                return null;
            }
            set
            {
                base.String = string.Format(CultureInfo.InvariantCulture, "{0},{1}", value.Latitude, value.Longitude);
            }
        }

        public override object Value
        {
            get { return MapPoint; }
            set
            {
                MapPoint mapPoint = value as MapPoint;
                if (mapPoint != null)
                    MapPoint = mapPoint;
                else
                    base.Value = value;
            }
        }

        private MapPoint GetMapPoint(string rawValue)
        {
            string[] strings = rawValue.Split(new[] { ',' });

            double latitude = double.Parse(strings[0], CultureInfo.InvariantCulture);
            double longitude = double.Parse(strings[1], CultureInfo.InvariantCulture);

            return new MapPoint { Latitude = latitude, Longitude = longitude };
        }

        public override Type PropertyValueType
        {
            get { return typeof(MapPoint); }
        }

        public override object SaveData(PropertyDataCollection properties)
        {
            return base.String;
        }
    }
}