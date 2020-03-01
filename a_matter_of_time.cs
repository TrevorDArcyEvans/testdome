using System;
using System.Collections.Generic;
using System.Linq;

public class BasicTimeEntryService
{
  public static readonly string PROJECT_AWS = "AWS";
  public static readonly string PROJECT_DELL = "DELL";

  private List<string> validUsers = new List<string>()
        { "Phoebe", "George", "Ethan", "Gregory"};

  private string project = null;
  private Dictionary<string, int> timeLogByUser = new Dictionary<string, int>();

  public BasicTimeEntryService(string project)
  {
    this.project = project;
  }

  public void RecordTime(string user, int hoursSpent)
  {
    if (!IsValidUser(user))
    {
      throw new Exception("Invalid user");
    }

    timeLogByUser.TryGetValue(user, out int timeLogForUser);

    int totalTime = timeLogForUser + hoursSpent;

    if (!timeLogByUser.ContainsKey(user))
    {
      timeLogByUser.Add(user, 0);
    }
    timeLogByUser[user] = totalTime;
  }

  public int GetTotalTime(string user)
  {
    timeLogByUser.TryGetValue(user, out int totalTime);
    return totalTime;
  }

  public string GetTotalTimeDesc(string user)
  {
    int timeForUser = GetTotalTime(user);
    return string.Format($"{user} has spent a total of {timeForUser} on {project}");
  }

  public int GetTotalTimeAllUsers()
  {
    return timeLogByUser.Sum(x => x.Value);
  }

  private bool IsValidUser(string user)
  {
    return validUsers.Contains(user);
  }
}
