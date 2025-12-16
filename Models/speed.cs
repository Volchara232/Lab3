using System;

using System.Text.Json.Serialization;

namespace Models
{
    public class Speed
    {
        public float value { get; set; }
        public float angle { get; set; }

        [JsonIgnore]

        public float x
        {
            get { return value * (float)Math.Cos(angle * Math.PI / 180); }
        }

        [JsonIgnore]

        public float y
        {
            get { return value * (float)Math.Sin(angle * Math.PI / 180); }
        }

        public Speed()
        {
            value = 0;
            angle = 0;
        }
        public Speed(float value_ = 0, float angle_ = 0)
        {
            value = value_;
            angle = angle_;
        }
    }
}