using System;
using System.Collections.Generic;

public class Song
{
  private string name;
  public Song NextSong { get; set; }

  public Song(string name)
  {
    this.name = name;
  }

  public bool IsRepeatingPlaylist()
  {
    var songs = new HashSet<string>(new[] { name });
    var thisNextSong = this.NextSong;
    while (thisNextSong != null)
    {
      if (songs.Contains(thisNextSong.name))
      {
        return true;
      }
      songs.Add(thisNextSong.name);
      thisNextSong = thisNextSong.NextSong;
    }

    return false;
  }

  public static void Main(string[] args)
  {
    Song first = new Song("Hello");
    Song second = new Song("Eye of the tiger");

    first.NextSong = second;
    second.NextSong = first;

    Console.WriteLine(first.IsRepeatingPlaylist());
  }
}
