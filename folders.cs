using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

public class Folders
{
  public static IEnumerable<string> FolderNames(string xml, char startingLetter)
  {
    var doc = XDocument.Parse(xml);
    var names =
        from folder
        in doc.Descendants()
        where folder.Attribute("name").Value.StartsWith(startingLetter.ToString())
        select folder.Attribute("name").Value;
    return names;

  }

  public static void (string[] args)
    {
        string xml =
            "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
            "<folder name=\"c\">" +
                "<folder name=\"program files\">" +
                    "<folder name=\"uninstall information\" />" +
                "</folder>" +
                "<folder name=\"users\" />" +
            "</folder>";

        foreach (string name in Folders.FolderNames(xml, 'u'))
            Console.WriteLine(name);
    }
}
