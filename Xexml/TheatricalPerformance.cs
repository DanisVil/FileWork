using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Xexml
{
    [System.Xml.Serialization.XmlRoot("TheatricalPerformance")]
    public class TheatricalPerformance 
    {
        [System.Xml.Serialization.XmlElement("actors")]
        public Actors Actors { get; set; }
        [System.Xml.Serialization.XmlElement("decors")]
        public Decors Decors { get; set; }
        [System.Xml.Serialization.XmlElement("scenario")]
        public Scenario Scenario { get; set; }
    }
    public class Decor
    {
        [System.Xml.Serialization.XmlAttribute("id")]
        public int Id { get; set; }
        [System.Xml.Serialization.XmlElement("description")]
        public string Description { get; set; }
        [System.Xml.Serialization.XmlElement("majorColor")]
        public string MajorColor { get; set; }
        [System.Xml.Serialization.XmlElement("height")]
        public int Height { get; set; }
        [System.Xml.Serialization.XmlElement("width")]
        public int Width { get; set; }
    }
    public class Decors
    {
        [System.Xml.Serialization.XmlElement("decor")]
        public Decor[] DecorArray { get; set; }
    }
    public class Actor
    {
        [System.Xml.Serialization.XmlAttribute("id")]
        public int Id { get; set; }
        [System.Xml.Serialization.XmlElement("name")]
        public string Name { get; set; }
        [System.Xml.Serialization.XmlElement("education")]
        public Education Education { get; set; }
        [System.Xml.Serialization.XmlElement("experience")]
        public Experience Experience { get; set; }
    }
    public class Actors
    {
        [System.Xml.Serialization.XmlElement("actor")]
        public Actor[] Troupe { get; set; }
    }
    public class Education
    {
        [System.Xml.Serialization.XmlElement("edInstitution")]
        public string edInstitution { get; set; }
        [System.Xml.Serialization.XmlElement("YearOfEnding")]
        public int YearOfEnding { get; set; }
    }
    public class Experience
    {
        [System.Xml.Serialization.XmlElement("carierStart")]
        public int CarierStart { get; set; }
        [System.Xml.Serialization.XmlElement("participation")]
        public string Participation { get; set; }
    }
    public class Scenario
    {
        [System.Xml.Serialization.XmlElement("act")]
        public Act[] ActOrder { get; set; }
        [System.Xml.Serialization.XmlElement("name")]
        public string Name { get; set; }
    }
    public class Act
    {
        [System.Xml.Serialization.XmlAttribute("id")]
        public int Id { get; set; }
        [System.Xml.Serialization.XmlElement("description")]
        public string Description { get; set; }
    }
}
