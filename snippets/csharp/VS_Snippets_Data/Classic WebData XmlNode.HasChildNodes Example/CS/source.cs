﻿// <Snippet1>
using System;
using System.IO;
using System.Xml;

public class Sample {

  public static void Main() {

    XmlDocument doc = new XmlDocument();
    doc.LoadXml("<book ISBN='1-861001-57-5'>" +
                "<title>Pride And Prejudice</title>" +
                "<price>19.95</price>" +
                "</book>");

    XmlNode root = doc.FirstChild;

    //Display the contents of the child nodes.
    if (root.HasChildNodes)
    {
      for (int i=0; i<root.ChildNodes.Count; i++)
      {
        Console.WriteLine(root.ChildNodes[i].InnerText);
      }
    }
  }
}
   // </Snippet1>

