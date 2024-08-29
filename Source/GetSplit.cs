using System;
using System.Xml;
using Verse;

namespace XmlGetSplit
{
    public class GetSplit : PatchOperationPathed
    {
        public string sep = "~";
        public string storeTo = "";

        public static void Log(string s)
        {
            Verse.Log.Message($"[XmlGetSplit] {s}");
        }

        protected override bool ApplyWorker(XmlDocument xml)
        {
            XmlNode? node;
            string? value;

            node = xml.SelectSingleNode(storeTo);
            value = xml.SelectSingleNode(xpath).InnerText;

            node.RemoveAll();

            foreach (var s in value.Split(new[] { sep }, StringSplitOptions.None))
            {
                var liNode = xml.CreateElement("li");
                liNode.InnerText = s;
                node.AppendChild(liNode);
            }

            return true;
        }
    }
}
